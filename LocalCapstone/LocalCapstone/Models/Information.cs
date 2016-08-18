using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LocalCapstone.Models
{
    public class Information
    {
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelePhone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; } 
        public int Id { get; set; }
    }
    public class datainstance:DbContext {
        public DbSet<Information> Information { get; set; }

        public System.Data.Entity.DbSet<LocalCapstone.Models.Login> Logins { get; set; }
    }
}