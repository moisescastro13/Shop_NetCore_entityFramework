using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Entities
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
