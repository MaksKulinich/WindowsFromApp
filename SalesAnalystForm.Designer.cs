using System;

namespace WindowsFormsApp1
{
    partial class SalesAnalystForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox reportContentTextBox;
        private System.Windows.Forms.Button saveReportButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DateTimePicker reportDatePicker;

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
            this.reportContentTextBox = new System.Windows.Forms.TextBox();
            this.saveReportButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.reportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reportContentTextBox
            // 
            this.reportContentTextBox.Location = new System.Drawing.Point(40, 37);
            this.reportContentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportContentTextBox.Multiline = true;
            this.reportContentTextBox.Name = "reportContentTextBox";
            this.reportContentTextBox.Size = new System.Drawing.Size(532, 245);
            this.reportContentTextBox.TabIndex = 0;
            // 
            // saveReportButton
            // 
            this.saveReportButton.Location = new System.Drawing.Point(40, 332);
            this.saveReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveReportButton.Name = "saveReportButton";
            this.saveReportButton.Size = new System.Drawing.Size(200, 37);
            this.saveReportButton.TabIndex = 2;
            this.saveReportButton.Text = "Зберегти звіт";
            this.saveReportButton.UseVisualStyleBackColor = true;
            this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(40, 394);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(533, 37);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Visible = false;
            // 
            // reportDatePicker
            // 
            this.reportDatePicker.Location = new System.Drawing.Point(40, 295);
            this.reportDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportDatePicker.Name = "reportDatePicker";
            this.reportDatePicker.Size = new System.Drawing.Size(265, 22);
            this.reportDatePicker.TabIndex = 1;
            // 
            // SalesAnalystForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 430);
            this.Controls.Add(this.reportContentTextBox);
            this.Controls.Add(this.reportDatePicker);
            this.Controls.Add(this.saveReportButton);
            this.Controls.Add(this.statusLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalesAnalystForm";
            this.Text = "SalesAnalystForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void saveReportButton_Click(object sender, System.EventArgs e)
        {
            // Отримання змісту звіту та дати
            string reportContent = reportContentTextBox.Text;
            DateTime reportDate = reportDatePicker.Value;

            // Створення екземпляра SalesAnalyst
            SalesAnalyst analyst = new SalesAnalyst();

            // Виклик методу для збереження звіту
            analyst.SaveReportToFile(reportContent, reportDate);

            // Відображення статусу
            statusLabel.Text = "Звіт успішно збережено!";
            statusLabel.Visible = true;
        }
    }
}
