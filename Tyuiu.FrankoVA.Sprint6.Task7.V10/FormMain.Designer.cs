namespace Tyuiu.FrankoVA.Sprint6.Task7.V10
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox3 = new GroupBox();
            dataGridViewOT = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewFile = new DataGridView();
            panel1 = new Panel();
            buttonSave = new Button();
            buttonOpenFile = new Button();
            buttonStart = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOT).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFile).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Right;
            groupBox3.Controls.Add(dataGridViewOT);
            groupBox3.Location = new Point(527, 159);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(491, 538);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dataGridViewOT
            // 
            dataGridViewOT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOT.Location = new Point(6, 26);
            dataGridViewOT.Name = "dataGridViewOT";
            dataGridViewOT.RowHeadersWidth = 51;
            dataGridViewOT.Size = new Size(479, 506);
            dataGridViewOT.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Left;
            groupBox2.Controls.Add(dataGridViewFile);
            groupBox2.Location = new Point(17, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 538);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // dataGridViewFile
            // 
            dataGridViewFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFile.Location = new Point(6, 26);
            dataGridViewFile.Name = "dataGridViewFile";
            dataGridViewFile.RowHeadersWidth = 51;
            dataGridViewFile.Size = new Size(492, 506);
            dataGridViewFile.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Controls.Add(buttonStart);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 61);
            panel1.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(351, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 48);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            toolTip1.SetToolTip(buttonSave, "Кто создал проект");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(14, 4);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(95, 48);
            buttonOpenFile.TabIndex = 8;
            buttonOpenFile.Text = "Добавить файл";
            toolTip1.SetToolTip(buttonOpenFile, "Выберети файл который необходимо загрузить");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(126, 4);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 48);
            buttonStart.TabIndex = 9;
            buttonStart.Text = "Пуск";
            toolTip1.SetToolTip(buttonStart, "Запуск программы");
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // button1
            // 
            button1.Location = new Point(240, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 48);
            button1.TabIndex = 10;
            button1.Text = "Помощь";
            toolTip1.SetToolTip(button1, "Кто создал проект");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Location = new Point(3, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1034, 88);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 719);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOT).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFile).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Panel panel1;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private Button buttonOpenFile;
        private Button buttonStart;
        private Button button1;
        private Button buttonSave;
        private DataGridView dataGridViewOT;
        private DataGridView dataGridViewFile;
        private SaveFileDialog saveFileDialog1;
    }
}
