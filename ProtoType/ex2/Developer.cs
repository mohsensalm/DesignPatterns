using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.ex2
{
    public class Developer : IEmployee
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string? PreferredLanguage { get; set; }

        public IEmployee  Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IEmployee) MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (IEmployee)this.Clone();

            //var clone = (Developer) MemberwiseClone();
            //clone.Name = "22";                         "using new key word is key of deep clone? and implement ref type "
            //return clone; 

        }


        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }
}
