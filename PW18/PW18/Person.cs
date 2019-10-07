using System;
using System.Collections.Generic;
using System.Text;

namespace PW18
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthYear { get; set; }
    }
}
