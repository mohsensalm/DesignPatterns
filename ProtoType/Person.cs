﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class Person 
    {
        public int Age ;
        public DateTime BirthDate;
        public string Name;
        public int num;

        public IdInfo IdInfo;


        public Person ShallowCopy()
        {
            return (Person) MemberwiseClone();
        }

        public Person DeepCopy()
        {
            var clone = (Person) MemberwiseClone();
            clone.IdInfo = new IdInfo (IdInfo.IdNumber);
            clone.Name = Name ;
            return clone;
        }
    }

   
}
