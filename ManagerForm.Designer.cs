using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{

    partial class ManagerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem checkStockLevelsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStockMenuItem;
        private System.Windows.Forms.Label stockInfoLabel;
        private System.Windows.Forms.TextBox stockIdTextBox;
        private System.Windows.Forms.TextBox stockQuantityTextBox;
        private System.Windows.Forms.Label stockIdLabel;
        private System.Windows.Forms.Label stockQuantityLabel;
        private System.Windows.Forms.Button updateStockButton;
        private System.Windows.Forms.Button checkStockButton;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.checkStockLevelsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInfoLabel = new System.Windows.Forms.Label();
            this.stockIdTextBox = new System.Windows.Forms.TextBox();
            this.stockQuantityTextBox = new System.Windows.Forms.TextBox();
            this.stockIdLabel = new System.Windows.Forms.Label();
            this.stockQuantityLabel = new System.Windows.Forms.Label();
            this.updateStockButton = new System.Windows.Forms.Button();
            this.checkStockButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkStockLevelsMenuItem,
            this.updateStockMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(376, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // checkStockLevelsMenuItem
            // 
            this.checkStockLevelsMenuItem.Name = "checkStockLevelsMenuItem";
            this.checkStockLevelsMenuItem.Size = new System.Drawing.Size(167, 24);
            this.checkStockLevelsMenuItem.Text = "Перевірити кількість";
            this.checkStockLevelsMenuItem.Click += new System.EventHandler(this.checkStockLevelsMenuItem_Click);
            // 
            // updateStockMenuItem
            // 
            this.updateStockMenuItem.Name = "updateStockMenuItem";
            this.updateStockMenuItem.Size = new System.Drawing.Size(147, 24);
            this.updateStockMenuItem.Text = "Оновити кількість";
            this.updateStockMenuItem.Click += new System.EventHandler(this.updateStockMenuItem_Click);
            // 
            // stockInfoLabel
            // 
            this.stockInfoLabel.AutoSize = true;
            this.stockInfoLabel.Location = new System.Drawing.Point(50, 180);
            this.stockInfoLabel.Name = "stockInfoLabel";
            this.stockInfoLabel.Size = new System.Drawing.Size(0, 16);
            this.stockInfoLabel.TabIndex = 1;
            // 
            // stockIdTextBox
            // 
            this.stockIdTextBox.Location = new System.Drawing.Point(150, 50);
            this.stockIdTextBox.Name = "stockIdTextBox";
            this.stockIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.stockIdTextBox.TabIndex = 3;
            this.stockIdTextBox.Visible = false;
            // 
            // stockQuantityTextBox
            // 
            this.stockQuantityTextBox.Location = new System.Drawing.Point(150, 100);
            this.stockQuantityTextBox.Name = "stockQuantityTextBox";
            this.stockQuantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.stockQuantityTextBox.TabIndex = 5;
            this.stockQuantityTextBox.Visible = false;
            // 
            // stockIdLabel
            // 
            this.stockIdLabel.AutoSize = true;
            this.stockIdLabel.Location = new System.Drawing.Point(50, 50);
            this.stockIdLabel.Name = "stockIdLabel";
            this.stockIdLabel.Size = new System.Drawing.Size(70, 16);
            this.stockIdLabel.TabIndex = 2;
            this.stockIdLabel.Text = "ID товару";
            this.stockIdLabel.Visible = false;
            // 
            // stockQuantityLabel
            // 
            this.stockQuantityLabel.AutoSize = true;
            this.stockQuantityLabel.Location = new System.Drawing.Point(50, 100);
            this.stockQuantityLabel.Name = "stockQuantityLabel";
            this.stockQuantityLabel.Size = new System.Drawing.Size(64, 16);
            this.stockQuantityLabel.TabIndex = 4;
            this.stockQuantityLabel.Text = "Кількість";
            this.stockQuantityLabel.Visible = false;
            // 
            // updateStockButton
            // 
            this.updateStockButton.Location = new System.Drawing.Point(50, 150);
            this.updateStockButton.Name = "updateStockButton";
            this.updateStockButton.Size = new System.Drawing.Size(154, 23);
            this.updateStockButton.TabIndex = 6;
            this.updateStockButton.Text = "Оновити кількість";
            this.updateStockButton.UseVisualStyleBackColor = true;
            this.updateStockButton.Visible = false;
            this.updateStockButton.Click += new System.EventHandler(this.updateStockButton_Click);
            // 
            // checkStockButton
            // 
            this.checkStockButton.Location = new System.Drawing.Point(50, 150);
            this.checkStockButton.Name = "checkStockButton";
            this.checkStockButton.Size = new System.Drawing.Size(100, 23);
            this.checkStockButton.TabIndex = 7;
            this.checkStockButton.Text = "Перевірити кількість";
            this.checkStockButton.UseVisualStyleBackColor = true;
            this.checkStockButton.Visible = false;
            this.checkStockButton.Click += new System.EventHandler(this.checkStockButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 233);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.stockIdLabel);
            this.Controls.Add(this.stockIdTextBox);
            this.Controls.Add(this.stockQuantityLabel);
            this.Controls.Add(this.stockQuantityTextBox);
            this.Controls.Add(this.updateStockButton);
            this.Controls.Add(this.checkStockButton);
            this.Controls.Add(this.stockInfoLabel);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Для перевірки запасів
        private void checkStockLevelsMenuItem_Click(object sender, System.EventArgs e)
        {
            // Відображаємо поля для введення ID та кнопку для перевірки запасів
            stockIdLabel.Visible = true;
            stockIdTextBox.Visible = true;
            checkStockButton.Visible = true;
            stockQuantityLabel.Visible = false;
            stockQuantityTextBox.Visible = false;
            updateStockButton.Visible = false;
            stockInfoLabel.Text = "";
        }

        private void checkStockButton_Click(object sender, System.EventArgs e)
        {
            // Отримання ID товару з текстового поля
            string stockId = stockIdTextBox.Text;

            // Перевірка, чи ID є числовим
            if (int.TryParse(stockId, out int productId))
            {
                var productsList = Product.GenerateList();
                // Пошук товару за ID
                Product foundProduct = productsList.FirstOrDefault(p => p.Id == productId);

                // Перевірка, чи товар знайдений
                if (foundProduct != null)
                {
                    // Виведення інформації про товар
                    stockInfoLabel.Text = $"ID: {foundProduct.Id}, Назва: {foundProduct.Name}, Кількість: {foundProduct.Quantity}";
                }
                else
                {
                    // Якщо товар не знайдений
                    stockInfoLabel.Text = "Товар з таким ID не знайдено.";
                }
            }
            else
            {
                // Якщо введене ID не є числом
                stockInfoLabel.Text = "Невірний формат ID. Введіть числове значення.";
            }

            // Відображення результату
            stockInfoLabel.Visible = true;
        }

        // Для оновлення запасів
        private void updateStockMenuItem_Click(object sender, System.EventArgs e)
        {
            // Відображаємо поля для введення ID, кількості та кнопку для оновлення
            stockIdLabel.Visible = true;
            stockIdTextBox.Visible = true;
            stockQuantityLabel.Visible = true;
            stockQuantityTextBox.Visible = true;
            updateStockButton.Visible = true;
            checkStockButton.Visible = false;
            stockInfoLabel.Text = "";
        }

        private void updateStockButton_Click(object sender, EventArgs e)
        {
            // Отримання ID товару та нової кількості
            string stockId = stockIdTextBox.Text;
            int newQuantity;

            if (int.TryParse(stockQuantityTextBox.Text, out newQuantity))
            {
                // Перевірка чи введене ID є числом
                if (int.TryParse(stockId, out int productId))
                {
                    // Отримуємо список продуктів
                    var productsList = Product.GenerateList();

                    // Пошук товару за ID
                    Product foundProduct = productsList.FirstOrDefault(p => p.Id == productId);

                    if (foundProduct != null)
                    {
                        // Оновлення кількості
                        foundProduct.UpdateQuantity(newQuantity);

                        // Виведення інформації про успішне оновлення
                        stockInfoLabel.Text = $"Кількість елемента з ID: {productId} оновлено до: {newQuantity}";
                    }
                    else
                    {
                        stockInfoLabel.Text = "Товар з таким ID не знайдено.";
                    }
                }
                else
                {
                    stockInfoLabel.Text = "Невірний формат ID. Введіть числове значення.";
                }
            }
            else
            {
                stockInfoLabel.Text = "Невірний формат кількості.";
            }

            stockInfoLabel.Visible = true;
        }

    }
}
