using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using EFModels.Model;
using System.Linq;
using System.Transactions;

namespace Part2.Test
{
    [TestClass]
    public class Task2Test
    {
        string connectionString = "Northwind";

        [TestMethod]
        public void QueryDemonstration()
        {
            using (var db = new Northwind(connectionString))
            {
                db.Database.CreateIfNotExists();

                string categoryName = "Beverages";      

                var query = db.Orders.SelectMany(ord => ord.Order_Details.Where(od => od.Product.Category.CategoryName == categoryName)
                                                                     .Select(o => new
                                                                          {
                                                                              o.Product.Category.CategoryName,
                                                                              ord.Customer.ContactName,
                                                                              o.Product.ProductName,
                                                                              ord.OrderDate
                                                                          }));
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
