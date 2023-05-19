namespace Caminando_con_don_bosco
{
    partial class Juego_Don_Bosco_quiziz
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
            this.lblSegundo = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.Segundos = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDescontador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundo.ForeColor = System.Drawing.Color.White;
            this.lblSegundo.Location = new System.Drawing.Point(610, 378);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(27, 29);
            this.lblSegundo.TabIndex = 1;
            this.lblSegundo.Text = "3";
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIniciar.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(1116, 12);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(181, 64);
            this.BtnIniciar.TabIndex = 2;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Segundos
            // 
            this.Segundos.Tick += new System.EventHandler(this.Segundos_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDescontador
            // 
            this.lblDescontador.AutoSize = true;
            this.lblDescontador.BackColor = System.Drawing.Color.Transparent;
            this.lblDescontador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontador.ForeColor = System.Drawing.Color.White;
            this.lblDescontador.Location = new System.Drawing.Point(1010, 28);
            this.lblDescontador.Name = "lblDescontador";
            this.lblDescontador.Size = new System.Drawing.Size(41, 29);
            this.lblDescontador.TabIndex = 3;
            this.lblDescontador.Text = "60";
            // 
            // Juego_Don_Bosco_quiziz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caminando_con_don_bosco.Properties.Resources.Imagen_de_quiziz1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1321, 742);
            this.Controls.Add(this.lblDescontador);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.lblSegundo);
            this.Name = "Juego_Don_Bosco_quiziz";
            this.Text = "Juego_Don_Bosco_quiziz";
            this.Load += new System.EventHandler(this.Juego_Don_Bosco_quiziz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Timer Segundos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDescontador;
    }
}