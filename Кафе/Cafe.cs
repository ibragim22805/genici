namespace Кафе
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BaseStart();
        }

        private uint price = 0;

        uint shaverma = 150;
        uint salat = 100;
        uint sup = 50;
        uint cola = 200;

        private string FoodPrice(uint Price)
        {
            if (Shaverma.Checked)
            {
                Price += shaverma;
            }
            if (Salat.Checked)
            {
                Price += salat;
            }
            if (Sup.Checked)
            {
                Price += sup;
            }
            if (Cola.Checked)
            {
                Price += cola;
            }
            return Convert.ToString(Price) + "₽";
        }

        private void Raschet_Click(object sender, EventArgs e)
        {
            Price.Text = FoodPrice(price);
        }

        private void BaseStart()
        {
            Shaverma.Checked = false;
            Salat.Checked = false;
            Sup.Checked = false;
            Cola.Checked = false;
            Price.Text = string.Empty;
        }

        private void Cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {

        }

        private void Sup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Background_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}