namespace etec.consultorio
{
    partial class Consultório
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlblLogin = new System.Windows.Forms.ToolStripLabel();
            this.tlblCadastrar = new System.Windows.Forms.ToolStripLabel();
            this.tlblMedico = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblLogin,
            this.tlblCadastrar,
            this.tlblMedico});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlblLogin
            // 
            this.tlblLogin.Name = "tlblLogin";
            this.tlblLogin.Size = new System.Drawing.Size(37, 22);
            this.tlblLogin.Text = "Login";
            this.tlblLogin.Click += new System.EventHandler(this.tlblLogin_Click);
            // 
            // tlblCadastrar
            // 
            this.tlblCadastrar.Name = "tlblCadastrar";
            this.tlblCadastrar.Size = new System.Drawing.Size(57, 22);
            this.tlblCadastrar.Text = "Cadastrar";
            this.tlblCadastrar.Click += new System.EventHandler(this.tlblCadastrar_Click);
            // 
            // tlblMedico
            // 
            this.tlblMedico.Name = "tlblMedico";
            this.tlblMedico.Size = new System.Drawing.Size(47, 22);
            this.tlblMedico.Text = "Medico";
            this.tlblMedico.Click += new System.EventHandler(this.tlblMedico_Click);
            // 
            // Consultório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 530);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Consultório";
            this.Text = "Consultório";
            this.Load += new System.EventHandler(this.Consultório_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tlblLogin;
        private System.Windows.Forms.ToolStripLabel tlblCadastrar;
        private System.Windows.Forms.ToolStripLabel tlblMedico;
    }
}

