


using ConsoleApp14.Data1;
using ConsoleApp14.Models;

MyContext context = new MyContext();
context.Countries.Add(new Country
{
    Code = "Az",
     Name="azerbaycan",
     Phone="+994",
     ISO="Az",
     Capital="Baku",
     Currency="AZN",
     Continent="Asia"
});

context.SaveChanges();