namespace Tyuiu.FrankoVA.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button1 = new Button();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            label3 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(76, 376);
            button1.Name = "button1";
            button1.Size = new Size(143, 48);
            button1.TabIndex = 6;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(16, 265);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(299, 105);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 49);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 1;
            label4.Text = "Конец";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 49);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Старт";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 232);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 0;
            label2.Text = "Результат вывести в таблице";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chart1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(321, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 406);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridView1.Location = new Point(6, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(153, 324);
            dataGridView1.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F";
            F.MinimumWidth = 6;
            F.Name = "F";
            F.Width = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 35);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 0;
            label3.Text = "Результат";
            // 
            // chart1
            // 
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(165, 26);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(469, 356);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 450);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
