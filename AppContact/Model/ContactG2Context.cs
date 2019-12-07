using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContact.Model
{
    public class ContactG2Context : DbContext
    {
        public ContactG2Context() : base("Data Source=.;Initial Catalog=DB_Contact;User ID=sa;Password=123")
        {

        }

        public DbSet<Contact> ContactDbSet { get; set; }
        public DbSet<User> UserDbSet { get; set; }
    }
}
