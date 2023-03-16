namespace Жалюзи
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BaseStart();
        }


        int materialAluminum = 3;
        int materialIron = 4;
        int materialPlastic = 2;

        uint horizontal = 2;
        uint vertical = 3;
        uint rolled = 4;
        uint mosaic = 5;

        private void BaseStart()
        {
            TypeHorizontal.Checked = true;
            Material.SelectedIndex = 0;
            WidthValue.Text = "0";
            HeightValue.Text = "0";
        }

        private string BlindsPrice(uint Type)
        {
            string result = string.Empty;
            if (Material.SelectedIndex == 0)
            {
                result = Convert.ToString(uint.Parse(WidthValue.Text) * uint.Parse(HeightValue.Text) * Type * materialAluminum) + "₽";
            }
            else if (Material.SelectedIndex == 1)
            {
                result = Convert.ToString(uint.Parse(WidthValue.Text) * uint.Parse(HeightValue.Text) * Type * materialIron) + "₽";
            }
            else if (Material.SelectedIndex == 2)
            {
                result = Convert.ToString(uint.Parse(WidthValue.Text) * uint.Parse(HeightValue.Text) * Type * materialPlastic) + "₽";
            }
            return result;
        }

        private void Raschet_Click(object sender, EventArgs e)
        {
            try
            {
                if (TypeHorizontal.Checked)
                {
                    Price.Text = BlindsPrice(horizontal);
                }
                else if (TypeVertical.Checked)
                {
                    Price.Text = BlindsPrice(vertical);
                }
                else if (TypeRolled.Checked)
                {
                    Price.Text = BlindsPrice(rolled);
                }
                else if (TypeMosaic.Checked)
                {
                    Price.Text = BlindsPrice(mosaic);
                }
            }
            catch
            {
                MessageBox.Show("Введите ширину и высоту правильно");
            }
        }

        private void Width_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Background_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}