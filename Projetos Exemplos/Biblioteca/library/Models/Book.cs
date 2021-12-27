using System;
using Dapper.Contrib.Extensions;

namespace library.Models
{
    [Table("[Book]")]
    public class Book
    {
       public Guid Id { get; set; }
       public string Title { get; set; }
       public string ISBN { get; set; }
       public string Author { get; set; }
       public string Publisher { get; set; }
       public string YearOfPublication { get; set; } 
    }
}