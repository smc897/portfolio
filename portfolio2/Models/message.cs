using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace portfolio2.Models
{
    public class message
    {
        public String content { get; set; }
        public String email { get; set; }
        public String name { get; set; }
        public int ID { get; set; }

        public message() {
            content = "";
            email = "";
            name = "";
        }
    }

    public class messageDBContext : DbContext {
        public messageDBContext() : base("DefaultConnection") {
        }
        public DbSet<message> messages { get; set; }

    }


}