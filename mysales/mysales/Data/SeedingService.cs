
using mySales.Models;
using mySales.Models.Enums;
using System;
using System.Linq;

namespace mySales.Data
{
    public class SeedingService
    {
        private MySalesContext _context;

        public SeedingService(MySalesContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // Valida se o BD já foi populado
            }

            Department departmentComputers = new Department(1, "Computers");
            Department departmentElectronics = new Department(2, "Electronics");
            Department departmentFashion = new Department(3, "Fashion");
            Department departmentBooks = new Department(4, "Books");

            Seller sellerBobBrowm = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, departmentComputers);
            Seller sellerMariaGreen = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, departmentElectronics);
            Seller sellerAlexGrey = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, departmentComputers);
            Seller sellerMartaRed = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, departmentBooks);
            Seller sellerDonaldBlue = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, departmentFashion);
            Seller sellerAlexPink = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, departmentElectronics);

            SalesRecord salesRecord01 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Faturado, sellerBobBrowm);
            SalesRecord salesRecord02 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SalesStatus.Faturado, sellerDonaldBlue);
            SalesRecord salesRecord03 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SalesStatus.Cancelado, sellerMartaRed);
            SalesRecord salesRecord04 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SalesStatus.Faturado, sellerBobBrowm);
            SalesRecord salesRecord05 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SalesStatus.Faturado, sellerAlexGrey);
            SalesRecord salesRecord06 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SalesStatus.Faturado, sellerBobBrowm);
            SalesRecord salesRecord07 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SalesStatus.Faturado, sellerMariaGreen);
            SalesRecord salesRecord08 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SalesStatus.Faturado, sellerMartaRed);
            SalesRecord salesRecord09 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SalesStatus.Pendente, sellerAlexPink);
            SalesRecord salesRecord10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SalesStatus.Faturado, sellerAlexPink);
            SalesRecord salesRecord11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SalesStatus.Faturado, sellerMariaGreen);
            SalesRecord salesRecord12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SalesStatus.Pendente, sellerAlexGrey);
            SalesRecord salesRecord13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SalesStatus.Faturado, sellerMartaRed);
            SalesRecord salesRecord14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SalesStatus.Faturado, sellerDonaldBlue);
            SalesRecord salesRecord15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SalesStatus.Faturado, sellerBobBrowm);
            SalesRecord salesRecord16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SalesStatus.Faturado, sellerMartaRed);
            SalesRecord salesRecord17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SalesStatus.Faturado, sellerBobBrowm);
            SalesRecord salesRecord18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SalesStatus.Faturado, sellerAlexGrey);
            SalesRecord salesRecord19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SalesStatus.Faturado, sellerDonaldBlue);
            SalesRecord salesRecord20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SalesStatus.Faturado, sellerAlexPink);
            SalesRecord salesRecord21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SalesStatus.Faturado, sellerMariaGreen);
            SalesRecord salesRecord22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SalesStatus.Faturado, sellerMartaRed);
            SalesRecord salesRecord23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SalesStatus.Cancelado, sellerMariaGreen);
            SalesRecord salesRecord24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SalesStatus.Faturado, sellerDonaldBlue);
            SalesRecord salesRecord25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SalesStatus.Faturado, sellerAlexGrey);
            SalesRecord salesRecord26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SalesStatus.Faturado, sellerMartaRed);
            SalesRecord salesRecord27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SalesStatus.Pendente, sellerBobBrowm);
            SalesRecord salesRecord28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SalesStatus.Faturado, sellerAlexGrey);
            SalesRecord salesRecord29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SalesStatus.Faturado, sellerDonaldBlue);
            SalesRecord salesRecord30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SalesStatus.Faturado, sellerMariaGreen);

            _context.Department.AddRange(departmentComputers, departmentElectronics, departmentFashion, departmentBooks);

            _context.Seller.AddRange(sellerBobBrowm, sellerMariaGreen, sellerAlexGrey, sellerMartaRed, sellerDonaldBlue, sellerAlexPink);

            _context.SalesRecord.AddRange(
                salesRecord01, salesRecord02, salesRecord03, salesRecord04, salesRecord05, salesRecord06, salesRecord07, salesRecord08, salesRecord09, salesRecord10,
                salesRecord11, salesRecord12, salesRecord13, salesRecord14, salesRecord15, salesRecord16, salesRecord17, salesRecord18, salesRecord19, salesRecord20,
                salesRecord21, salesRecord22, salesRecord23, salesRecord24, salesRecord25, salesRecord26, salesRecord27, salesRecord28, salesRecord29, salesRecord30
            );        

            _context.SaveChanges();
        }
    }
}
