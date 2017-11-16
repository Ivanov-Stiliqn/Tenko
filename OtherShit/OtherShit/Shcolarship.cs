using System;
using System.Collections.Generic;
using System.Text;

namespace OtherShit
{
    public class Shcolarship
    {
        private readonly decimal grade;

        public Shcolarship(decimal grade)
        {
            this.grade = grade;
        }

        public decimal Money
        {
            get
            {
                if (this.grade >= 4.00m && this.grade <= 4.39m)
                {
                    return 10;
                }
                else if (this.grade >= 4.50m && this.grade <= 5.49m)
                {
                    return 50;
                }
                else if (this.grade >= 5.50m)
                {
                    return 100;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
