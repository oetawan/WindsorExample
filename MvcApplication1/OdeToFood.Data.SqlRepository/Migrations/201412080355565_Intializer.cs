namespace OdeToFood.Data.SqlRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intializer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 1024),
                        City = c.String(nullable: false, maxLength: 1024),
                        Country = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.RestaurantId);
            
            CreateTable(
                "dbo.RestaurantReviews",
                c => new
                    {
                        RestaurantReviewId = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Body = c.String(nullable: false, maxLength: 1024),
                        ReviewerName = c.String(nullable: false, maxLength: 1024),
                        RestaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantReviewId)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.RestaurantId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.RestaurantReviews", new[] { "RestaurantId" });
            DropForeignKey("dbo.RestaurantReviews", "RestaurantId", "dbo.Restaurants");
            DropTable("dbo.RestaurantReviews");
            DropTable("dbo.Restaurants");
        }
    }
}
