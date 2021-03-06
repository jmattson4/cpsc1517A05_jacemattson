﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region Additional Namespaces
using NorthwindSystem.BLL;  //points to the controller class
using NorthwindSystem.Data; //points to the record descriptions
#endregion

namespace WebApp.SamplePages
{
    public partial class SqlProcQueries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear old messages
            MessageLabel.Text = "";

            //load the dropdownlist on the first time processing this page
            if (!Page.IsPostBack)
            {
                //all calls should be done in user friendly error handling
                try
                {
                    //when the page is first loaded, obtain the
                    //   complete list of categories from the
                    //   database
                    CategoryController sysmgr = new CategoryController();
                    List<Category> datainfo = sysmgr.Category_List();
                    //sort this list alphabetically
                    datainfo.Sort((x, y) => x.CategoryName.CompareTo(y.CategoryName));
                    // assign the data to the dropdownlist control
                    CategoryList.DataSource = datainfo;
                    //indicate the DataTextField and DataValueField
                    CategoryList.DataTextField = nameof(Category.CategoryName);
                    CategoryList.DataValueField = nameof(Category.CategoryID);
                    //Bind the datasource
                    CategoryList.DataBind();
                    //add a prompt
                    CategoryList.Items.Insert(0, "select ...");
                }
                catch (Exception ex)
                {
                    MessageLabel.Text = ex.Message;
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //ensure a selection was made
            if (CategoryList.SelectedIndex == 0)
            {
                MessageLabel.Text = "Select a category of products to display";
            }
            else
            {
                //within user friendly error handling
                try
                {
                    //  connect to the appropriate controller
                    ProductController sysmgr = new ProductController();
                    //  issue a request to the controller's appropriate method
                    List<Product> datainfo = sysmgr.Product_GetByCategory(int.Parse(CategoryList.SelectedValue));
                    //  check results
                    if (datainfo.Count() == 0)
                    {
                        //    none ( .Count() == 0): message to user
                        MessageLabel.Text = "No product for select category";
                        //optionally clear out display
                        CategoryProductList.DataSource = null;
                        CategoryProductList.DataBind();
                    }
                    else
                    {
                        //    found: load a gridview
                        //optional sort on ProductName
                        datainfo.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
                        CategoryProductList.DataSource = datainfo;
                        CategoryProductList.DataBind();
                    }
                }
                catch(Exception ex)
                {
                    MessageLabel.Text = ex.Message;
                }
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            CategoryList.ClearSelection();
            CategoryProductList.DataSource = null;
            CategoryProductList.DataBind();
        }

        protected void CategoryProductList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //the E parameter will supply the new page index that is requested
            //you must set tge grid control page index to this supplied value
            CategoryProductList.PageIndex = e.NewPageIndex;
            //you must refresh your gridview with a call to the database
            try
            {
                ProductController sysmgr = new ProductController();
                List<Product> datainfo = sysmgr.Product_GetByCategory(int.Parse(CategoryList.SelectedValue));
                datainfo.Sort((x, y) => x.ProductName.CompareTo(y.ProductName));
                CategoryProductList.DataSource = datainfo;
                CategoryProductList.DataBind();
            }
            catch (Exception ex)
            {
                MessageLabel.Text = ex.Message;
            }
        }

        protected void CategoryProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this event belongs to the command select button
            //accessing the data is wholey dependant on the 
            //  type of data display used in the gridview cell
            //There are four different ways to access your data(because there ar 4 
            //  ways to set up your gridview cell.)
            //We have used the generic template technique to create our
            //  gridview cell contents
            //Templates allow the developer to place webcontrols 
            //  within each cell
            //When you access a webcontrol within the gridview cell
            //  you will reference the control type and then use 
            //  the control type access technique
            string productId;
            string discontinued;
            string productName;

            //personal style 
            GridViewRow agvrow = CategoryProductList.Rows[CategoryProductList.SelectedIndex];
            //grab ProductID 
            //syntax 
            //agvrow: this points to the selected gridview row
            //FindControl("ControlIDName"): this is the id value on gridview cell
            //as controlType: this indicates the type of web control within the gridview
            //  cell that you are touching.
            //(xxxx).text: indicates the webcontrol access technique
            productId = (agvrow.FindControl("ProductID") as Label).Text;
            productName = (agvrow.FindControl("ProductName") as Label).Text;
            if ((agvrow.FindControl("Discontinued") as CheckBox).Checked)
            {
                discontinued = "discontinued";
            }
            else
            {
                discontinued = "available";
            }
            MessageLabel.Text = productName + " (" + productId + ") " + "is " + discontinued;
        }
    }
}