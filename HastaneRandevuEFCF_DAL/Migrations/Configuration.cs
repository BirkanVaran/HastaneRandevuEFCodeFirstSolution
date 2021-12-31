namespace HastaneRandevuEFCF_DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HastaneRandevuEFCF_DAL.MyContext>
    {
        public Configuration()
        {

            //Eğer AutomaticMigrationsEnabled özelliği false kalsın isterseniz
            //add-migration ile migration eklemesi yapıp sonra update-database işlemi yapmanız gerekiyor.
            //Eğer bu özelliği true olarak değiştirirseniz add-migration'a gerek kalmıyor, update-database yeterlidir.
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HastaneRandevuEFCF_DAL.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
