namespace CalculadoraVolume
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputUser = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            labelCm3 = new Label();
            labelL = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)inputUser).BeginInit();
            SuspendLayout();
            // 
            // inputUser
            // 
            inputUser.DecimalPlaces = 1;
            inputUser.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            inputUser.Location = new Point(82, 104);
            inputUser.Maximum = new decimal(new int[] { 1297, 0, 0, 65536 });
            inputUser.Name = "inputUser";
            inputUser.Size = new Size(110, 23);
            inputUser.TabIndex = 0;
            inputUser.TextAlign = HorizontalAlignment.Center;
            inputUser.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(249, 25);
            label2.TabIndex = 2;
            label2.Text = "CALCULADORA DE VOLUME";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(82, 81);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "ALTURA (cm)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(82, 145);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 4;
            label3.Text = "VOLUME";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCm3
            // 
            labelCm3.BorderStyle = BorderStyle.FixedSingle;
            labelCm3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCm3.ForeColor = SystemColors.ActiveCaptionText;
            labelCm3.Location = new Point(82, 174);
            labelCm3.Name = "labelCm3";
            labelCm3.Padding = new Padding(3);
            labelCm3.Size = new Size(110, 30);
            labelCm3.TabIndex = 5;
            labelCm3.Text = "0,0 cm³";
            labelCm3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelL
            // 
            labelL.BorderStyle = BorderStyle.FixedSingle;
            labelL.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelL.ForeColor = SystemColors.ActiveCaptionText;
            labelL.Location = new Point(82, 213);
            labelL.Name = "labelL";
            labelL.Padding = new Padding(3);
            labelL.Size = new Size(110, 30);
            labelL.TabIndex = 7;
            labelL.Text = "0,000 L";
            labelL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(99, 251);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "GRÁFICO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(247, 262);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(31, 12);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "alunos";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(276, 278);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(labelL);
            Controls.Add(labelCm3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(inputUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(292, 317);
            MinimumSize = new Size(292, 317);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atividade-Calculo1";
            ((System.ComponentModel.ISupportInitialize)inputUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown inputUser;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label labelCm3;
        private Label labelL;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}
