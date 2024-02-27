using System;
namespace BookApp.Models
{
	public class Book
	{
        public string Name { get; set; }

        public string Author { get; set; }

        public int PageNumber { get; set; }

        public DateTime DueDate { get; set; }

        public Book()
        {
            DueDate = DateTime.Now;
        }

    }
}

