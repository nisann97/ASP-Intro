﻿using System;
namespace Homework_1st.Models
{
	public class Employee : BaseEntity
	{
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
    }
}

