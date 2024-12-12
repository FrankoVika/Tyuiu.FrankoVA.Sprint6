namespace Tyuiu.FrankoVA.Sprint6.Task7.V10
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOk = new Button();
            labelInfo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(481, 185);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(218, 83);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(290, 20);
            labelInfo.TabIndex = 4;
            labelInfo.Text = "Тут должна быть полезная информация";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(7, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 191);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 237);
            Controls.Add(buttonOk);
            Controls.Add(labelInfo);
            Controls.Add(pictureBox1);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Label labelInfo;
        private PictureBox pictureBox1;
    }
}