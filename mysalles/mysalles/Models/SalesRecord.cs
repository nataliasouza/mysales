using mysalles.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace mysalles.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayName("Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DisplayName("Valor")]
        public double Amount { get; set; }

        [DisplayName("Estado")]
        public SalesStatus  Status { get; set; }

        [DisplayName("Vendedor(a)")]
        public Seller Seller { get; set; }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

        public SalesRecord() { }
    }
}
