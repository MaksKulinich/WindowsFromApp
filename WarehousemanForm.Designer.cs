using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WarehousemanForm : Form
    {


        private void WarehousemanForm_Load(object sender, EventArgs e)
        {
            // Можливі додаткові ініціалізації при завантаженні форми
        }

        // Обробник події для кнопки перевірки продукту

        #region Windows Form Designer generated code

        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxProductId;
        private Button buttonCheckProduct;
        private TextBox textBoxProductName;
        private TextBox textBoxProductDescription;
        private TextBox textBoxProductPrice;
        private TextBox textBoxProductQuantity;
        private TextBox textBoxProductCategory;
        private Label label1;
        private Label labelName;
        private Label labelDescription;
        private Label labelPrice;
        private Label labelQuantity;
        private Label labelCategory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.buttonCheckProduct = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductQuantity = new System.Windows.Forms.TextBox();
            this.textBoxProductCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(12, 93);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductId.TabIndex = 0;
            // 
            // buttonCheckProduct
            // 
            this.buttonCheckProduct.Location = new System.Drawing.Point(130, 92);
            this.buttonCheckProduct.Name = "buttonCheckProduct";
            this.buttonCheckProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckProduct.TabIndex = 1;
            this.buttonCheckProduct.Text = "Check";
            this.buttonCheckProduct.UseVisualStyleBackColor = true;
            this.buttonCheckProduct.Click += new System.EventHandler(this.ButtonCheckProduct_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(12, 150);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(200, 22);
            this.textBoxProductName.TabIndex = 2;
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(12, 200);
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.ReadOnly = true;
            this.textBoxProductDescription.Size = new System.Drawing.Size(200, 22);
            this.textBoxProductDescription.TabIndex = 3;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(12, 250);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.ReadOnly = true;
            this.textBoxProductPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductPrice.TabIndex = 4;
            // 
            // textBoxProductQuantity
            // 
            this.textBoxProductQuantity.Location = new System.Drawing.Point(12, 300);
            this.textBoxProductQuantity.Name = "textBoxProductQuantity";
            this.textBoxProductQuantity.ReadOnly = true;
            this.textBoxProductQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductQuantity.TabIndex = 5;
            // 
            // textBoxProductCategory
            // 
            this.textBoxProductCategory.Location = new System.Drawing.Point(12, 350);
            this.textBoxProductCategory.Name = "textBoxProductCategory";
            this.textBoxProductCategory.ReadOnly = true;
            this.textBoxProductCategory.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductCategory.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введіть id товару";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 16);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Назва";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 180);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(90, 16);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Опис товару";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 230);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 16);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Ціна";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(12, 280);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(64, 16);
            this.labelQuantity.TabIndex = 11;
            this.labelQuantity.Text = "Кількість";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(12, 330);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(70, 16);
            this.labelCategory.TabIndex = 12;
            this.labelCategory.Text = "Категорія";
            // 
            // WarehousemanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductCategory);
            this.Controls.Add(this.textBoxProductQuantity);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.textBoxProductDescription);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.buttonCheckProduct);
            this.Controls.Add(this.textBoxProductId);
            this.Name = "WarehousemanForm";
            this.Text = "WarehousemanForm";
            this.Load += new System.EventHandler(this.WarehousemanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ButtonCheckProduct_Click(object sender, EventArgs e)
        {
            int productId;
            if (int.TryParse(textBoxProductId.Text, out productId))
            {
                // Виклик методу для отримання інформації про продукт
                Product product = GetProductById(productId);
                if (product != null)
                {
                    // Вивід інформації про продукт в окремих полях
                    textBoxProductName.Text = product.GetName();
                    textBoxProductDescription.Text = product.GetDescription();
                    textBoxProductPrice.Text = product.GetPrice().ToString("F2");
                    textBoxProductQuantity.Text = product.GetQuantity().ToString();
                    textBoxProductCategory.Text = product.GetCategory();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Product ID.");
            }
        }

        // Метод для отримання продукту за ID
        private Product GetProductById(int id)
        {
            // Це просто приклад. Заміни цю частину на свій код доступу до даних.
            if (id == 1)
            {
                return new Product(1, "Sample Product", "This is a sample product.", 10.99m, 100, "Electronics");
            }
            else if (id == 2)
            {
                return new Product(2, "Another Product", "This is another product.", 20.50m, 50, "Groceries");
            }
            return null;
        }
    }
}
