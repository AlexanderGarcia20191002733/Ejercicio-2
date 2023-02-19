namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(textBox1.Text);
            decimal n2 = Convert.ToDecimal(textBox2.Text);
            decimal n3 = Convert.ToDecimal(textBox3.Text);
            decimal n4 = Convert.ToDecimal(textBox4.Text);

            decimal PROMEDIO = await promedioAsync(n1, n2, n3, n4);
            MessageBox.Show($"El Promedio es: {PROMEDIO}");
        }

        private async Task<decimal> promedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {

            decimal promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return promedio;
        }
    }
}