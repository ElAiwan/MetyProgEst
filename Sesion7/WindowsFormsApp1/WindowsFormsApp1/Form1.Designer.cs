namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lbGrades = new System.Windows.Forms.ListBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAverage);
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.lbGrades);
            this.groupBox1.Controls.Add(this.tbGrade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Notas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Nota";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(150, 36);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(100, 22);
            this.tbGrade.TabIndex = 1;
            this.tbGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrade_KeyPress);
            // 
            // lbGrades
            // 
            this.lbGrades.FormattingEnabled = true;
            this.lbGrades.ItemHeight = 16;
            this.lbGrades.Location = new System.Drawing.Point(22, 78);
            this.lbGrades.Name = "lbGrades";
            this.lbGrades.Size = new System.Drawing.Size(228, 84);
            this.lbGrades.TabIndex = 2;
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(94, 169);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(169, 23);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Suma: 0";
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(91, 192);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(172, 23);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Promedio: 0";
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arreglos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.ListBox lbGrades;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label label1;
    }
}

