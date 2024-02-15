using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Microsoft.AspNetCore.Identity;

namespace Project.Models
{
    public class Panier
    {
        [Key] 
        public int Id { get; set; }
        public string UserID { get;set; }
    }
    public class PanierDBContext : DbContext
    {
        public DbSet<Panier> Panier { get; set; }
    }
}
