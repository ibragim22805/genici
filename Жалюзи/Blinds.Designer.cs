namespace Жалюзи
{
    partial class Menu
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
            Material = new ComboBox();
            MaterialLabel = new Label();
            HeightValue = new TextBox();
            HeightLabel = new Label();
            WidthValue = new TextBox();
            WidthLabel = new Label();
            TypeBox = new GroupBox();
            TypeMosaic = new RadioButton();
            TypeRolled = new RadioButton();
            TypeVertical = new RadioButton();
            TypeHorizontal = new RadioButton();
            Background.SuspendLayout();
            TypeBox.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Controls.Add(CalculateButton);
            Background.Controls.Add(Price);
            Background.Controls.Add(PriceLabel);
            Background.Controls.Add(Material);
            Background.Controls.Add(MaterialLabel);
            Background.Controls.Add(HeightValue);
            Background.Controls.Add(HeightLabel);
            Background.Controls.Add(WidthValue);
            Background.Controls.Add(WidthLabel);
            Background.Controls.Add(TypeBox);
            Background.Dock = DockStyle.Fill;
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(1000, 600);
            Background.TabIndex = 0;
            Background.Paint += Background_Paint;
            // 
            // CalculateButton
            // 
            CalculateButton.Cursor = Cursors.Hand;
            CalculateButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateButton.Location = new Point(629, 393);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(306, 144);
            CalculateButton.TabIndex = 13;
            CalculateButton.Text = "Рассчитать";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += Raschet_Click;
            // 
            // Price
            // 
            Price.Enabled = false;
            Price.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Price.Location = new Point(658, 329);
            Price.Name = "Price";
            Price.Size = new Size(242, 43);
            Price.TabIndex = 12;
            Price.TextChanged += Cost_TextChanged;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(745, 296);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(65, 30);
            PriceLabel.TabIndex = 11;
            PriceLabel.Text = "Цена";
            // 
            // Material
            // 
            Material.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Material.FormattingEnabled = true;
            Material.Items.AddRange(new object[] { "Алюминий", "Железо", "Пластик" });
            Material.Location = new Point(216, 360);
            Material.Name = "Material";
            Material.Size = new Size(172, 45);
            Material.TabIndex = 10;
            // 
            // MaterialLabel
            // 
            MaterialLabel.AutoSize = true;
            MaterialLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            MaterialLabel.Location = new Point(238, 311);
            MaterialLabel.Name = "MaterialLabel";
            MaterialLabel.Size = new Size(115, 30);
            MaterialLabel.TabIndex = 9;
            MaterialLabel.Text = "Материал";
            // 
            // HeightValue
            // 
            HeightValue.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HeightValue.Location = new Point(216, 235);
            HeightValue.Name = "HeightValue";
            HeightValue.Size = new Size(172, 43);
            HeightValue.TabIndex = 8;
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            HeightLabel.Location = new Point(238, 185);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(135, 30);
            HeightLabel.TabIndex = 7;
            HeightLabel.Text = "Высота (см)";
            // 
            // WidthValue
            // 
            WidthValue.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            WidthValue.Location = new Point(216, 109);
            WidthValue.Name = "WidthValue";
            WidthValue.Size = new Size(172, 43);
            WidthValue.TabIndex = 6;
            WidthValue.TextChanged += Width_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            WidthLabel.Location = new Point(228, 56);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(145, 30);
            WidthLabel.TabIndex = 5;
            WidthLabel.Text = "Ширина (см)";
            // 
            // TypeBox
            // 
            TypeBox.Controls.Add(TypeMosaic);
            TypeBox.Controls.Add(TypeRolled);
            TypeBox.Controls.Add(TypeVertical);
            TypeBox.Controls.Add(TypeHorizontal);
            TypeBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TypeBox.Location = new Point(445, 56);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(200, 181);
            TypeBox.TabIndex = 2;
            TypeBox.TabStop = false;
            TypeBox.Text = "Тип жалюзи";
            // 
            // TypeMosaic
            // 
            TypeMosaic.AutoSize = true;
            TypeMosaic.Cursor = Cursors.Hand;
            TypeMosaic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeMosaic.Location = new Point(6, 138);
            TypeMosaic.Name = "TypeMosaic";
            TypeMosaic.Size = new Size(112, 25);
            TypeMosaic.TabIndex = 3;
            TypeMosaic.TabStop = true;
            TypeMosaic.Text = "Мозаичные";
            TypeMosaic.UseVisualStyleBackColor = true;
            // 
            // TypeRolled
            // 
            TypeRolled.AutoSize = true;
            TypeRolled.Cursor = Cursors.Hand;
            TypeRolled.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeRolled.Location = new Point(6, 107);
            TypeRolled.Name = "TypeRolled";
            TypeRolled.Size = new Size(99, 25);
            TypeRolled.TabIndex = 2;
            TypeRolled.TabStop = true;
            TypeRolled.Text = "Рулонные";
            TypeRolled.UseVisualStyleBackColor = true;
            // 
            // TypeVertical
            // 
            TypeVertical.AutoSize = true;
            TypeVertical.Cursor = Cursors.Hand;
            TypeVertical.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeVertical.Location = new Point(6, 76);
            TypeVertical.Name = "TypeVertical";
            TypeVertical.Size = new Size(130, 25);
            TypeVertical.TabIndex = 1;
            TypeVertical.TabStop = true;
            TypeVertical.Text = "Вертикальные";
            TypeVertical.UseVisualStyleBackColor = true;
            // 
            // TypeHorizontal
            // 
            TypeHorizontal.AutoSize = true;
            TypeHorizontal.Cursor = Cursors.Hand;
            TypeHorizontal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TypeHorizontal.Location = new Point(6, 45);
            TypeHorizontal.Name = "TypeHorizontal";
            TypeHorizontal.Size = new Size(147, 25);
            TypeHorizontal.TabIndex = 0;
            TypeHorizontal.TabStop = true;
            TypeHorizontal.Text = "Горизонтальные";
            TypeHorizontal.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(Background);
            Name = "Menu";
            Background.ResumeLayout(false);
            Background.PerformLayout();
            TypeBox.ResumeLayout(false);
            TypeBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private GroupBox TypeBox;
        private RadioButton TypeMosaic;
        private RadioButton TypeRolled;
        private RadioButton TypeVertical;
        private RadioButton TypeHorizontal;
        private Label MaterialLabel;
        private TextBox HeightValue;
        private Label HeightLabel;
        private TextBox WidthValue;
        private Label WidthLabel;
        private ComboBox Material;
        private TextBox Price;
        private Label PriceLabel;
        private Button CalculateButton;
    }
}