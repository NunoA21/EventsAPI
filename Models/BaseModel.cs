using System;

namespace EventsAPI.Models
{
    public class BaseModel
    {
        public int id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime AlterationDate { get; set; }
        public string CreationUser { get; set; }
        public string AlterationUser { get; set; }
    }
}
