﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Animals_SET.Animals.Domain
{
    /// <summary>
    /// defines a Cat object
    /// </summary>
    public class Cat : Animal, IMammal
    {
        public const int CATBREASTS = 8;

        private int _nbOfBreasts;
        private string _vertebrateType;
        
        public Cat()
        {
            Type = GetAnimalType();
            _vertebrateType = "bones";
        }

        public Cat(int id, string name, int age, char gender) : this()
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            if (gender.Equals('M') || gender.Equals('F'))
                this.Gender = gender;
        }

        public int NbOfBreasts
        {
            get { return this._nbOfBreasts = Gender.Equals('F') ? CATBREASTS : 0; }
 
        }

        public string VertebrateType
        {
            get { return _vertebrateType; }
        }
            
        public string FeedOffSpring()
        {
            string result = "";
            result = Gender.Equals('F') ? "Breastfeeding..." : "Sorry no food";

            return result;
        }

        public override string MakeSound()
        {
            return "meaw";
        }
    }
}