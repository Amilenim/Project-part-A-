﻿using Project.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Curator : IPerson
    {
        public int Income { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Curator(string firstName, string lastName, int age, int income)
        {
            throw new NotImplementedException();
        }
    }
}