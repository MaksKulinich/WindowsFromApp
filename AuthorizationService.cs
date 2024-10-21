using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // Сервіс авторизації
    public class AuthorizationService
    {
        // Правила авторизації для ролей
        private static Dictionary<UserRole, List<string>> permissions = new Dictionary<UserRole, List<string>>()
        {
            { UserRole.Warehouseman, new List<string>() { "Прийом Товарів", "Відпуск Товарів", "Перевірка Кількості", "Перевірка Якості" } },
            { UserRole.Manager, new List<string>() { "Планування Закупівель", "Контроль Запасів", "Аналіз Продажів" } },
            { UserRole.Accountant, new List<string>() { "Створення Фінансових Звітів", "Управління Платежами" } },
            { UserRole.SalesAnalyst, new List<string>() { "Аналіз Продажів", "Створення Звітів по Продажам" } },
            { UserRole.InventoryController, new List<string>() { "Моніторинг Запасів", "Поповнення Товарів", "Перевірка Наявності Товарів" } }
        };
    }
}
