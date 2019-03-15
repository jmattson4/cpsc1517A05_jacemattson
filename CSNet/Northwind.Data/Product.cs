using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The annotations used within the .Data project will require
//  the System.ComponentModel.DataAnnotations assembly this 
//  assembly is added via your references.
#region Additional Namespaces 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion
namespace Northwind.Data
{
    //Use an annotation to link this class to the appropriate 
    //  SQL table [Table("NameOfSQLTable")]
    [Table("Products")]
    public class Product
    {
        //mapping of the SQL table attributes will be to
        //  class properties, one to one relationship
        //private data fields
        private string _QuantityPerUnit;
        //Use an annotation to identify the primary key
        //1) Identity pkey on your SQL table (Default )
        //   [Key] this assumes the identity pkey ending in ID or id
        //2) A compound pkey on your SQL table 
        //   [Key, Column(Order=n)] where n is the numeric value
        //   of the physical order of the attribute in the key
        //3) a user supplied Pkey on your SQL table
        //   [Key, DatabaseGenerated(DatabaseGenerated.Option.None)]
        //propeties
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit
        {
            get
            {
                return _QuantityPerUnit;
            }
            set
            {
                _QuantityPerUnit = string.IsNullOrEmpty(value.Trim()) ? null : value;
            }
        }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }


        //Sample of a computed field on your SQL table
        //to annotate this property to be taken as a 
        //  sql computed field use 
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public decimal SomeComputedSqlField {get; set;}

        //creating a readonly property that is NOT
        //  an actual field on your SQL table 
        //  means that NO data is actually transferred
        //example FirstName and LastName attributes are often
        //  combined into a single field for display
        //  such as FullName
        //Use the NotMapped Annotation to handle this scenario
        //[NotMapped]
        //public string FullName
        //{
        //    get
        //    {
        //        return FirstName + " " + LastName;
        //    }
        //}
    }
}
