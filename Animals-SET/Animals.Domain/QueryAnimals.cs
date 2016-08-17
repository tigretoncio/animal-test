﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    public static class QueryAnimals
    {
        public static List<Animal> GetAnimalsByName(string name)
        {
            var animalsByName = GroupOfAnimals.Members()
                .Where(p => p.Name == name)
                .ToList();

            return animalsByName;
        }

        public static List<Animal> GetAnimalsOlderThan(int age)
        {
            var animalsByName = GroupOfAnimals.Members()
                .Where(p => p.Age > age).ToList();

            return animalsByName;
        }

        // this one does not work, and I don't understand why... list is always null
        //public static List<Animal> SortAnimalsByName()
        //{
        //    var sortedAnimals = GroupOfAnimals.Members().OrderBy(x => x.Name).ToList();

        //    return sortedAnimals;
        //}
    }
}