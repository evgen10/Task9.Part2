using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using EFModels.Model;
using System.Linq;


namespace Part2.Test
{
    [TestClass]
    public class Task2Test
    {
        [TestMethod]
        public void QueryDemonstration()
        {
            using (var db = new Northwind())
            {
                string categoryName = "Beverages";

                var query = from order in db.Orders
                            from orderDetails in order.Order_Details
                            where orderDetails.Product.Category.CategoryName == categoryName
                            select new
                            {
                                orderDetails.Product.Category.CategoryName,
                                order.Customer.ContactName,
                                orderDetails.Product.ProductName,
                                order.OrderDate
                            };
    

                #region Demonstration

                Console.WriteLine(query.Count());

                foreach (var item in query)
                {
                    Console.WriteLine($" Category Name:  {item.CategoryName} Customer:  {item.ContactName} Product:  {item.ProductName} Date {item.OrderDate}");

                }

                #endregion

               

            }


        }
    }
}
