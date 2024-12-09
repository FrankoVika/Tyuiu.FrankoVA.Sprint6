using Tyuiu.FrankoVA.Sprint6.Task2.V3.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void button1_Click(object sender, EventArgs e)
        {
            int startValue = Convert.ToInt32(textBox1.Text);
            int stopValue = Convert.ToInt32(textBox2.Text);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] result = new double[len];
            result = ds.GetMassFunction(startValue, stopValue);
            this.richTextBox1.Titles.Add("График функции F(X)= sin(x) / x + 1,2 + cos(x) * 7x - 2");

        }
    }
}
