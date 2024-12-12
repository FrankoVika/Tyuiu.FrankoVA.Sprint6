namespace Tyuiu.FrankoVA.Sprint6.Task6.V7
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
            buttonOpenFile = new Button();
            buttonStart = new Button();
            groupBox1 = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            button1 = new Button();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBoxIn = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(95, 57);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Добавить файл";
            toolTip1.SetToolTip(buttonOpenFile, "Выберети файл который необходимо загрузить");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(113, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 57);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Пуск";
            toolTip1.SetToolTip(buttonStart, "Запуск программы");
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(882, 53);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(467, 164);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(374, 444);
            textBoxOut.TabIndex = 4;
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
            // button1
            // 
            button1.Location = new Point(791, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 57);
            button1.TabIndex = 7;
            button1.Text = "Помощь";
            toolTip1.SetToolTip(button1, "Кто создал проект");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 134);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Вывод";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxIn);
            groupBox2.Location = new Point(3, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 480);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(9, 25);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(396, 449);
            textBoxIn.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 622);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBoxOut);
            Controls.Add(buttonStart);
            Controls.Add(groupBox1);
            Controls.Add(buttonOpenFile);
            Name = "FormMain";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenFile;
        private Button buttonStart;
        private GroupBox groupBox1;
        private TextBox textBoxOut;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox textBoxIn;
    }
}
