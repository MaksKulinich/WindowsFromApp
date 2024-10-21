using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Абстрактний клас користувача
    public abstract class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Зберігаємо хеш пароля
        public string Salt { get; set; } // Зберігаємо сіль для хешування
        public UserRole Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Конкретні класи користувачів
    public class Warehouseman : User
    {
        public string WarehouseSection { get; set; }


        public void ReceiveGoods()
        {
            // Логіка прийому товарів на склад
            Console.WriteLine($"{FirstName} приймає товар на секцію {WarehouseSection}.");
        }

        public void CheckGoodsQuality()
        {
            // Логіка перевірки якості товарів
            Console.WriteLine($"{FirstName} перевіряє якість товарів.");
        }
    }
    public class Manager : User
    {
        public string Department { get; set; }

    }

    public class Accountant : User
    {
        public void CreateBudget(decimal totalIncome, decimal totalExpenses)
        {
            // Розрахунок бюджету
            decimal budget = totalIncome - totalExpenses;

            // Формування повідомлення про бюджет
            string budgetReport = $"Загальний дохід: {totalIncome:C}\n" +
                                  $"Загальні витрати: {totalExpenses:C}\n" +
                                  $"Бюджет: {budget:C}";

            // Виведення звіту про бюджет
            Console.WriteLine(budgetReport);
        }

    }

    public class SalesAnalyst : User
    {
        // Метод для збереження звіту у файл
        public void SaveReportToFile(string reportContent, DateTime reportDate)
        {
            // Формування назви файлу на основі дати
            string fileName = $"SalesReport_{reportDate.ToString("yyyyMMdd")}.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

            try
            {
                // Запис звіту у файл
                File.WriteAllText(filePath, reportContent);
                Console.WriteLine($"Звіт успішно збережено у файл: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні звіту: {ex.Message}");
            }
        }

    }

    public class InventoryController: User
    {
        // Список для зберігання товарів
        private List<Product> products;

        // Конструктор, який ініціалізує список продуктів
        public InventoryController()
        {
            products = Product.GenerateList(); // Завантаження початкового списку продуктів
        }

        // Додавання нового товару до списку
        public void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
        }

        // Отримання інформації про товар за ID
        public Product GetProductById(int productId)
        {
            return products.Find(p => p.GetId() == productId);
        }
    }

    // Перелік ролей
    public enum UserRole
    {
        Warehouseman,
        Manager,
        Accountant,
        SalesAnalyst,
        InventoryController,
    }

}