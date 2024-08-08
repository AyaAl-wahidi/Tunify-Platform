using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Tunify_Platform.Repositories.Services
{
    public class UserService : IUser
    {
        private readonly TunifyDbContext _context;

        public UserService(TunifyDbContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUser(User user)
        {
            try
            {
                _context.User.Add(user);
                await _context.SaveChangesAsync();
                return user;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                var allUSers = await _context.User.ToListAsync();
                return allUSers;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<User> GetUserById(int userId)
        {
            try
            {
                var user = await _context.User.FindAsync(userId);
                return user;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task<User> UpdateUser(int id, User user)
        {
            try
            {
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return user;
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public async Task DeleteUser(int id)
        {
            try
            {
                var user = await _context.User.FindAsync(id);
                if (user == null)
                {
                    throw new Exception("User not found");
                }

                _context.User.Remove(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                // Log the exception
                Console.WriteLine($"An error occurred while deleting the user: {e.Message}");
                throw;
            }
        }
    }
}