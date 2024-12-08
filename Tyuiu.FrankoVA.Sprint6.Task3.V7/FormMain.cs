using Tyuiu.FrankoVA.Sprint6.Task3.V7.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] {{ 31,  25,  -18,  12,   9 },
                                       {  6,  34,   -2,   2,  -18},
                                       { -5,   4,   27,   4,  -1 },
                                       {  4,  15,   34,  -6,  -10},
                                       {  0,   8,    5,  14,  -17} };
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int rows = res.GetUpperBound(0) + 1;
            int coll = res.Length / rows;
            dataGridView1.ColumnCount = coll;
            dataGridView1.RowCount = rows;
            for (int i = 0; i < coll; i++)
            {
                dataGridView1.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИКСб-24-1 ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
