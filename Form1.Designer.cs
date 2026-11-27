namespace progetto_conti
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lst_1 = new System.Windows.Forms.ListBox();
            this.lst_2 = new System.Windows.Forms.ListBox();
            this.lst_3 = new System.Windows.Forms.ListBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_1.Location = new System.Drawing.Point(282, 9);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(248, 29);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "CONTI CORRENTI";
            // 
            // lst_1
            // 
            this.lst_1.FormattingEnabled = true;
            this.lst_1.Location = new System.Drawing.Point(98, 146);
            this.lst_1.Name = "lst_1";
            this.lst_1.Size = new System.Drawing.Size(120, 95);
            this.lst_1.TabIndex = 1;
            // 
            // lst_2
            // 
            this.lst_2.FormattingEnabled = true;
            this.lst_2.Location = new System.Drawing.Point(318, 146);
            this.lst_2.Name = "lst_2";
            this.lst_2.Size = new System.Drawing.Size(120, 95);
            this.lst_2.TabIndex = 2;
            // 
            // lst_3
            // 
            this.lst_3.FormattingEnabled = true;
            this.lst_3.Location = new System.Drawing.Point(530, 146);
            this.lst_3.Name = "lst_3";
            this.lst_3.Size = new System.Drawing.Size(120, 95);
            this.lst_3.TabIndex = 3;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(98, 97);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(87, 32);
            this.btn_1.TabIndex = 7;
            this.btn_1.Text = "PREMI NOME";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.lst_3);
            this.Controls.Add(this.lst_2);
            this.Controls.Add(this.lst_1);
            this.Controls.Add(this.lbl_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.ListBox lst_1;
        private System.Windows.Forms.ListBox lst_2;
        private System.Windows.Forms.ListBox lst_3;
        private System.Windows.Forms.Button btn_1;
    }
}

