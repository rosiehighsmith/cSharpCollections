﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string monday = "Monday";
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                sb.Append(daysOfWeek[i]);
                if (i < daysOfWeek.Length - 2)
                    sb.Append(", ");
                else if (i == daysOfWeek.Length - 2)
                    sb.Append(", and ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
