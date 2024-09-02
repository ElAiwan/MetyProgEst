namespace Sesion4
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
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.nudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAumentar
            // 
            this.btnAumentar.Location = new System.Drawing.Point(298, 60);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(125, 59);
            this.btnAumentar.TabIndex = 0;
            this.btnAumentar.Text = "+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Location = new System.Drawing.Point(298, 125);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(125, 57);
            this.btnDisminuir.TabIndex = 1;
            this.btnDisminuir.Text = "-";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // nudPorcentaje
            // 
            this.nudPorcentaje.Location = new System.Drawing.Point(298, 226);
            this.nudPorcentaje.Name = "nudPorcentaje";
            this.nudPorcentaje.Size = new System.Drawing.Size(120, 27);
            this.nudPorcentaje.TabIndex = 2;
            this.nudPorcentaje.ValueChanged += new System.EventHandler(this.nudPorcentaje_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(245, 290);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(433, 534);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.nudPorcentaje);
            this.Controls.Add(this.btnDisminuir);
            this.Controls.Add(this.btnAumentar);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.Text = "Ejemplo1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

