namespace suppliers_backend.DAL
{
    using suppliers_backend.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBManager : DbContext
    {
        public DBManager() : base("name=MyContext") { }

        public virtual DbSet<UserModel> Users { get; set; }

        public virtual DbSet<SupplierModel> Suppliers { get; set; }
    }
}