using System.Windows.Forms;
using Tyuiu.FrankoVA.Sprint6.Task7.V10.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

            dataGridViewFile.ColumnCount = 50;
            dataGridViewOT.ColumnCount = 50;

            dataGridViewFile.RowCount = 50;
            dataGridViewOT.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewFile.Columns[i].Width = 25;
                dataGridViewOT.Columns[i].Width = 25;
            }
        }
        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewFile.ColumnCount = colums;
            dataGridViewFile.RowCount = rows;
            dataGridViewOT.ColumnCount = colums;
            dataGridViewOT.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewFile.Columns[i].Width = 50;
                dataGridViewFile.Columns[i].Width = 50;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewFile.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonStart.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOT.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOT.RowCount; 
            int columns = dataGridViewOT.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOT.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOT.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        
        
    }
}

