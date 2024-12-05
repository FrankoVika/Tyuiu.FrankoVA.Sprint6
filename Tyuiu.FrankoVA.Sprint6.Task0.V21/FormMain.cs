using Tyuiu.FrankoVA.Sprint6.Task0.V21.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            double res = ds.Calculate(x);
            textBox2.Text = res.ToString();
        }
    }
}
