namespace Caminando_con_don_bosco
{
    partial class Juegos_Don_Bosco_memoria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juegos_Don_Bosco_memoria));
            this.button1 = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.N_Record = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1594, -80);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 57);
            this.button1.TabIndex = 18;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnReinicio
            // 
            this.btnReinicio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicio.Location = new System.Drawing.Point(1251, 384);
            this.btnReinicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(354, 69);
            this.btnReinicio.TabIndex = 17;
            this.btnReinicio.Text = "Reinicio de Juego";
            this.btnReinicio.UseVisualStyleBackColor = false;
            // 
            // N_Record
            // 
            this.N_Record.AutoSize = true;
            this.N_Record.BackColor = System.Drawing.Color.Transparent;
            this.N_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Record.Location = new System.Drawing.Point(1407, 284);
            this.N_Record.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.N_Record.Name = "N_Record";
            this.N_Record.Size = new System.Drawing.Size(43, 46);
            this.N_Record.TabIndex = 16;
            this.N_Record.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1319, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Record:";
            // 
            // PanelJuego
            // 
            this.PanelJuego.Location = new System.Drawing.Point(51, 32);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(1166, 604);
            this.PanelJuego.TabIndex = 19;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 500;
            // 
            // Juegos_Don_Bosco_memoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1638, 686);
            this.Controls.Add(this.PanelJuego);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.N_Record);
            this.Controls.Add(this.label1);
            this.Name = "Juegos_Don_Bosco_memoria";
            this.Text = "Juegos_Don_Bosco_memoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Label N_Record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Timer Timer1;
    }
}