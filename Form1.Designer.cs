namespace ImpresionFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRutaDir = new System.Windows.Forms.TextBox();
            this.btnBuscarDir = new System.Windows.Forms.Button();
            this.lblRutaDir = new System.Windows.Forms.Label();
            this.btnApilar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtRutaDir
            // 
            resources.ApplyResources(this.txtRutaDir, "txtRutaDir");
            this.txtRutaDir.Name = "txtRutaDir";
            // 
            // btnBuscarDir
            // 
            resources.ApplyResources(this.btnBuscarDir, "btnBuscarDir");
            this.btnBuscarDir.Name = "btnBuscarDir";
            this.btnBuscarDir.UseVisualStyleBackColor = true;
            this.btnBuscarDir.Click += new System.EventHandler(this.btnBuscarDir_Click);
            // 
            // lblRutaDir
            // 
            resources.ApplyResources(this.lblRutaDir, "lblRutaDir");
            this.lblRutaDir.Name = "lblRutaDir";
            // 
            // btnApilar
            // 
            resources.ApplyResources(this.btnApilar, "btnApilar");
            this.btnApilar.Name = "btnApilar";
            this.btnApilar.UseVisualStyleBackColor = true;
            this.btnApilar.Click += new System.EventHandler(this.btnApilar_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnApilar);
            this.Controls.Add(this.lblRutaDir);
            this.Controls.Add(this.btnBuscarDir);
            this.Controls.Add(this.txtRutaDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRutaDir;
        private System.Windows.Forms.Button btnBuscarDir;
        private System.Windows.Forms.Label lblRutaDir;
        private System.Windows.Forms.Button btnApilar;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

