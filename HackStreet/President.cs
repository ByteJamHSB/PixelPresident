using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackStreet
{
    [Serializable]
    public class President
    {
        string party;
        int age;
        string gender;
        string race;
        char cType;
        char gtype;


        public string Party
        {
            get
            {
                return party;
            }
            set
            {
                if (value.Trim().Length > 0)
                {
                    party = value.Trim();
                }
                else
                {
                    party = "Rebuplican";
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 35)
                {
                    age = value;
                }
                else
                {
                    age = 36;
                }
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if(value.Trim().Length > 0)
                {
                    gender = value.Trim();
                }
                else
                {
                    gender = "Male";
                }
            }
        }
        public string Race
        {
            get { return race; }
            set
            {
                if (value.Trim().Length > 0)
                {
                    race = value.Trim();
                }
                else
                {
                    race = "Caucasian";
                }
            }
        }
        public char Ctype {
            get { return cType; }
            set
            {
                if (char.ToUpper(value) == 'D' || char.ToUpper(value) == 'R' || char.ToUpper(value) == 'L' || char.ToUpper(value) == 'G')
                {
                    cType = char.ToUpper(value);
                }
            }
        }
        
        //default constructor
        public President()
        {
            Ctype = 'D';
           Gender = "Male";
            Age = 36;
            Race = "Caucasian";
        }

        //overloaded constructor
        public President(string party,  string gender, int age, string race)
        {
            Party = party;
            Gender = gender;
            Age = age;
            Race = race;
        }

        public override string ToString()
        {
            string ctype;
            

            if (Ctype == 'D')
            {
                ctype = "Democratic Party";
            }
            else if (Ctype == 'R')
            {
                ctype = "Rebuplican Party";
            }
            else if (Ctype =='L')
            {
                ctype = "Libertarian party";
            }
            else if(Ctype=='G')
            {
                ctype = "Green Party";
            }

            
            return "Presidential Party: " + cType +
                    "\nGender: " + Gender +
                    "\nAge: " + Age.ToString() +
                    "\nRace: " + Race;
            
        }
    }
}
