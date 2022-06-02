using System;

namespace EventsAPI.Models
{
    public class Student : BaseModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; set; }
        public int schoolYear { get; set; }

        public Student()
        {

        }

    }
}
