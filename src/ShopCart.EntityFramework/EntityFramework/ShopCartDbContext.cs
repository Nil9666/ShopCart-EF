using System.Data.Common;
using System.Data.Entity;
using Abp.DynamicEntityParameters;
using Abp.Zero.EntityFramework;
using ShopCart.Authorization.Roles;
using ShopCart.Authorization.Users;
using ShopCart.AvailableLocations;
using ShopCart.Countries;
using ShopCart.Customers;
using ShopCart.Feedback_usr;
using ShopCart.Inventrys;
using ShopCart.Invoices;
using ShopCart.LoginUsr;
using ShopCart.Manufaturers;
using ShopCart.MultiTenancy;
using ShopCart.Order_Details;
using ShopCart.Order_usr;
using ShopCart.Product_Details;
using ShopCart.Products;
using ShopCart.Profile_Pic;
using ShopCart.RegstrationUsr;
using ShopCart.States;
using ShopCart.Trackings;

namespace ShopCart.EntityFramework
{
    public class ShopCartDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ShopCartDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ShopCartDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ShopCartDbContext since ABP automatically handles it.
         */
        public ShopCartDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ShopCartDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ShopCartDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Login> LoginUsr { get; set; }
        public virtual DbSet<Registration> RegistrationUsr { get; set; }
        public virtual DbSet<ProductDetails> product_Details { get; set; }
        public virtual DbSet<Order> Order_usr { get; set; }
        public virtual DbSet<Feedback> Feedback_usr { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Tracking> Trackings { get; set; }
        public virtual DbSet<OrderDetails> Order_Details { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<AvailableLocation> AvailableLocations { get; set; }
        public virtual DbSet<Inventry> Inventrys { get; set; }
        public virtual DbSet<ProfilePic> Profile_Pic { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicParameter>().Property(p => p.ParameterName).HasMaxLength(250);
            modelBuilder.Entity<EntityDynamicParameter>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}
