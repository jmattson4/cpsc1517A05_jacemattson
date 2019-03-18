using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespace
using Northwind.Data;//Obtains the <T> Definitions 
using NorthwindSystem.DAL;//obtains the context Class
#endregion
namespace NorthwindSystem.BLL
{
    //this class needs to be called from another class(es)
    //  therefore we must make it public
    //This class is part of the system interface to the 
    //  Web Application (and/or any other client that
    //  needs to get to the Northwind database)
    //This class is the entry point into the Northwind System
    //This class needs to be public
    public class ProductController
    {
        //this method will receive a value that 
        //  represents the ProductID
        //This method will forward the value to 
        //  the DBSet<T> in the DBContext Class
        //  for processing 
        //This Method Will return an instance of product
        //This Method must be public 
        public Product Product_Get(int productid)
        {
            //the instantiation of the DbContext Class will 
            //  be done in a transaction using group
            using (var context = new NorthwindContext())
            {
                //return the results of the method call
                //context points to the DAL context class
                //Products is the DbSet<T>
                //.Find(pkeyvalue) looks for a set record
                //  whose primary key is equal to the 
                //  supplied value
                return context.Products.Find(productid);
            }
        }
        //this method will return all records of a DBSet<T>
        //no parameter value is necessary
        public List<Product> Product_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }
    }
}
