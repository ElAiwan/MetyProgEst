namespace Sesion5_Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumber2 = new System.Windows.Forms.TextBox();
            this.btnMayor = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnMenor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.showDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(110, 19);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(100, 22);
            this.tbNumber1.TabIndex = 2;
            this.tbNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNumber2
            // 
            this.tbNumber2.Location = new System.Drawing.Point(110, 56);
            this.tbNumber2.Name = "tbNumber2";
            this.tbNumber2.Size = new System.Drawing.Size(100, 22);
            this.tbNumber2.TabIndex = 3;
            this.tbNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(110, 117);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(111, 23);
            this.btnMayor.TabIndex = 4;
            this.btnMayor.Text = "Evaluar Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(15, 241);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(398, 125);
            this.lblAnswer.TabIndex = 5;
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(110, 155);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(111, 23);
            this.btnMenor.TabIndex = 6;
            this.btnMenor.Text = "Evaluar Menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Evaluar Menor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Evaluar Mayor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showDay
            // 
            this.showDay.Location = new System.Drawing.Point(239, 185);
            this.showDay.Name = "showDay";
            this.showDay.Size = new System.Drawing.Size(111, 23);
            this.showDay.TabIndex = 9;
            this.showDay.Text = "Evaluar Día";
            this.showDay.UseVisualStyleBackColor = true;
            this.showDay.Click += new System.EventHandler(this.showDay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.showDay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.tbNumber2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesión 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumber2;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button showDay;
    }
}

