using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        private AuthenticationService _authService;
        private AuthorizationService _authzService;
        public LoginForm()
        {
            InitializeComponent();

            // Ініціалізуємо сервіси
            _authService = new AuthenticationService();
            _authzService = new AuthorizationService();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            try
            {
                // Автентифікація користувача
                User user = _authService.Authenticate(username, password);

                switch (user.Role)
                {
                    case UserRole.Warehouseman:
                        WarehousemanForm warehousemanForm = new WarehousemanForm();
                        warehousemanForm.Show();
                        this.Hide();
                        break;

                    case UserRole.Manager:
                        ManagerForm managerForm = new ManagerForm();
                        managerForm.Show();
                        this.Hide();
                        break;

                    case UserRole.Accountant:
                        AccountantForm accountantForm = new AccountantForm();
                        accountantForm.Show();
                        this.Hide();
                        break;

                    case UserRole.SalesAnalyst:
                        SalesAnalystForm salesAnalystForm = new SalesAnalystForm();
                        salesAnalystForm.Show();
                        this.Hide();
                        break;

                    case UserRole.InventoryController:
                        InventoryControllerForm inventoryControllerForm = new InventoryControllerForm();
                        inventoryControllerForm.Show();
                        this.Hide();
                        break;
                }
            }
            catch (AuthenticationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
