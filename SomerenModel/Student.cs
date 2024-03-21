using System;

namespace SomerenModel
{
    public class Student
    {
        public int StudentNumber { get; set; }     // database id
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; } // Changed to string
        public string Class { get; set; }
        public int RoomNumber { get; set; }

        public override string ToString()
        {
            return $"{StudentNumber} {FirstName} {LastName} {TelephoneNumber} {Class} {RoomNumber}";
        }
    }
}