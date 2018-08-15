using suppliers_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace suppliers_backend.DAL
{
    public static class UserDal
    {
        public static void SignIn(UserModel i_UserModel)
        {
            using (DBManager db = new DBManager())
            {
                UserModel user = db.Users.FirstOrDefault(i => i.Email == i_UserModel.Email);

                if (user != null)
                {
                    throw new InvalidOperationException("User already exists.");
                }

                db.Users.Add(i_UserModel);
                db.SaveChanges();
            }
        }

        public static void LogIn(UserModel i_UserModel)
        {
            using (DBManager db = new DBManager())
            {
                UserModel user = db.Users.FirstOrDefault(i => i.Email == i_UserModel.Email);

                if (user == null)
                {
                    throw new InvalidOperationException("User not exists.");
                }
                else
                {
                    if (user.Password != i_UserModel.Password)
                    {
                        throw new InvalidOperationException("Password not match.");
                    }
                }
            }
        }
    }
}