using SPISAP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPISAP.Repositories
{
    public class UserRepository
    {

        private UserViewModel UserVM { get; set; }

        public UserRepository()
        { 
        
        
        }
        public UserRepository(UserViewModel UserModel)
        {

            UserVM = UserModel;

        }


        public bool IsValid()
        {

            using ( SPISAPEntities db = new SPISAPEntities())
            {
                var record = db.DUSUARIOS.Where(x => x.COD_USER.Equals(UserVM.username.ToLower()) && x.CLAVE.Equals(UserVM.password.ToLower())).FirstOrDefault();
                if (record != null)
                {
                    UserVM.username = record.COD_USER;
                    UserVM.password = record.CLAVE;
                    UserVM.userdesc = record.DES_USER;
                }
                return (record != null);
            }
        
        }

    }

}