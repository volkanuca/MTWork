using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using MTWork.DataAccess;
using MTWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTWork.Business.UserOperations
{

    public class UserManager
    {

        public QueryResult UpdateUser(string username,User updatedUser)
        {
            QueryResult rResult = new QueryResult();
            
            try
            {
                MTWorkDbContext db = new MTWorkDbContext();
                User oldUser = db.Users.Where(x => x.Email == username).FirstOrDefault();
                oldUser.UpdatedDate = DateTime.Now;
                oldUser.Name = updatedUser.Name;
                oldUser.Lastname = updatedUser.Lastname;
                oldUser.Password = updatedUser.Password;
                db.SaveChanges();
                rResult.Result = true;
                
            }
            catch(Exception ex)
            {
                rResult.Result = false;
                rResult.Message = ex.Message.ToString();
            }
            return rResult;
        }

        public bool AddUser(User thisUser)
        {
            bool result = false;
            try
            {
                MTWorkDbContext db = new MTWorkDbContext();
                db.Users.Add(thisUser);
                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }

        public LoginResult GetLogin(string username, string password)
        {
            LoginResult rResult = new LoginResult();

            User rUser = new User();
            try
            {
                MTWorkDbContext db = new MTWorkDbContext();
                rUser = db.Users.Where(x => x.Password == password && x.Email == username).FirstOrDefault();
                rResult.User = rUser;
                rResult.Result = true;
            }
            catch (Exception ex)
            {
                rResult.Result = false;
                rResult.Message = ex.Message.ToString();

            }
            return rResult;
        }

        public QueryResult DeleteUser(string username)
        {
            QueryResult rResult = new QueryResult();
            try
            {
                MTWorkDbContext db = new MTWorkDbContext();
                db.Users.Remove(db.Users.Where(x => x.Email == username).FirstOrDefault());
                db.SaveChanges();
                rResult.Result = true;
            }
            catch(Exception ex)
            {
                rResult.Result = false;
                rResult.Message = ex.Message.ToString();
            }
           return rResult;
        }

        public List<User> GetUsers()
        {
            List<User> rList = new List<User>();
            try
            {
                MTWorkDbContext db = new MTWorkDbContext();
                rList = db.Users.ToList().ToList();
            }
            catch (Exception ex)
            {
                
            }
            return rList;
        }

    }
}

