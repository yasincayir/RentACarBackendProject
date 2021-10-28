using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RentACarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //CarMap
            modelBuilder.Entity<Car>().ToTable("Cars", "dbo");

            modelBuilder.Entity<Car>().Property(p => p.BrandId).HasColumnName("BrandId");
            modelBuilder.Entity<Car>().Property(p => p.ColorId).HasColumnName("ColorId");
            modelBuilder.Entity<Car>().Property(p => p.DailyPrice).HasColumnName("DailyPrice");
            modelBuilder.Entity<Car>().Property(p => p.Description).HasColumnName("Description");
            modelBuilder.Entity<Car>().Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<Car>().Property(p => p.ModelYear).HasColumnName("ModelYear");

            //BrandMap
            modelBuilder.Entity<Brand>().ToTable("Brands", "dbo");

            modelBuilder.Entity<Brand>().Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<Brand>().Property(p => p.Name).HasColumnName("Name");

            //ColorMap
            modelBuilder.Entity<Color>().ToTable("Colors", "dbo");

            modelBuilder.Entity<Color>().Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<Color>().Property(p => p.Name).HasColumnName("Name");

            //UserMap
            modelBuilder.Entity<User>().ToTable("Users","dbo");

            modelBuilder.Entity<User>().Property(p => p.id).HasColumnName("Id");
            modelBuilder.Entity<User>().Property(p => p.FirstName).HasColumnName("FirstName");
            modelBuilder.Entity<User>().Property(p => p.LastName).HasColumnName("LastName");
            modelBuilder.Entity<User>().Property(p => p.Email).HasColumnName("Email");
            modelBuilder.Entity<User>().Property(p => p.Password).HasColumnName("Password");

            //CustomerMap
            modelBuilder.Entity<Customer>().ToTable("Customers", "dbo");

            modelBuilder.Entity<Customer>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<Customer>().Property(c => c.UserId).HasColumnName("UserId");
            modelBuilder.Entity<Customer>().Property(c => c.CompanyName).HasColumnName("CompanyName");


            //RentalMap
            modelBuilder.Entity<Rental>().ToTable("Rentals");

            modelBuilder.Entity<Rental>().Property(r => r.Id).HasColumnName("Id");
            modelBuilder.Entity<Rental>().Property(r => r.CarId).HasColumnName("CarId");
            modelBuilder.Entity<Rental>().Property(r => r.CustomerId).HasColumnName("CustomerId");
            modelBuilder.Entity<Rental>().Property(r => r.RentDate).HasColumnName("RentDate");
            modelBuilder.Entity<Rental>().Property(r => r.ReturnDate).HasColumnName("ReturnDate");

            //CarImageMap
            modelBuilder.Entity<CarImage>().ToTable("CarImages");

            modelBuilder.Entity<CarImage>().Property(c => c.Id).HasColumnName("Id");
            modelBuilder.Entity<CarImage>().Property(c => c.CarId).HasColumnName("CarId");
            modelBuilder.Entity<CarImage>().Property(c => c.Date).HasColumnName("Date");
            modelBuilder.Entity<CarImage>().Property(c => c.ImagePath).HasColumnName("ImagePath");


            
        }
        

    }
}
