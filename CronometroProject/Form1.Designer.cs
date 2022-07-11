namespace CronometroProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblCronom = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnPausar = new System.Windows.Forms.Button();
            this.BtnResetar = new System.Windows.Forms.Button();
            this.TimerUnic = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblCronom
            // 
            resources.ApplyResources(this.LblCronom, "LblCronom");
            this.LblCronom.ForeColor = System.Drawing.Color.Black;
            this.LblCronom.Name = "LblCronom";
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BtnFechar, "BtnFechar");
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.BtnIniciar, "BtnIniciar");
            this.BtnIniciar.ForeColor = System.Drawing.Color.Black;
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnPausar
            // 
            this.BtnPausar.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.BtnPausar, "BtnPausar");
            this.BtnPausar.ForeColor = System.Drawing.Color.Black;
            this.BtnPausar.Name = "BtnPausar";
            this.BtnPausar.UseVisualStyleBackColor = false;
            this.BtnPausar.Click += new System.EventHandler(this.BtnPausar_Click);
            // 
            // BtnResetar
            // 
            this.BtnResetar.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.BtnResetar, "BtnResetar");
            this.BtnResetar.ForeColor = System.Drawing.Color.Black;
            this.BtnResetar.Name = "BtnResetar";
            this.BtnResetar.UseVisualStyleBackColor = false;
            this.BtnResetar.Click += new System.EventHandler(this.BtnResetar_Click);
            // 
            // TimerUnic
            // 
            this.TimerUnic.Enabled = true;
            this.TimerUnic.Tick += new System.EventHandler(this.TimerUnic_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnResetar);
            this.Controls.Add(this.BtnPausar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.LblCronom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblCronom;
        private Button BtnFechar;
        private Button BtnIniciar;
        private Button BtnPausar;
        private Button BtnResetar;
        private System.Windows.Forms.Timer TimerUnic;
    }
}