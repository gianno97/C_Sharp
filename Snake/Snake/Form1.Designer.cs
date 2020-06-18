namespace SnakeDefinitiveEdition
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giocaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovaPartitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conIBordiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senzaBordiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aiutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 530);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giocaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giocaToolStripMenuItem
            // 
            this.giocaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovaPartitaToolStripMenuItem,
            this.pausaToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.giocaToolStripMenuItem.Name = "giocaToolStripMenuItem";
            this.giocaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.giocaToolStripMenuItem.Text = "Gioca";
            // 
            // nuovaPartitaToolStripMenuItem
            // 
            this.nuovaPartitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conIBordiToolStripMenuItem,
            this.senzaBordiToolStripMenuItem});
            this.nuovaPartitaToolStripMenuItem.Name = "nuovaPartitaToolStripMenuItem";
            this.nuovaPartitaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.nuovaPartitaToolStripMenuItem.Text = "Nuova Partita";
            // 
            // conIBordiToolStripMenuItem
            // 
            this.conIBordiToolStripMenuItem.Name = "conIBordiToolStripMenuItem";
            this.conIBordiToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.conIBordiToolStripMenuItem.Text = "Con i bordi";
            this.conIBordiToolStripMenuItem.Click += new System.EventHandler(this.conIBordiToolStripMenuItem_Click);
            // 
            // senzaBordiToolStripMenuItem
            // 
            this.senzaBordiToolStripMenuItem.Name = "senzaBordiToolStripMenuItem";
            this.senzaBordiToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.senzaBordiToolStripMenuItem.Text = "Senza bordi";
            // 
            // pausaToolStripMenuItem
            // 
            this.pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            this.pausaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pausaToolStripMenuItem.Text = "Pausa";
            this.pausaToolStripMenuItem.Click += new System.EventHandler(this.pausaToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classificaToolStripMenuItem,
            this.comandiToolStripMenuItem,
            this.aiutoToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // classificaToolStripMenuItem
            // 
            this.classificaToolStripMenuItem.Name = "classificaToolStripMenuItem";
            this.classificaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.classificaToolStripMenuItem.Text = "Classifica";
            // 
            // comandiToolStripMenuItem
            // 
            this.comandiToolStripMenuItem.Name = "comandiToolStripMenuItem";
            this.comandiToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.comandiToolStripMenuItem.Text = "Comandi";
            // 
            // aiutoToolStripMenuItem
            // 
            this.aiutoToolStripMenuItem.Name = "aiutoToolStripMenuItem";
            this.aiutoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aiutoToolStripMenuItem.Text = "Aiuto";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(56, 38);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "label2";
            this.labelScore.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 607);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem giocaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovaPartitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conIBordiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senzaBordiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aiutoToolStripMenuItem;
        private System.Windows.Forms.Label labelScore;
    }
}

