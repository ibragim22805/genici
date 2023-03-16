namespace Кафе
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
            label1 = new Label();
            CalculateButton = new Button();
            Price = new TextBox();
            PriceLabel = new Label();
            Cola = new CheckBox();
            Sup = new CheckBox();
            Salat = new CheckBox();
            Shaverma = new CheckBox();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Controls.Add(label1);
            Background.Controls.Add(CalculateButton);
            Background.Controls.Add(Price);
            Background.Controls.Add(PriceLabel);
            Background.Controls.Add(Cola);
            Background.Controls.Add(Sup);
            Background.Controls.Add(Salat);
            Background.Controls.Add(Shaverma);
            Background.Dock = DockStyle.Fill;
            Background.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(1000, 600);
            Background.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(272, 77);
            label1.Name = "label1";
            label1.Size = new Size(249, 86);
            label1.TabIndex = 8;
            label1.Text = "МЕНЮ\r\n";
            label1.Click += Menu_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateButton.Location = new Point(304, 345);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(196, 55);
            CalculateButton.TabIndex = 7;
            CalculateButton.Text = "Рассчитать";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += Raschet_Click;
            // 
            // Price
            // 
            Price.Enabled = false;
            Price.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Price.Location = new Point(640, 231);
            Price.Name = "Price";
            Price.Size = new Size(206, 39);
            Price.TabIndex = 6;
            Price.TextChanged += Cost_TextChanged;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(617, 177);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(251, 37);
            PriceLabel.TabIndex = 5;
            PriceLabel.Text = "Стоимость заказа";
            // 
            // Cola
            // 
            Cola.AutoSize = true;
            Cola.Cursor = Cursors.Hand;
            Cola.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Cola.Location = new Point(332, 294);
            Cola.Name = "Cola";
            Cola.Size = new Size(90, 33);
            Cola.TabIndex = 4;
            Cola.Text = "Кола";
            Cola.UseVisualStyleBackColor = true;
            // 
            // Sup
            // 
            Sup.AutoSize = true;
            Sup.Cursor = Cursors.Hand;
            Sup.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Sup.Location = new Point(332, 255);
            Sup.Name = "Sup";
            Sup.Size = new Size(75, 33);
            Sup.TabIndex = 3;
            Sup.Text = "Суп";
            Sup.UseVisualStyleBackColor = true;
            Sup.CheckedChanged += Sup_CheckedChanged;
            // 
            // Salat
            // 
            Salat.AutoSize = true;
            Salat.Cursor = Cursors.Hand;
            Salat.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Salat.Location = new Point(332, 216);
            Salat.Name = "Salat";
            Salat.Size = new Size(102, 33);
            Salat.TabIndex = 2;
            Salat.Text = "Салат";
            Salat.UseVisualStyleBackColor = true;
            // 
            // Shaverma
            // 
            Shaverma.AutoSize = true;
            Shaverma.Cursor = Cursors.Hand;
            Shaverma.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Shaverma.Location = new Point(332, 177);
            Shaverma.Name = "Shaverma";
            Shaverma.Size = new Size(121, 33);
            Shaverma.TabIndex = 1;
            Shaverma.Text = "Шаурма";
            Shaverma.UseVisualStyleBackColor = true;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel Background;
        private Button CalculateButton;
        private TextBox Price;
        private Label PriceLabel;
        private CheckBox Cola;
        private CheckBox Sup;
        private CheckBox Salat;
        private CheckBox Shaverma;
        private Label label1;
    }
}