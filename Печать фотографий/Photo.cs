namespace Печать_фотографий
{
    public partial class Photo : Form
    {
        public Photo()
        {
            InitializeComponent();
            Begin();
        }


        int black = 5;
        int colored = 15;
        int negative = 10;

        uint size_3x4 = 7;
        uint size_9x12 = 21;
        uint size_12x15 = 27;
        uint size_18x24 = 32;

        private void Begin()
        {
            TypeBlackWhite.Checked = true;
            Size3x4.Checked = true;
            Count.Text = "0";
        }

        private string Cost(uint Size)
        {
            string result = string.Empty;
            if (TypeBlackWhite.Checked)
            {
                result = Convert.ToString(uint.Parse(Count.Text) * Size * black) + "₽";
            }
            else if (TypeColored.Checked)
            {
                result = Convert.ToString(uint.Parse(Count.Text) * Size * colored) + "₽";
            }
            else if (TypeNegative.Checked)
            {
                result = Convert.ToString(uint.Parse(Count.Text) * Size * negative) + "₽";
            }
            return result;
        }

        private void Raschet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Size3x4.Checked)
                {
                    Price.Text = Cost(size_3x4);
                }
                else if (Size9x12.Checked)
                {
                    Price.Text = Cost(size_9x12);
                }
                else if (Size12x15.Checked)
                {
                    Price.Text = Cost(size_12x15);
                }
                else if (Size18x24.Checked)
                {
                    Price.Text = Cost(size_18x24);
                }
            }
            catch
            {
                MessageBox.Show("Введите количество правильно");
            }
        }

        private void Background_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}