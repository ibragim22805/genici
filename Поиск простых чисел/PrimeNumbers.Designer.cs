namespace Поиск_простых_чисел
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
            PrimeValuesListBox = new ListBox();
            FindButton = new Button();
            CountValuesLabel = new Label();
            PrimeValueLabel = new Label();
            CountValues = new TextBox();
            PrimeValue = new TextBox();
            Background.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.Controls.Add(PrimeValuesListBox);
            Background.Controls.Add(FindButton);
            Background.Controls.Add(CountValuesLabel);
            Background.Controls.Add(PrimeValueLabel);
            Background.Controls.Add(CountValues);
            Background.Controls.Add(PrimeValue);
            Background.Dock = DockStyle.Fill;
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(1000, 600);
            Background.TabIndex = 0;
            // 
            // PrimeValuesListBox
            // 
            PrimeValuesListBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PrimeValuesListBox.FormattingEnabled = true;
            PrimeValuesListBox.HorizontalScrollbar = true;
            PrimeValuesListBox.ItemHeight = 25;
            PrimeValuesListBox.Location = new Point(516, 84);
            PrimeValuesListBox.Name = "PrimeValuesListBox";
            PrimeValuesListBox.Size = new Size(253, 454);
            PrimeValuesListBox.TabIndex = 19;
            // 
            // FindButton
            // 
            FindButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            FindButton.Location = new Point(171, 373);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(161, 57);
            FindButton.TabIndex = 18;
            FindButton.Text = "Найти";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += search_Click;
            // 
            // CountValuesLabel
            // 
            CountValuesLabel.AutoSize = true;
            CountValuesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CountValuesLabel.Location = new Point(119, 255);
            CountValuesLabel.Name = "CountValuesLabel";
            CountValuesLabel.Size = new Size(258, 37);
            CountValuesLabel.TabIndex = 17;
            CountValuesLabel.Text = "Количество чисел";
            // 
            // PrimeValueLabel
            // 
            PrimeValueLabel.AutoSize = true;
            PrimeValueLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            PrimeValueLabel.Location = new Point(198, 129);
            PrimeValueLabel.Name = "PrimeValueLabel";
            PrimeValueLabel.Size = new Size(100, 37);
            PrimeValueLabel.TabIndex = 16;
            PrimeValueLabel.Text = "Число";
            // 
            // CountValues
            // 
            CountValues.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CountValues.Location = new Point(125, 295);
            CountValues.Name = "CountValues";
            CountValues.Size = new Size(252, 39);
            CountValues.TabIndex = 15;
            // 
            // PrimeValue
            // 
            PrimeValue.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PrimeValue.Location = new Point(125, 169);
            PrimeValue.Name = "PrimeValue";
            PrimeValue.Size = new Size(252, 39);
            PrimeValue.TabIndex = 14;
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
        private Label CountValuesLabel;
        private Label PrimeValueLabel;
        private TextBox CountValues;
        private TextBox PrimeValue;
        private Button FindButton;
        private ListBox PrimeValuesListBox;
    }
}