using Microsoft.EntityFrameworkCore.Migrations;

namespace mySales.Migrations
{
    public partial class populationDB : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            //Department
            mb.Sql("INSERT INTO Department(Name) Values('Computadores')");
            mb.Sql("INSERT INTO Department(Name) Values('Eletrônicos')");
            mb.Sql("INSERT INTO Department(Name) Values('Moda')");
            mb.Sql("INSERT INTO Department(Name) Values('Livros')");

            //Sellers
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Max Brown', 'bob@gmail.com', '1998-4-21', 5200.0, 1 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Mallu Green', 'maria@gmail.com','1979-12-31', 5400.0, 2 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Teddy Grey', 'alex@gmail.com', '1988-1-15', 4850.0, 1 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Jô Red', 'martha@gmail.com', '1993-11-30', 6000.0, 4 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Natt Blair', 'natt@gmail.com', '1993-10-30', 4500.0, 4 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Mike Blue', 'donald@gmail.com', '2000-1-9', 4720.0, 3 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Lupy Blue', 'lupy@gmail.com', '2004-11-17', 4390.0, 3 )");
            mb.Sql("INSERT INTO Seller(Name, Email, BirthDate, BaseSalary, DepartmentId) Values('Alex Pink', 'pink@gmail.com', '1999-7-4', 4000.0, 2 )");

            //SalesRecord
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-24', '7290.0', 1, 7 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-22', '10980.0', 2, 8 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-16', '1920.0', 1, 8 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-25', '11000.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-4', '7000.0', 1, 5 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-13', '4000.0', 2, 4 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-1', '8000.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-21', '3000.0', 0, 3 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-15', '2000.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-09-28', '13000.0', 0, 2 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-08-11', '4000.0', 1, 4 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-08-14', '8300.0', 2, 6 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-08-19', '2950.0', 2, 8 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2013-08-1', '3600.0', 0, 6 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-08-17', '2800.0', 2, 4 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-08-28', '9000.0', 1, 5 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-08-16', '4320.0', 1, 3 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-08-23', '5000.0', 0, 6 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-07-30', '8200.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-07-20', '3900.0', 0, 4 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-07-6', '8220.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-07-3', '3200.0', 1, 8 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-07-2', '1300.0', 1, 7 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-07-12', '5000.0', 2, 5 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-07-24', '3250.0', 1, 3 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-07-22', '1900.0', 2, 2 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-06-16', '4320.0', 1, 2 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-06-2', '1300.0', 1, 6 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-06-9', '7200.0', 1, 1 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-06-29', '6950.0', 2, 2 )");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-06-6', '12220.0', 1, 8)");
            mb.Sql("INSERT INTO SalesRecord(Date, Amount, Status, SellerId) Values('2023-06-12', '5900.0', 2, 7 )");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Department, Seller, SalesRecord");
        }
    }
}
