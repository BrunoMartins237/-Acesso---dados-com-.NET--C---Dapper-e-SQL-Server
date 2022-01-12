using System;
using Dapper.Contrib.Extensions;

namespace PhoneBook.Models
{
    [Table("[Contact]")]
    public class Contact
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }
    }
}