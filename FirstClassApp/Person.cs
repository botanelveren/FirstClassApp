using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassApp
{
    public class Person
    {
        public string name;
        public string lastName;
        public string birthOfDate;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }


        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string BirthOfDate
        {
            get
            {
                return birthOfDate;
            }
            set
            {
                birthOfDate = value;
            }
        }
    }
}
