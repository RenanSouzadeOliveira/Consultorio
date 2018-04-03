namespace etec.consultorio
{
    partial class Medico
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
            this.lblsenM = new System.Windows.Forms.Label();
            this.lblesp = new System.Windows.Forms.Label();
            this.lblcrm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsenM
            // 
            this.lblsenM.AutoSize = true;
            this.lblsenM.Location = new System.Drawing.Point(24, 121);
            this.lblsenM.Name = "lblsenM";
            this.lblsenM.Size = new System.Drawing.Size(38, 13);
            this.lblsenM.TabIndex = 0;
            this.lblsenM.Text = "Senha";
            // 
            // lblesp
            // 
            this.lblesp.AutoSize = true;
            this.lblesp.Location = new System.Drawing.Point(24, 47);
            this.lblesp.Name = "lblesp";
            this.lblesp.Size = new System.Drawing.Size(73, 13);
            this.lblesp.TabIndex = 1;
            this.lblesp.Text = "Especialidade";
            // 
            // lblcrm
            // 
            this.lblcrm.AutoSize = true;
            this.lblcrm.Location = new System.Drawing.Point(24, 84);
            this.lblcrm.Name = "lblcrm";
            this.lblcrm.Size = new System.Drawing.Size(31, 13);
            this.lblcrm.TabIndex = 2;
            this.lblcrm.Text = "CRM";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(158, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 244);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblcrm);
            this.Controls.Add(this.lblesp);
            this.Controls.Add(this.lblsenM);
            this.Name = "Medico";
            this.Text = "Médico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsenM;
        private System.Windows.Forms.Label lblesp;
        private System.Windows.Forms.Label lblcrm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSalvar;
    }
}