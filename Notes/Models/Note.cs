using System;
using SQLite;

namespace Notes.Models
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }

        public DateTime Date { get; set; }
    }
}