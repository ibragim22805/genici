namespace Печать_фотографий
{
    public partial class Photo : Form
    {
        public Photo()
        {
            InitializeComponent();
            BaseStart();
        }

        private Point lastPoint;

        int black = 5;
        int colored = 15;
        int negative = 10;

        private const uint SIZE_3X4_PRICE = 7,
                           SIZE_9X12_PRICE = 21,
                           SIZE_12X15_PRICE = 27,
                           SIZE_18X24_PRICE = 42;

        private void BaseStart()
        {
            TypeBlackWhite.Checked = true;
            Size3x4.Checked = true;
            Count.Text = "0";
        }

        private string PricePhoto(uint Size)
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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Size3x4.Checked)
                {
                    Price.Text = PricePhoto(SIZE_3X4_PRICE);
                }
                else if (Size9x12.Checked)
                {
                    Price.Text = PricePhoto(SIZE_9X12_PRICE);
                }
                else if (Size12x15.Checked)
                {
                    Price.Text = PricePhoto(SIZE_12X15_PRICE);
                }
                else if (Size18x24.Checked)
                {
                    Price.Text = PricePhoto(SIZE_18X24_PRICE);
                }
            }
            catch
            {
                MessageBox.Show("Введите количество правильно");
            }
        }

    }
}