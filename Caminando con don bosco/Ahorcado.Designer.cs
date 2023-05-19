namespace Caminando_con_don_bosco
{
    partial class Ahorcado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ahorcado));
            this.flFichasDeJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarJuego = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichasDeJuego
            // 
            this.flFichasDeJuego.Location = new System.Drawing.Point(12, 110);
            this.flFichasDeJuego.Name = "flFichasDeJuego";
            this.flFichasDeJuego.Size = new System.Drawing.Size(843, 496);
            this.flFichasDeJuego.TabIndex = 0;
            this.flFichasDeJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(226, 612);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(751, 154);
            this.flPalabra.TabIndex = 1;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMensaje.Location = new System.Drawing.Point(901, 38);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(285, 46);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "¡Tú lo mataste!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adivina la palabra o Stich muere!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarJuego.Image")));
            this.btnIniciarJuego.Location = new System.Drawing.Point(993, 612);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(225, 154);
            this.btnIniciarJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIniciarJuego.TabIndex = 3;
            this.btnIniciarJuego.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Caminando_con_don_bosco.Properties.Resources.malo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 547);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picAhorcado
            // 
            this.picAhorcado.Location = new System.Drawing.Point(861, 110);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(357, 496);
            this.picAhorcado.TabIndex = 0;
            this.picAhorcado.TabStop = false;
            this.picAhorcado.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ahorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1230, 764);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.flFichasDeJuego);
            this.Name = "Ahorcado";
            this.Text = "Ahorcado";
            this.Load += new System.EventHandler(this.Ahorcado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flFichasDeJuego;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnIniciarJuego;
    }
}