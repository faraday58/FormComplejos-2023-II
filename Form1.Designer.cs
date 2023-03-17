namespace FormComplejos_2023_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtbRealC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtbImC1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbRealC2 = new System.Windows.Forms.TextBox();
            this.txtbImC2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOperar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbRealC1
            // 
            this.txtbRealC1.Location = new System.Drawing.Point(40, 54);
            this.txtbRealC1.Name = "txtbRealC1";
            this.txtbRealC1.Size = new System.Drawing.Size(40, 20);
            this.txtbRealC1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(398, 58);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(27, 13);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "0+0i";
            // 
            // txtbImC1
            // 
            this.txtbImC1.Location = new System.Drawing.Point(110, 54);
            this.txtbImC1.Name = "txtbImC1";
            this.txtbImC1.Size = new System.Drawing.Size(40, 20);
            this.txtbImC1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "i";
            // 
            // txtbRealC2
            // 
            this.txtbRealC2.Location = new System.Drawing.Point(213, 55);
            this.txtbRealC2.Name = "txtbRealC2";
            this.txtbRealC2.Size = new System.Drawing.Size(40, 20);
            this.txtbRealC2.TabIndex = 0;
            // 
            // txtbImC2
            // 
            this.txtbImC2.Location = new System.Drawing.Point(291, 55);
            this.txtbImC2.Name = "txtbImC2";
            this.txtbImC2.Size = new System.Drawing.Size(40, 20);
            this.txtbImC2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(9, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "i";
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(480, 38);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(75, 53);
            this.btnOperar.TabIndex = 2;
            this.btnOperar.Text = "Sumar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 148);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbImC2);
            this.Controls.Add(this.txtbRealC2);
            this.Controls.Add(this.txtbImC1);
            this.Controls.Add(this.txtbRealC1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbRealC1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtbImC1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbRealC2;
        private System.Windows.Forms.TextBox txtbImC2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

