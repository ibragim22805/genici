namespace Печать_фотографий
{
    partial class Photo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Background = new Panel();
            CalculateButton = new Button();
            Price = new TextBox();
            PriceLabel = new Label();
            Count = new TextBox();
            CountLabel = new Label();
            TypeBox = new GroupBox();
            TypeNegative = new RadioButton();
            TypeColored = new RadioButton();
            TypeBlackWhite = new RadioButton();
            SizeBox = new GroupBox();
            Size18x24 = new RadioButton();
            Size12x15 = new RadioButton();
            Size9x12 = new RadioButton();
            Size3x4 = new RadioButton();
            Background.SuspendLayout();
            TypeBox.SuspendLayout();
            SizeBox.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Controls.Add(CalculateButton);
            Background.Controls.Add(Price);
            Background.Controls.Add(PriceLabel);
            Background.Controls.Add(Count);
            Background.Controls.Add(CountLabel);
            Background.Controls.Add(TypeBox);
            Background.Controls.Add(SizeBox);
            Background.Dock = DockStyle.Fill;
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(1000, 600);
            Background.TabIndex = 0;
            // 
            // CalculateButton
            // 
            CalculateButton.Cursor = Cursors.Hand;
            CalculateButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateButton.Location = new Point(213, 478);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(177, 46);
            CalculateButton.TabIndex = 7;
            CalculateButton.Text = "Рассчитать";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += Raschet_Click;
            // 
            // Price
            // 
            Price.Enabled = false;
            Price.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Price.Location = new Point(182, 406);
            Price.Name = "Price";
            Price.Size = new Size(236, 43);
            Price.TabIndex = 6;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(268, 358);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(65, 30);
            PriceLabel.TabIndex = 5;
            PriceLabel.Text = "Цена";
            // 
            // Count
            // 
            Count.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Count.Location = new Point(746, 461);
            Count.Name = "Count";
            Count.Size = new Size(172, 43);
            Count.TabIndex = 4;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CountLabel.Location = new Point(605, 470);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(135, 30);
            CountLabel.TabIndex = 3;
            CountLabel.Text = "Количество";
            // 
            // TypeBox
            // 
            TypeBox.Controls.Add(TypeNegative);
            TypeBox.Controls.Add(TypeColored);
            TypeBox.Controls.Add(TypeBlackWhite);
            TypeBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TypeBox.Location = new Point(605, 286);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(313, 169);
            TypeBox.TabIndex = 2;
            TypeBox.TabStop = false;
            TypeBox.Text = "Тип фото";
            // 
            // TypeNegative
            // 
            TypeNegative.AutoSize = true;
            TypeNegative.Cursor = Cursors.Hand;
            TypeNegative.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeNegative.Location = new Point(6, 138);
            TypeNegative.Name = "TypeNegative";
            TypeNegative.Size = new Size(85, 25);
            TypeNegative.TabIndex = 3;
            TypeNegative.TabStop = true;
            TypeNegative.Text = "Негатив";
            TypeNegative.UseVisualStyleBackColor = true;
            // 
            // TypeColored
            // 
            TypeColored.AutoSize = true;
            TypeColored.Cursor = Cursors.Hand;
            TypeColored.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeColored.Location = new Point(6, 96);
            TypeColored.Name = "TypeColored";
            TypeColored.Size = new Size(89, 25);
            TypeColored.TabIndex = 2;
            TypeColored.TabStop = true;
            TypeColored.Text = "Цветное";
            TypeColored.UseVisualStyleBackColor = true;
            // 
            // TypeBlackWhite
            // 
            TypeBlackWhite.AutoSize = true;
            TypeBlackWhite.Cursor = Cursors.Hand;
            TypeBlackWhite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeBlackWhite.Location = new Point(6, 55);
            TypeBlackWhite.Name = "TypeBlackWhite";
            TypeBlackWhite.Size = new Size(116, 25);
            TypeBlackWhite.TabIndex = 1;
            TypeBlackWhite.TabStop = true;
            TypeBlackWhite.Text = "Чёрнобелое";
            TypeBlackWhite.UseVisualStyleBackColor = true;
            // 
            // SizeBox
            // 
            SizeBox.Controls.Add(Size18x24);
            SizeBox.Controls.Add(Size12x15);
            SizeBox.Controls.Add(Size9x12);
            SizeBox.Controls.Add(Size3x4);
            SizeBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SizeBox.Location = new Point(605, 111);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(313, 169);
            SizeBox.TabIndex = 1;
            SizeBox.TabStop = false;
            SizeBox.Text = "Размер";
            // 
            // Size18x24
            // 
            Size18x24.AutoSize = true;
            Size18x24.Cursor = Cursors.Hand;
            Size18x24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Size18x24.Location = new Point(6, 138);
            Size18x24.Name = "Size18x24";
            Size18x24.Size = new Size(79, 25);
            Size18x24.TabIndex = 3;
            Size18x24.TabStop = true;
            Size18x24.Text = "18 x 24";
            Size18x24.UseVisualStyleBackColor = true;
            // 
            // Size12x15
            // 
            Size12x15.AutoSize = true;
            Size12x15.Cursor = Cursors.Hand;
            Size12x15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Size12x15.Location = new Point(6, 107);
            Size12x15.Name = "Size12x15";
            Size12x15.Size = new Size(79, 25);
            Size12x15.TabIndex = 2;
            Size12x15.TabStop = true;
            Size12x15.Text = "12 x 15";
            Size12x15.UseVisualStyleBackColor = true;
            // 
            // Size9x12
            // 
            Size9x12.AutoSize = true;
            Size9x12.Cursor = Cursors.Hand;
            Size9x12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Size9x12.Location = new Point(6, 76);
            Size9x12.Name = "Size9x12";
            Size9x12.Size = new Size(70, 25);
            Size9x12.TabIndex = 1;
            Size9x12.TabStop = true;
            Size9x12.Text = "9 x 12";
            Size9x12.UseVisualStyleBackColor = true;
            // 
            // Size3x4
            // 
            Size3x4.AutoSize = true;
            Size3x4.Cursor = Cursors.Hand;
            Size3x4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Size3x4.Location = new Point(6, 45);
            Size3x4.Name = "Size3x4";
            Size3x4.Size = new Size(61, 25);
            Size3x4.TabIndex = 0;
            Size3x4.TabStop = true;
            Size3x4.Text = "3 x 4";
            Size3x4.UseVisualStyleBackColor = true;
            // 
            // Photo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(Background);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Photo";
            Background.ResumeLayout(false);
            Background.PerformLayout();
            TypeBox.ResumeLayout(false);
            TypeBox.PerformLayout();
            SizeBox.ResumeLayout(false);
            SizeBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private Button CalculateButton;
        private TextBox Price;
        private Label PriceLabel;
        private TextBox Count;
        private Label CountLabel;
        private GroupBox TypeBox;
        private RadioButton TypeNegative;
        private RadioButton TypeColored;
        private RadioButton TypeBlackWhite;
        private GroupBox SizeBox;
        private RadioButton Size18x24;
        private RadioButton Size12x15;
        private RadioButton Size9x12;
        private RadioButton Size3x4;
    }
}