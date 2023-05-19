namespace Caminando_con_don_bosco
{
    partial class Menu_Tenis
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
            this.BTN_Retroceder = new System.Windows.Forms.PictureBox();
            this.BTN_Start = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Retroceder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Retroceder
            // 
            this.BTN_Retroceder.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Retroceder.Image = global::Caminando_con_don_bosco.Properties.Resources.WhatsApp_Image_2023_03_27_at_10_18_18_PM_removebg_preview;
            this.BTN_Retroceder.Location = new System.Drawing.Point(0, 339);
            this.BTN_Retroceder.Name = "BTN_Retroceder";
            this.BTN_Retroceder.Size = new System.Drawing.Size(129, 116);
            this.BTN_Retroceder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_Retroceder.TabIndex = 26;
            this.BTN_Retroceder.TabStop = false;
            this.BTN_Retroceder.Click += new System.EventHandler(this.BTN_Retroceder_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Start.Image = global::Caminando_con_don_bosco.Properties.Resources.start;
            this.BTN_Start.Location = new System.Drawing.Point(225, 116);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(195, 173);
            this.BTN_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_Start.TabIndex = 27;
            this.BTN_Start.TabStop = false;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // Menu_Tenis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caminando_con_don_bosco.Properties.Resources.Tenis_de_mesa_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 439);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_Retroceder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Menu_Tenis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Tenis";
            this.Load += new System.EventHandler(this.Menu_Tenis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Retroceder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BTN_Retroceder;
        private System.Windows.Forms.PictureBox BTN_Start;
    }
}