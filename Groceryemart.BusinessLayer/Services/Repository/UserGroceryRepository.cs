using GroceryEmart.DataLayer;
using GroceryEmart.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryEmart.BusinessLayer.Services.Repository
{
    public class UserGroceryRepository : IUserGroceryRepository
    {
        /// <summary>
        /// Creating referance Variable of DbContext
        /// </summary>
        private readonly GroceryemartDbContext _groceryemartDbContext;
        
        /// <summary>
        /// Injecting Referance variable in UserGroceryRepository class Constructor
        /// </summary>
        public UserGroceryRepository(GroceryemartDbContext groceryemartDbContext)
        {
            _groceryemartDbContext = groceryemartDbContext;
        }
        /// <summary>
        /// Get User by Id from ApplicationUser table
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> GetUserById(int UserId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Verify User using this method if its is registred or not
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> Login(string Email, string password)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Logout function
        /// </summary>
        /// <returns></returns>
        public Task<bool> Logout()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register new user in ApplicationUser table
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> Register(ApplicationUser user)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update Registred user in ApplicationUser table
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> UpdateUser(int UserId, ApplicationUser user)
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
