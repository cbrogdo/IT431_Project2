using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MasonDatabase_Project2.Models
{
    public class MasonDatabase_Project2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MasonDatabase_Project2Context() : base("name=MasonDatabase_Project2Context")
        {
            Database.SetInitializer<MasonDatabase_Project2Context>(new DropCreateDatabaseAlways<MasonDatabase_Project2Context>());

        }

        public System.Data.Entity.DbSet<MasonDatabase_Project2.Models.Application> Applications { get; set; }
    }
}
