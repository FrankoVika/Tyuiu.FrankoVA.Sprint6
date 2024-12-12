using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.FrankoVA.Sprint6.Task6.V7.Lib;
namespace Tyuiu.FrankoVA.Sprint6.Task6.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = "";


      

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                textBoxIn.Text = File.ReadAllText(path);
                buttonStart.Enabled = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAbuot formAbout = new FormAbuot();
            formAbout.ShowDialog();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
           textBoxOut.Text = ds.CollectTextFromFile(path);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
