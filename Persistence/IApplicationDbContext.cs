using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Persistence
{
    public interface IApplicationDbContext
    {
       // DbSet<Category> Categories { get; set; }
        //DbSet<Customer> Customers { get; set; }
        DbSet<Hotel> Hotel { get; set; }
        DbSet<FacilitesHotel> FacilitesHotel { get; set; }
        //DbSet<Order> Orders { get; set; }
        //DbSet<Product> Products { get; set; }
       // DbSet<Supplier> Suppliers { get; set; }

        Task<int> SaveChangesAsync();
    }
}
