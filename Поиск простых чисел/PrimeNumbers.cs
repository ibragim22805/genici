namespace Поиск_простых_чисел
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private int value,
                    count = 0;

        private static bool primeNumber(int number)
        {
            int sqrtNumber = (int)Math.Sqrt(number);
            for (int i = 2; i <= sqrtNumber; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void EnabledObject(bool enabled)
        {
            PrimeValue.Enabled = enabled;
            CountValues.Enabled = enabled;
            FindButton.Enabled = enabled;
        }


        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                value = int.Parse(PrimeValue.Text);
                for (int number = value; count != int.Parse(CountValues.Text); number++)
                {
                    if (primeNumber(number))
                    {
                        PrimeValuesListBox.Items.Add(number);
                        count++;
                    }
                }
                EnabledObject(false);
            }
            catch
            {
                MessageBox.Show("Введите значения правильно");
            }
        }


    }
}