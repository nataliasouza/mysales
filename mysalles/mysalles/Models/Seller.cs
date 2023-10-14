using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace mysalles.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o seu nome")]
        [StringLength(80, ErrorMessage = "O nome deve conter entre 3 e 80 caracteres", MinimumLength = 3)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o seu email")]
        [EmailAddress(ErrorMessage = "Informe um email válido.")]
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Data de Nascimento")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        [DisplayName("Salário Base")]
        public double BaseSalary { get; set; }

        [DisplayName("Departamento")]
        public Department Department { get; set; }
        [DisplayName("Id do Departamento")]
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public Seller() { }

        public void AddSales(SalesRecord sales)
        {
            Sales.Add(sales);
        }

        public void RemoveSales(SalesRecord sales) 
        {  
            Sales.Remove(sales); 
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sales => sales.Date >= initial && sales.Date <= final).Sum(sales => sales.Amount);
        }
    }
}
