using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var categories = new List<Categorie>
            {
                new Categorie {CategoryName ="Confections" ,Description="Desserts, candies, and sweet breads"},
                new Categorie {CategoryName="Produce" ,Description="Dried fruit and bean curd"},
                new Categorie {CategoryName="Beverages" ,Description="Soft drinks, coffees, teas, beers, and ales"}
            };
            categories.ForEach(c => context.categorie.Add(c));
            context.SaveChanges();

            var suppliers = new List<Supplier>
            {
                new Supplier {CompanyName="Exotic Liquids", ContactName="Charlotte Cooper",ContactTitle="Purchasing Manager",Address="49 Gilbert St.",City="London",PostalCode="EC1 4SD",Phone="EC1 4SD"},
                new Supplier {CompanyName="New Orleans Cajun Delights", ContactName="Shelley Burke",ContactTitle="Order Administrator",Address="P.O. Box 78934",City="New Orleans",PostalCode="70117",Phone="(100) 555-4822"}
            };
            suppliers.ForEach(c => context.supplier.Add(c));
            context.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer {CompanyName="Alfreds Futterkiste", ContactName="Maria Anders",ContactTitle="Sales Representative",Address="Obere Str. 57",City="Berlin",PostalCode="12209",Phone="030-0074321"},
                new Customer {CompanyName="Ana Trujillo Emparedados y helados", ContactName="Ana Trujillo",ContactTitle="Owner",Address="Avda. de la Constitución 2222",City="México D.F.",PostalCode="05021",Phone="(5) 555-4729"}
            };
            customers.ForEach(c => context.customer.Add(c));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee {LastName="Davolio", FirstName="Nancy",Title="Sales Representative",TitleOfCourtesy="Ms.",BirthDate=DateTime.Parse("1980-09-22"),Address="507 - 20th Ave. E.Apt. 2A",City="Seattle",Region="WA",PostalCode="96587"},
                new Employee {LastName="Fuller", FirstName="Andrew",Title="Vice President, Sales",TitleOfCourtesy="Dr.",BirthDate=DateTime.Parse("1980-09-22"),Address="908 W. Capital Way",City="Tacoma",Region="WA",PostalCode="98401"}
            };
            employees.ForEach(c => context.employee.Add(c));
            context.SaveChanges();
        }
    }
}

