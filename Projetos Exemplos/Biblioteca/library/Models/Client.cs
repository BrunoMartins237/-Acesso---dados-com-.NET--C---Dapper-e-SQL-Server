using System;
using Dapper.Contrib.Extensions;

namespace library.Models
{
    [Table("[Client]")]
    public class Client
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Boolean Activated { get; set; }
    }
}