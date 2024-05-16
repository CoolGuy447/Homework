using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    public class NumericalExpression
    {
        long num;
        public NumericalExpression(long num) //Q7a
        {
            this.num = num;
        }

        public override string ToString() //Q7b
        {
            if (this.num < 0 || this.num > 999999999999) //Q7c
            {
                return "number illegal";
            }
            if (this.num == 0)
            {
                return "zero";
            }

            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
            string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] bigs = { "", " Thousand", " Million", " Billion" };

            string output = "";
            long check = this.num;

            for(int i = 0; check > 0; i++)
            {
                long thousands = check % 1000;
                if (thousands != 0)
                {
                    string str = "";

                    if (thousands >= 100)
                    {
                        str = ones[thousands / 100] + " Hundred";
                        if (thousands % 100 != 0)
                            str += " ";
                    }

                    if (thousands % 100 < 10)
                    {
                        str += ones[thousands % 100];
                    }
                    else if (thousands % 100 < 20)
                    {
                        str += teens[thousands % 100 - 10];
                    }
                    else
                    {
                        str += tens[thousands % 100 / 10];
                        if (thousands % 10 != 0)
                            str += " " + ones[thousands % 10];
                    }

                    if (output == "")
                        output = str + bigs[i];
                    else
                        output = str + bigs[i] + " " + output;
                }
                check /= 1000;
            }
            return output;
        }

        public long GetValue() //Q7d
        {
            return this.num;
        }

        public static long SumLetters(int num) //Q7e
        {
            long sum = 0;
            for (int i = 0; i < num; i++)
            {
                NumericalExpression new_num = new NumericalExpression(i);
                string letter_num = new_num.ToString();
                letter_num = letter_num.Replace(" ", "");
                sum += letter_num.Length;
            }
            return sum;
        }

        // העקרון שבא לידי ביטוי הוא עקרון הפעלת פעולות על אובייקטים(invoke methods on objects)
        // כאשר יש פעולה ספציפית שמתייחסת לאובייקט מסוים והיא חלק מתכנות מונחה עצמים, ניתן להפעיל את הפעולה הזאת על ידי השימוש באובייקט עצמו
        // לדוגמה במקרה הזה הפונקצייה sumletter
        // שבתוך המחלקה numericalexpression
        // היא מתבצעת רק על אובייקטים מהמחלקה הזאת ולא מאובייקטים ממחלקות אחרות
        public static long SumLetters2(NumericalExpression num) //Q7f
        {
            long sum = 0;
            for (int i = 0; i < num.GetValue(); i++)
            {
                NumericalExpression new_num = new NumericalExpression(i);
                string letter_num = new_num.ToString();
                letter_num = letter_num.Replace(" ", "");
                sum += letter_num.Length;
            }
            return sum;
        }
    }
    class Q7
    {
    }
}
