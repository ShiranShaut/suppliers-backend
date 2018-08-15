using suppliers_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace suppliers_backend.DAL
{
    public static class SupplierDal
    {
        public static void Register(SupplierModel i_SupplierModel)
        {
            using (DBManager db = new DBManager())
            {
                SupplierModel supplier = db.Suppliers.FirstOrDefault(i => i.Email == i_SupplierModel.Email);

                if (supplier != null)
                {
                    throw new InvalidOperationException("Supplier already exists.");
                }

                db.Suppliers.Add(i_SupplierModel);
                db.SaveChanges();
            }
        }

        public static SupplierModel GetSupplierById(int id)
        {
            using (DBManager db = new DBManager())
            {
                SupplierModel supplier = db.Suppliers.FirstOrDefault(i => i.ID == id);

                if (supplier == null)
                {
                    throw new InvalidOperationException("Supplier not exists.");
                }

                return supplier;
            }
        }

        public static List<SupplierModel> GetSuppliers()
        {
            using (DBManager db = new DBManager())
            {
                return db.Suppliers.ToList();
            }
        }
    }
}