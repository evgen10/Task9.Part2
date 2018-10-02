namespace EFModels.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFModels.Model.Northwind>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFModels.Model.Northwind context)
        {
            context.Categories.AddOrUpdate(new Model.Category { CategoryName = "Category1" },
                new Model.Category { CategoryName = "Category2" },
                new Model.Category { CategoryName = "Category3" });

            context.Regions.AddOrUpdate(new Model.Regions { RegionDescription = "Karaganda", RegionID = 12 },
                new Model.Regions { RegionDescription = "Astana", RegionID = 10 },
                new Model.Regions { RegionDescription = "Almata", RegionID = 11 });

            context.Territories.AddOrUpdate(new Model.Territory { TerritoryID = "555555" ,TerritoryDescription = "Region1", RegionID = 10 },
                new Model.Territory { TerritoryID="6666666", TerritoryDescription = "Region2", RegionID = 11 });


        }
    }
}
