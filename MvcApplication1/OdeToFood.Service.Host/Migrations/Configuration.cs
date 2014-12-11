namespace OdeToFood.Data.SqlRepository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Data.SqlRepository.OdeToFoodDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OdeToFood.Data.SqlRepository.OdeToFoodDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            for (int i = 0; i < 100; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name, new Entity.Restaurant 
                    { 
                        Name = "Resto " + (i+1).ToString(),
                        City = "Jakarta",
                        Country = "Indonesia"
                    });
            }
        }
    }
}
