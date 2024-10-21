using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AccountantForm : Form
    {
        private Label totalIncomeLabel;
        private Label totalExpensesLabel;
        private TextBox totalIncomeTextBox;
        private TextBox totalExpensesTextBox;
        private Button createBudgetButton;
        private Label budgetReportLabel;

        public AccountantForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.totalExpensesLabel = new System.Windows.Forms.Label();
            this.totalIncomeTextBox = new System.Windows.Forms.TextBox();
            this.totalExpensesTextBox = new System.Windows.Forms.TextBox();
            this.createBudgetButton = new System.Windows.Forms.Button();
            this.budgetReportLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.Location = new System.Drawing.Point(30, 30);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(200, 22);
            this.totalIncomeLabel.TabIndex = 0;
            this.totalIncomeLabel.Text = "Загальний дохід:";
            // 
            // totalExpensesLabel
            // 
            this.totalExpensesLabel.Location = new System.Drawing.Point(30, 90);
            this.totalExpensesLabel.Name = "totalExpensesLabel";
            this.totalExpensesLabel.Size = new System.Drawing.Size(200, 22);
            this.totalExpensesLabel.TabIndex = 2;
            this.totalExpensesLabel.Text = "Загальні витрати:";
            // 
            // totalIncomeTextBox
            // 
            this.totalIncomeTextBox.Location = new System.Drawing.Point(30, 55);
            this.totalIncomeTextBox.Name = "totalIncomeTextBox";
            this.totalIncomeTextBox.Size = new System.Drawing.Size(200, 22);
            this.totalIncomeTextBox.TabIndex = 1;
            // 
            // totalExpensesTextBox
            // 
            this.totalExpensesTextBox.Location = new System.Drawing.Point(30, 115);
            this.totalExpensesTextBox.Name = "totalExpensesTextBox";
            this.totalExpensesTextBox.Size = new System.Drawing.Size(200, 22);
            this.totalExpensesTextBox.TabIndex = 3;
            // 
            // createBudgetButton
            // 
            this.createBudgetButton.Location = new System.Drawing.Point(30, 150);
            this.createBudgetButton.Name = "createBudgetButton";
            this.createBudgetButton.Size = new System.Drawing.Size(200, 30);
            this.createBudgetButton.TabIndex = 4;
            this.createBudgetButton.Text = "Створити бюджет";
            this.createBudgetButton.UseVisualStyleBackColor = true;
            this.createBudgetButton.Click += new System.EventHandler(this.createBudgetButton_Click);
            // 
            // budgetReportLabel
            // 
            this.budgetReportLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.budgetReportLabel.Location = new System.Drawing.Point(30, 200);
            this.budgetReportLabel.Name = "budgetReportLabel";
            this.budgetReportLabel.Size = new System.Drawing.Size(200, 100);
            this.budgetReportLabel.TabIndex = 5;
            this.budgetReportLabel.Text = "Звіт про бюджет з\'явиться тут";
            this.budgetReportLabel.Visible = false;
            // 
            // AccountantForm
            // 
            this.ClientSize = new System.Drawing.Size(293, 353);
            this.Controls.Add(this.totalIncomeLabel);
            this.Controls.Add(this.totalIncomeTextBox);
            this.Controls.Add(this.totalExpensesLabel);
            this.Controls.Add(this.totalExpensesTextBox);
            this.Controls.Add(this.createBudgetButton);
            this.Controls.Add(this.budgetReportLabel);
            this.Name = "AccountantForm";
            this.Text = "Бухгалтер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void createBudgetButton_Click(object sender, EventArgs e)
        {
            decimal totalIncome;
            decimal totalExpenses;

            // Перевірка введених значень
            if (decimal.TryParse(totalIncomeTextBox.Text, out totalIncome) &&
                decimal.TryParse(totalExpensesTextBox.Text, out totalExpenses))
            {
                Accountant accountant = new Accountant();
                // Виклик методу CreateBudget
                accountant.CreateBudget(totalIncome, totalExpenses);

                // Виведення звіту у Label
                budgetReportLabel.Text = $"Загальний дохід: {totalIncome:C}\n" +
                                          $"Загальні витрати: {totalExpenses:C}\n" +
                                          $"Бюджет: {totalIncome - totalExpenses:C}";
                budgetReportLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть дійсні числові значення.", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
