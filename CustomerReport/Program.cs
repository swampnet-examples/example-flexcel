using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexCel.Core;
using FlexCel.Report;

namespace CustomerReport
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var Customers = new List<Customer>();
             
            Customers.Add(new Customer { Name = "Bill", Address = "555 demo line" });
            Customers.Add(new Customer { Name = "Joe", Address = "556 demo line" });

            using (FlexCelReport fr = new FlexCelReport(true))
            {
                fr.AddTable("Customer", Customers);
                fr.Run("templates\\report.template.xlsx", "result.xlsx");
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
