namespace WindowsFormsApp1
{
    partial class InventoryControllerForm
    {
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productDescriptionTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button searchProductButton;
        private System.Windows.Forms.Label productInfoLabel;

        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productDescriptionLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.Label productCategoryLabel;

        private void InitializeComponent()
        {
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.productInfoLabel = new System.Windows.Forms.Label();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(40, 37);
            this.productIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(199, 22);
            this.productIdTextBox.TabIndex = 1;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(40, 98);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(199, 22);
            this.productNameTextBox.TabIndex = 3;
            // 
            // productDescriptionTextBox
            // 
            this.productDescriptionTextBox.Location = new System.Drawing.Point(40, 160);
            this.productDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productDescriptionTextBox.Name = "productDescriptionTextBox";
            this.productDescriptionTextBox.Size = new System.Drawing.Size(199, 22);
            this.productDescriptionTextBox.TabIndex = 5;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(40, 222);
            this.productPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(199, 22);
            this.productPriceTextBox.TabIndex = 7;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(40, 283);
            this.productQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(199, 22);
            this.productQuantityTextBox.TabIndex = 9;
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.Location = new System.Drawing.Point(40, 345);
            this.productCategoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(199, 22);
            this.productCategoryTextBox.TabIndex = 11;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(267, 98);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(133, 37);
            this.addProductButton.TabIndex = 12;
            this.addProductButton.Text = "Додати товар";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // searchProductButton
            // 
            this.searchProductButton.Location = new System.Drawing.Point(267, 37);
            this.searchProductButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(133, 37);
            this.searchProductButton.TabIndex = 13;
            this.searchProductButton.Text = "Знайти товар";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // productInfoLabel
            // 
            this.productInfoLabel.Location = new System.Drawing.Point(40, 394);
            this.productInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productInfoLabel.Name = "productInfoLabel";
            this.productInfoLabel.Size = new System.Drawing.Size(400, 123);
            this.productInfoLabel.TabIndex = 14;
            this.productInfoLabel.Text = "Інформація про товар";
            this.productInfoLabel.Visible = false;
            // 
            // productIdLabel
            // 
            this.productIdLabel.Location = new System.Drawing.Point(40, 12);
            this.productIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(200, 25);
            this.productIdLabel.TabIndex = 0;
            this.productIdLabel.Text = "ID продукту:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.Location = new System.Drawing.Point(40, 74);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(200, 25);
            this.productNameLabel.TabIndex = 2;
            this.productNameLabel.Text = "Назва продукту:";
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.Location = new System.Drawing.Point(40, 135);
            this.productDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(200, 25);
            this.productDescriptionLabel.TabIndex = 4;
            this.productDescriptionLabel.Text = "Опис продукту:";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.Location = new System.Drawing.Point(40, 197);
            this.productPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(200, 25);
            this.productPriceLabel.TabIndex = 6;
            this.productPriceLabel.Text = "Ціна:";
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.Location = new System.Drawing.Point(40, 258);
            this.productQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(200, 25);
            this.productQuantityLabel.TabIndex = 8;
            this.productQuantityLabel.Text = "Кількість:";
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.Location = new System.Drawing.Point(40, 320);
            this.productCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(200, 25);
            this.productCategoryLabel.TabIndex = 10;
            this.productCategoryLabel.Text = "Категорія:";
            // 
            // InventoryControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 469);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productDescriptionLabel);
            this.Controls.Add(this.productDescriptionTextBox);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.productQuantityTextBox);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.productCategoryTextBox);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.searchProductButton);
            this.Controls.Add(this.productInfoLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InventoryControllerForm";
            this.Text = "InventoryControllerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void addProductButton_Click(object sender, System.EventArgs e)
        {
            // Логіка додавання нового товару через контролер
            int id = int.Parse(productIdTextBox.Text);
            string name = productNameTextBox.Text;
            string description = productDescriptionTextBox.Text;
            decimal price = decimal.Parse(productPriceTextBox.Text);
            int quantity = int.Parse(productQuantityTextBox.Text);
            string category = productCategoryTextBox.Text;

            Product newProduct = new Product(id, name, description, price, quantity, category);
            InventoryController controller = new InventoryController();
            controller.AddProduct(newProduct);

            productInfoLabel.Text = "Товар успішно додано!";
            productInfoLabel.Visible = true;
        }

        private void searchProductButton_Click(object sender, System.EventArgs e)
        {
            // Логіка пошуку товару за ID через контролер
            int id = int.Parse(productIdTextBox.Text);
            InventoryController controller = new InventoryController();
            Product product = controller.GetProductById(id);

            if (product != null)
            {
                productInfoLabel.Text = $"Товар знайдено: {product.GetName()}, Кількість: {product.GetQuantity()}, Ціна: {product.GetPrice()}";
            }
            else
            {
                productInfoLabel.Text = "Товар не знайдено!";
            }

            productInfoLabel.Visible = true;
        }
    }
}
