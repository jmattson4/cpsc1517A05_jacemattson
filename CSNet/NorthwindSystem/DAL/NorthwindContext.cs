using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;//for the EntityFramework ADO.Net Stuff
using Northwind.Data;// for the <T> definitions 
#endregion

//this class needs to have acces to ADO.Net in EntityFramework
//the NuGet package manager will have the EntityFramework, install.
//this project needs the assembly System.Data.Entity
//this project needs a reference to your .Data project (CBO)
//this project needs to use the following namespaces
//a) System.Data.Entity
//b) .Data project namespace
namespace NorthwindSystem.DAL
{
    //the class access is restricted to request from within the
    //  library the class exists in: internal
    //  this is done for security reasons
    //the class inherits (ties into EntityFramework) the class DBcontext
    internal class NorthwindContext : DbContext
    {
        //setup your class default constructor to supply 
        //  your connection string name to the DbContext
        //  inherited (base) class
        public NorthwindContext():base("NWDB")
        {

        }
        //create an entity framework DbSet<T> foreach 
        //  mapped SQL table
        //<T> is your class in the .Data project 
        //this is a property
        public DbSet<Product> Products { get; set; }
    }
}
