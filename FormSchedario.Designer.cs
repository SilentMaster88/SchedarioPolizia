namespace SchedarioPolizia
{
    partial class FormSchedario
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            this.components = new System.ComponentModel.Container();
            this.toolTipHelpSchedario = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxPersone = new System.Windows.Forms.GroupBox();
            this.buttonAccediPers = new System.Windows.Forms.Button();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.buttonAccediAuto = new System.Windows.Forms.Button();
            this.button1Closeall = new System.Windows.Forms.Button();
            this.groupBoxPersone.SuspendLayout();
            this.groupBoxAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersone
            // 
            this.groupBoxPersone.Controls.Add(this.buttonAccediPers);
            this.groupBoxPersone.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersone.Name = "groupBoxPersone";
            this.groupBoxPersone.Size = new System.Drawing.Size(153, 71);
            this.groupBoxPersone.TabIndex = 1;
            this.groupBoxPersone.TabStop = false;
            this.groupBoxPersone.Text = "SEZIONE PERSONE:";
            // 
            // buttonAccediPers
            // 
            this.buttonAccediPers.Location = new System.Drawing.Point(31, 28);
            this.buttonAccediPers.Name = "buttonAccediPers";
            this.buttonAccediPers.Size = new System.Drawing.Size(73, 31);
            this.buttonAccediPers.TabIndex = 3;
            this.buttonAccediPers.Text = "ACCEDI";
            this.buttonAccediPers.UseVisualStyleBackColor = true;
            this.buttonAccediPers.Click += new System.EventHandler(this.buttonAccediPers_Click);
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.Controls.Add(this.buttonAccediAuto);
            this.groupBoxAuto.Location = new System.Drawing.Point(236, 12);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Size = new System.Drawing.Size(200, 71);
            this.groupBoxAuto.TabIndex = 2;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "SEZIONE AUTO:";
            // 
            // buttonAccediAuto
            // 
            this.buttonAccediAuto.Location = new System.Drawing.Point(53, 28);
            this.buttonAccediAuto.Name = "buttonAccediAuto";
            this.buttonAccediAuto.Size = new System.Drawing.Size(73, 31);
            this.buttonAccediAuto.TabIndex = 4;
            this.buttonAccediAuto.Text = "ACCEDI";
            this.buttonAccediAuto.UseVisualStyleBackColor = true;
            this.buttonAccediAuto.Click += new System.EventHandler(this.buttonAccediAuto_Click);
            // 
            // button1Closeall
            // 
            this.button1Closeall.Location = new System.Drawing.Point(12, 193);
            this.button1Closeall.Name = "button1Closeall";
            this.button1Closeall.Size = new System.Drawing.Size(147, 31);
            this.button1Closeall.TabIndex = 4;
            this.button1Closeall.Text = "CHIUDI APPLICAZIONE";
            this.button1Closeall.UseVisualStyleBackColor = true;
            this.button1Closeall.Click += new System.EventHandler(this.button1Closeall_Click);
            // 
            // FormSchedario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 246);
            this.Controls.Add(this.button1Closeall);
            this.Controls.Add(this.groupBoxAuto);
            this.Controls.Add(this.groupBoxPersone);
            this.Name = "FormSchedario";
            this.Text = "SCHEDARIO";
            this.Load += new System.EventHandler(this.FormSchedario_Load);
            this.groupBoxPersone.ResumeLayout(false);
            this.groupBoxAuto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipHelpSchedario;
        private System.Windows.Forms.GroupBox groupBoxPersone;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.Button buttonAccediPers;
        private System.Windows.Forms.Button buttonAccediAuto;
        private System.Windows.Forms.Button button1Closeall;
    }
}

