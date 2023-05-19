namespace Caminando_con_don_bosco
{
    partial class Juego_Tenis
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
            this.Pic_User = new System.Windows.Forms.PictureBox();
            this.Pic_Pelota = new System.Windows.Forms.PictureBox();
            this.TM_Pelota = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Pelota)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_User
            // 
            this.Pic_User.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Pic_User.Location = new System.Drawing.Point(750, 12);
            this.Pic_User.Name = "Pic_User";
            this.Pic_User.Size = new System.Drawing.Size(10, 85);
            this.Pic_User.TabIndex = 0;
            this.Pic_User.TabStop = false;
            // 
            // Pic_Pelota
            // 
            this.Pic_Pelota.BackColor = System.Drawing.Color.Transparent;
            this.Pic_Pelota.Image = global::Caminando_con_don_bosco.Properties.Resources.pelota;
            this.Pic_Pelota.Location = new System.Drawing.Point(64, 100);
            this.Pic_Pelota.Name = "Pic_Pelota";
            this.Pic_Pelota.Size = new System.Drawing.Size(29, 27);
            this.Pic_Pelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Pelota.TabIndex = 1;
            this.Pic_Pelota.TabStop = false;
            this.Pic_Pelota.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TM_Pelota
            // 
            this.TM_Pelota.Enabled = true;
            this.TM_Pelota.Tick += new System.EventHandler(this.TM_Pelota_Tick);
            // 
            // Juego_Tenis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Caminando_con_don_bosco.Properties.Resources.mesa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 456);
            this.Controls.Add(this.Pic_Pelota);
            this.Controls.Add(this.Pic_User);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(772, 495);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(772, 495);
            this.Name = "Juego_Tenis";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tenis de mesa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_Tenis_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Tenis_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Juego_Tenis_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Pelota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_User;
        private System.Windows.Forms.PictureBox Pic_Pelota;
        private System.Windows.Forms.Timer TM_Pelota;
    }
}