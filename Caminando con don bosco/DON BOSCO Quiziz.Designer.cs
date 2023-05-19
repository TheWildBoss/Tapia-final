namespace Caminando_con_don_bosco
{
    partial class DON_BOSCO_Quiziz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DON_BOSCO_Quiziz));
            this.LblDescontador = new System.Windows.Forms.Label();
            this.LblContador = new System.Windows.Forms.Label();
            this.TimerContador = new System.Windows.Forms.Timer(this.components);
            this.TimerDescontador = new System.Windows.Forms.Timer(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.LabelPregunta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDescontador
            // 
            this.LblDescontador.AutoSize = true;
            this.LblDescontador.BackColor = System.Drawing.Color.Transparent;
            this.LblDescontador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescontador.ForeColor = System.Drawing.Color.White;
            this.LblDescontador.Location = new System.Drawing.Point(1055, 21);
            this.LblDescontador.Name = "LblDescontador";
            this.LblDescontador.Size = new System.Drawing.Size(55, 39);
            this.LblDescontador.TabIndex = 0;
            this.LblDescontador.Text = "60";
            // 
            // LblContador
            // 
            this.LblContador.AutoSize = true;
            this.LblContador.BackColor = System.Drawing.Color.Transparent;
            this.LblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContador.ForeColor = System.Drawing.Color.White;
            this.LblContador.Location = new System.Drawing.Point(629, 234);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(69, 76);
            this.LblContador.TabIndex = 1;
            this.LblContador.Text = "3";
            // 
            // TimerContador
            // 
            this.TimerContador.Tick += new System.EventHandler(this.TimerContador_Tick);
            // 
            // TimerDescontador
            // 
            this.TimerDescontador.Tick += new System.EventHandler(this.TimerDescontador_Tick);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(1173, 15);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(172, 65);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // LabelPregunta
            // 
            this.LabelPregunta.AutoSize = true;
            this.LabelPregunta.BackColor = System.Drawing.Color.Transparent;
            this.LabelPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPregunta.ForeColor = System.Drawing.Color.White;
            this.LabelPregunta.Location = new System.Drawing.Point(295, 174);
            this.LabelPregunta.Name = "LabelPregunta";
            this.LabelPregunta.Size = new System.Drawing.Size(36, 54);
            this.LabelPregunta.TabIndex = 3;
            this.LabelPregunta.Text = ".";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 94);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(566, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 94);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(829, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 94);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(278, 489);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 89);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(566, 489);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 89);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(829, 489);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 89);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // DON_BOSCO_Quiziz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 787);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelPregunta);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.LblContador);
            this.Controls.Add(this.LblDescontador);
            this.Name = "DON_BOSCO_Quiziz";
            this.Text = "DON_BOSCO_Quiziz";
            this.Load += new System.EventHandler(this.DON_BOSCO_Quiziz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDescontador;
        private System.Windows.Forms.Label LblContador;
        private System.Windows.Forms.Timer TimerContador;
        private System.Windows.Forms.Timer TimerDescontador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label LabelPregunta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}