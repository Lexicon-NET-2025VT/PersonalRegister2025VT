﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister2025VT
{
    class Droid
    {
        //Field, privat kommer inte åt utanför klassen. Liten bokstav
        private string firstname;

        private int salary;

        //Property, publik går att komma åt utanför klassen. Stor bokstav
        public int Salary
        {
            get { return salary; }
            set
            {
                if(value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
                    
            }
        }
        //Autoproperty 
        public int Salary2 { get; set; }

        //private int salary2;

        //public int Salary2
        //{
        //    get { return salary2; }
        //    set { salary2 = value; }
        //}

        public static int Count; 

        public Droid(string name, int salary)
        {
            firstname = name;
            Salary = salary;
            Count++;
        }
        public Droid(string name)
        {
            Count++;
        }
        public Droid()
        {
            Count++; 
        }

        public string GetFirstName()
        {
            return firstname; 
        }

        public void SetFirstName(string name)
        {
            firstname = name; 
        }


        public static void GetCount()
        {
            Console.WriteLine(Count);
        }
    }
}
