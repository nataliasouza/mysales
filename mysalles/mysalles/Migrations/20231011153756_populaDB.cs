using Microsoft.EntityFrameworkCore.Migrations;

namespace mysalles.Migrations
{
    public partial class populaDB : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            //Department
            mb.Sql("INSERT INTO Department(Name) Values('Computers')");
            mb.Sql("INSERT INTO Department(Name) Values('Electronics')");
            mb.Sql("INSERT INTO Department(Name) Values('Fashion')");
            mb.Sql("INSERT INTO Department(Name) Values('Books')");

            //Sellers
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Bob Brown', 'bob@gmail.com', '1998-4-21', 1000.0, 1 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Maria Green', 'maria@gmail.com','1979-12-31', 3500.0, 2 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Alex Grey', 'alex@gmail.com', '1988-1-15', 2200.0, 1 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Martha Red', 'martha@gmail.com', '1993-11-30', 3000.0, 4 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Donald Blue', 'donald@gmail.com', '2000-1-9', 4000.0, 3 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Alex Pink', 'pink@gmail.com', '1997-3-4', 3000.0, 2 )");

            //SalesRecord
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-25', '11000.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-4', '7000.0', 1, 5 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-13', '4000.0', 2, 4 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-1', '8000.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-21', '3000.0', 1, 3 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-15', '2000.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-28', '13000.0', 1, 2 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-11', '4000.0', 1, 4 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2018-09-14', '11000.0', 1, 6 )");      

        }
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Department, Seller, SalesRecord");
        }
    }
}
