using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPOCService.database;
using finalPOCService.functionality;
using finalPOCService.Functionality;
using Microsoft.EntityFrameworkCore;


namespace finalPOCService.service
{
 
    public class UserOperations : IFunctionality
    {
        DatabaseContext database;
        public UserOperations(DatabaseContext _database)
        {
            database = _database;
        }
        int IFunctionality.accountCreate(User user)
        {
            database.users.Add(user);
            return database.SaveChanges();
        }
 
        bool IFunctionality.accountLogin(User user)
        {
            var res = database.users.Find(user.userName);
            if (res == null)
            {
                return false;
            }
            else        
            {
                if (res.password == user.password)
                    return true;
               
                else
                    return false;
            }  
        }
    }
}