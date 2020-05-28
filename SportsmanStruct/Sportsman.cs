using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsmanStruct
{
    struct Sportsman
    {
        public string name;
        private int age;
        public decimal bestResult;
        private int numberOfWins;
        private int numberOfInternationalWins;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
        public int NumberOfWins
        {
            get { return numberOfWins; }
            set
            {
                if (value < 0)
                {
                    numberOfWins = 0;
                }
                else
                {
                    numberOfWins = value;
                }
            }
        }
        public int NumberOfInternationalWins
        {
            get { return numberOfInternationalWins; }
            set
            {
                if (value > numberOfWins)
                {
                    numberOfInternationalWins = numberOfWins;
                }
                if (value < 0)
                {
                    numberOfInternationalWins = 0;
                }
                else
                {
                    numberOfInternationalWins = value;
                }
            }
        }
        public string GetSportsCategory()
        {
            string category;
            if (numberOfWins >= 15)
            {
                category = "1-й";
            }
            else if (numberOfWins >= 10)
            {
                category = "2-й";
            }
            else if (numberOfWins >= 5)
            {
                category = "3-й";
            }
            else
            {
                return "без разряда";
            }

            if (Age < 18)
            {
                return category + " юношеский";
            }
            else
            {
                return category + " взрослый";
            }
        }
        public string GetInternationalClass()
        {
            if (numberOfInternationalWins >= 9)
            {
                return "1-й международный класс";
            }
            else if (numberOfInternationalWins >= 6)
            {
                return "2-й международный класс";
            }
            else if (numberOfInternationalWins >= 3)
            {
                return "3-й международный класс";
            }
            else
            {
                return "без международного класса";
            }
        }

    }
}
