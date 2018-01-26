using System;
using System.Collections.Generic;
using Rentalbase.Models;

namespace Rentalbase.DAL
{
    public class ManagementInitializer : 
        //System.Data.Entity.DropCreateDatabaseAlways<ManagementContext>
        System.Data.Entity.DropCreateDatabaseIfModelChanges<ManagementContext>
    {
        protected override void Seed(ManagementContext context)
        {
            var landlords = new List<Landlord>
            {
                new Landlord{ ID=1, Name="Lucas El", Address="6767 Boss Ave Tacoma, WA 98323", Phone="2537876543", Email="le@yahoo.com"},
                new Landlord{ ID=2, Name="Melissa El", Address="1892 Pleasant Circle Redmond, WA 98793", Phone="2069993333", Email="me@gmail.com"},
            };
            landlords.ForEach(s => context.Landlords.Add(s));
            context.SaveChanges();

            var properties = new List<Property>
            {
                new Property{ ID=1,Street="1235 West Park", City="Kent", State="WA", Zip=98031, Value=350000.00, LandlordID=1, Description="Built 1998"},
                new Property{ ID=2,Street="678 North Lane", City="Kent", State="WA", Zip=98058, Value=450000.00, LandlordID=1, Description="Built 2009"},
                new Property{ ID=3,Street="952 South Way", City="Auburn", State="WA", Zip=98001, Value=240000.00, LandlordID=2, Description="Built 2013"},
                new Property{ ID=4,Street="952 East Place", City="Seattle", State="WA", Zip=98512, Value=650000.00, LandlordID=2, Description="Built 1982"},
            };
            properties.ForEach(s => context.Properties.Add(s));
            context.SaveChanges();

            var leases = new List<Lease>
            {
                new Lease{ ID=1, PropertyID=1, StartDate=DateTime.Parse("2015-06-01"), DurationInMonths=6, MonthlyRate=2500.00},
                new Lease{ ID=2, PropertyID=2, StartDate=DateTime.Parse("2015-01-01"), DurationInMonths=12, MonthlyRate=1900.00},
                new Lease{ ID=3, PropertyID=3, StartDate=DateTime.Parse("2015-09-01"), DurationInMonths=12, MonthlyRate=1000.00},
                new Lease{ ID=4, PropertyID=3, StartDate=DateTime.Parse("2015-09-01"), DurationInMonths=12, MonthlyRate=1000.00},
            };
            leases.ForEach(s => context.Leases.Add(s));
            context.SaveChanges();

            var tenants = new List<Tenant>
            {
                new Tenant{ ID=1, LeaseID=1, Name="Joy Hacker", Phone="2061111111", Email="jh@yahoo.com"},
                new Tenant{ ID=2, LeaseID=1, Name="Ray Beans", Phone="2062222222", Email="rc@yahoo.com"},
                new Tenant{ ID=3, LeaseID=2, Name="Mike Tyson", Phone="4259999999", Email="mt@gmail.com"},
                new Tenant{ ID=4, LeaseID=3, Name="Simon Says", Phone="2535555555", Email="ss@earthlink.net"},
            };
            tenants.ForEach(s => context.Tenants.Add(s));
            context.SaveChanges();


            var invoices = new List<Invoice>
            {
                new Invoice{ ID=1, PropertyID=1, DateIssued=DateTime.Parse("2015-06-23"), DatePaid=DateTime.Parse("2015-07-01"), Description="Rent", Cost=2500.00},
                new Invoice{ ID=2, PropertyID=1, DateIssued=DateTime.Parse("2015-07-23"), DatePaid=DateTime.Parse("2015-08-01"), Description="Rent", Cost=2500.00},
                new Invoice{ ID=3, PropertyID=1, DateIssued=DateTime.Parse("2015-08-23"), DatePaid=DateTime.Parse("2015-09-01"), Description="Rent", Cost=2500.00},
                new Invoice{ ID=4, PropertyID=1, DateIssued=DateTime.Parse("2015-09-23"), DatePaid=DateTime.Parse("2015-10-01"), Description="Rent", Cost=2500.00},

                new Invoice{ ID=5, PropertyID=2, DateIssued=DateTime.Parse("2015-01-23"), DatePaid=DateTime.Parse("2015-02-02"), Description="Rent", Cost=1900.00},
                new Invoice{ ID=6, PropertyID=2, DateIssued=DateTime.Parse("2015-02-23"), DatePaid=DateTime.Parse("2015-03-02"), Description="Rent", Cost=1900.00},
                new Invoice{ ID=7, PropertyID=2, DateIssued=DateTime.Parse("2015-03-23"), DatePaid=DateTime.Parse("2015-04-02"), Description="Rent", Cost=1900.00},
                new Invoice{ ID=8, PropertyID=2, DateIssued=DateTime.Parse("2015-04-23"), DatePaid=DateTime.Parse("2015-05-02"), Description="Rent", Cost=1900.00},

                new Invoice{ ID=9, PropertyID=3, DateIssued=DateTime.Parse("2015-09-23"), DatePaid=DateTime.Parse("2015-10-02"), Description="Rent", Cost=1000.00},


            };
            invoices.ForEach(s => context.Invoices.Add(s));
            context.SaveChanges();
        }
    }
}