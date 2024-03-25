using System;

namespace SomerenModel
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public int Floor { get; set; }
        public int NumberOfBeds { get; set; }

        public override string ToString()
        {
            return $"{RoomNumber} {RoomType} {Floor} {NumberOfBeds}";
        }
    }
}