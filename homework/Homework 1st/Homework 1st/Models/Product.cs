﻿using System;
namespace Homework_1st.Models
{
	public class Product : BaseEntity
	{
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}

