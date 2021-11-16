using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MasonDatabase.Models
{
    public class ApplicationsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ApplicationsContext() : base("name=ApplicationsContext")
        {
            Database.SetInitializer<ApplicationsContext>(new DBInitializer());
        }

        public System.Data.Entity.DbSet<MasonDatabase.Models.Application> Applications { get; set; }

        public System.Data.Entity.DbSet<MasonDatabase.Models.Major> Majors { get; set; }

        public System.Data.Entity.DbSet<MasonDatabase.Models.Semester> Semesters { get; set; }
    }
}
