using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Product
    {
        private static List<Product> productsList = null;
        // Поля продукту
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public string WarehouseSection { get; private set; }
        public string Category { get; private set; }

        // Конструктор класу
        public Product(int id, string name, string description, decimal price, int quantity, string category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Category = category; // Ініціалізація поля категорії
        }

        // Методи для отримання значень полів продукту
        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public string GetCategory()
        {
            return Category; // Метод для отримання категорії
        }

        // Метод для оновлення кількості
        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
        }

        // Статичний метод для створення списку продуктів
        public static List<Product> GenerateList()
        {
            // Якщо список ще не ініціалізований, створюємо його
            if (productsList == null)
            {
                productsList = new List<Product>
            {
                new Product(1, "Ноутбук", "15.6-дюймовий екран, Intel Core i7", 1200.00m, 5, "Електроніка"),
                new Product(2, "Смартфон", "6.1-дюймовий екран, 128ГБ пам'яті", 800.00m, 10, "Електроніка"),
                new Product(3, "Крісло", "Ергономічне, регульована висота", 150.00m, 7, "Меблі"),
                new Product(4, "Кавоварка", "Автоматична, об'єм 12 чашок", 99.99m, 3, "Кухня"),
                new Product(5, "Кросівки", "Дихаючий матеріал, розмір 10", 75.00m, 20, "Одяг")
            };
            }

            return productsList;
        }


    }

}
