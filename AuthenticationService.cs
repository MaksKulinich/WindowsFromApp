using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AuthenticationService
    {
        private static List<User> users = new List<User>()
        {
            new Warehouseman { Id = 1, Username = "warehouse1", PasswordHash = HashPassword("password1", "salt1"), Salt = "salt1", Role = UserRole.Warehouseman, FirstName = "John", LastName = "Doe", WarehouseSection = "A" },
            new Manager { Id = 2, Username = "manager1", PasswordHash = HashPassword("password2", "salt2"), Salt = "salt2", Role = UserRole.Manager, FirstName = "Jane", LastName = "Smith", Department = "Procurement" },
            new Accountant { Id = 3, Username = "accountant1", PasswordHash = HashPassword("password3", "salt3"), Salt = "salt3", Role = UserRole.Accountant, FirstName = "Michael", LastName = "Johnson" },
            new SalesAnalyst { Id = 4, Username = "analyst1", PasswordHash = HashPassword("password4", "salt4"), Salt = "salt4", Role = UserRole.SalesAnalyst, FirstName = "Emma", LastName = "Brown" },
            new InventoryController { Id = 5, Username = "controller1", PasswordHash = HashPassword("password5", "salt5"), Salt = "salt5", Role = UserRole.InventoryController, FirstName = "David", LastName = "Williams" }

        };


        // Хешування пароля
        private static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(salt + password);
                byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public User Authenticate(string username, string password)
        {
            User user = users.FirstOrDefault(u => u.Username == username);
            if (user != null && user.PasswordHash == HashPassword(password, user.Salt))
            {
                return user; // Автентифікація успішна
            }
            else
            {
                throw new AuthenticationException("Неправильне ім'я користувача або пароль.");
            }
        }
    }
}
