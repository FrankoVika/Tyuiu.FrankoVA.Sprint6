using Tyuiu.FrankoVA.Sprint6.Task1.V17.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task1.V17
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
            string strLine;
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            textBox3.Text = "";
            textBox3.AppendText("+----------+----------+" + Environment.NewLine);
            textBox3.AppendText("|    X     |    F     |" + Environment.NewLine);
            textBox3.AppendText("+----------+----------+" + Environment.NewLine);
            for (int i = 0; i <= len - 1; i++)
            {
                strLine = String.Format("|{0,5}    |  {1, 6:f2}   |", startValue, valueArray[i]);
                textBox3.AppendText(strLine + Environment.NewLine);
                startValue++;
            }
            textBox3.AppendText("+----------+----------+" + Environment.NewLine);
        }
    }
}
