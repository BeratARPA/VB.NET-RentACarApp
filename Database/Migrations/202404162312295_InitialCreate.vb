Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Cars",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Brand = c.String(),
                        .Model = c.String(),
                        .Version = c.String(),
                        .Year = c.Int(nullable := False),
                        .Active = c.Boolean(nullable := False),
                        .Type = c.String(),
                        .Plate = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Customers",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String(),
                        .PhoneNumber = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Invoices",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .CarId = c.Int(nullable := False),
                        .CustomerId = c.Int(nullable := False),
                        .Amount = c.Double(nullable := False),
                        .Status = c.String(),
                        .CreateDate = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Name = c.String(),
                        .Password = c.String()
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Users")
            DropTable("dbo.Invoices")
            DropTable("dbo.Customers")
            DropTable("dbo.Cars")
        End Sub
    End Class
End Namespace
