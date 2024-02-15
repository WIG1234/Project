using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace Project.Models
{
    public class Cars
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string URLimage { get; set; }
        public float Price { get; set; }
        public DateTime DueDate { get; set; }
        public int MaxSpeed { get; set; }
    }
    public class CarsDBContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
    }
}
