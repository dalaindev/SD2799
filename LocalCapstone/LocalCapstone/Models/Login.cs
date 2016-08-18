using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LocalCapstone.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }

}