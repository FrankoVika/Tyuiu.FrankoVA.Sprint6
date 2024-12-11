using Tyuiu.FrankoVA.Sprint6.Task5.V22.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "DataSprint6", "InPutDataFileTask5V22.txt");

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            this.chart1.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chart1.ChartAreas[0].AxisX.Title = "Ось Y";
            chart1.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart1.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИБКСб-24-1 Франко Виктория Алексеевна", "Сообщение");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();

        }
    }
}
