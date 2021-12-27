using System;

namespace library.Models
{
    public class Books
    {
       public Guid Id { get; set; }
       public string Title { get; set; }
       public string ISBN { get; set; }
       public string Author { get; set; }
       public string Publisher { get; set; }
       public string YearOfPublication { get; set; } 
    }
}