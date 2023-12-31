﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace mySales.Models
{
    public class Department
    {
        public int Id { get; set; }
        [DisplayName("Nome")]
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; }  = new List<Seller>();        

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Department()
        {

        }

        public void AddSaller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public void RemoveSeller(Seller seller)
        {
            Sellers.Remove(seller);
        }

        public double TotalSalesOfDepartment(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
