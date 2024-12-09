using Tyuiu.FrankoVA.Sprint6.Task4.V10.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task4.V10
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
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";
            textBox3.Text = "";
            for (int i = 0; i <= len - 1; i++)
            {
                this.chart1.Series[0].Points.AddXY(startValue, res[i]);
                textBox3.AppendText(res[i] + Environment.NewLine);
                startValue++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ИБКСб-24-1 Франко Виктория Алексеевна",
               "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
            File.WriteAllText(path, textBox3.Text);

            DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \nОткрыть его в блокноте?",
                "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }
    }
}
