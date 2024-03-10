using System;

namespace clubMemberIndexer
{
    class ClubMembers
    {
        public const int Size = 15; // Move the Size constant inside the ClubMembers class
        private string[] Members = new string[Size];
        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // Default constructor
        public ClubMembers()
        {
            ClubType = "";
            ClubLocation = "";
            MeetingDate = "";
        }

        // Indexer get and set methods
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < Size)
                    return Members[index];
                else
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
            set
            {
                if (index >= 0 && index < Size)
                    Members[index] = value;
                else
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClubMembers club = new ClubMembers();

            // Adding values to the Members indexer
            club[0] = "John";
            club[1] = "Jane";
            club[2] = "Alice";

            // Adding values 
            club.ClubType = "Book Club";
            club.ClubLocation = "Library";
            club.MeetingDate = "Every Saturday";

            // Display club information
            Console.WriteLine("Club Information:");
            Console.WriteLine($"Club Type: {club.ClubType}");
            Console.WriteLine($"Club Location: {club.ClubLocation}");
            Console.WriteLine($"Meeting Date: {club.MeetingDate}");
            Console.WriteLine("Club Members:");
            for (int i = 0; i < ClubMembers.Size; i++) // Access Size using the class name
            {
                if (!string.IsNullOrEmpty(club[i]))
                {
                    Console.WriteLine($"- {club[i]}");
                }
            }
        }
    }
}

