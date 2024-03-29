﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Dove", Age = 3, Description = "Coo's on demand" },
            new Animal { Id = 2, Name = "Cat", Age = 50, Description = "Fluffy Cat" },
            new Animal { Id = 3, Name = "Dog", Age = 50, Description = "Shiny and glasslike" },
        };
    }
}
