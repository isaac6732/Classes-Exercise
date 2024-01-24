﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Classes
{
    internal class Car
    {
        public Car()
        {
           
        }

        public Car(string make,string model,int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; }
        
        public string Model { get; set; }

        public int Year { get; set; } 

        public void PrintCarInformation()
        {
            Console.WriteLine($"{Make} {Model} {Year}");
        }
        
    }
}
