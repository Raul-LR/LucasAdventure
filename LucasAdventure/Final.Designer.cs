namespace LucasAdventure
{
    partial class Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Final));
            this.lucas = new System.Windows.Forms.PictureBox();
            this.bocadillo = new System.Windows.Forms.PictureBox();
            this.texto_bocadillo = new System.Windows.Forms.Label();
            this.fin = new System.Windows.Forms.Label();
            this.puntuacionFinalLable = new System.Windows.Forms.Label();
            this.puntuacionesButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo)).BeginInit();
            this.SuspendLayout();
            // 
            // lucas
            // 
            this.lucas.BackColor = System.Drawing.Color.Transparent;
            this.lucas.Image = ((System.Drawing.Image)(resources.GetObject("lucas.Image")));
            this.lucas.Location = new System.Drawing.Point(32, -49);
            this.lucas.Name = "lucas";
            this.lucas.Size = new System.Drawing.Size(685, 977);
            this.lucas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lucas.TabIndex = 0;
            this.lucas.TabStop = false;
            // 
            // bocadillo
            // 
            this.bocadillo.BackColor = System.Drawing.Color.Transparent;
            this.bocadillo.Image = ((System.Drawing.Image)(resources.GetObject("bocadillo.Image")));
            this.bocadillo.Location = new System.Drawing.Point(510, 12);
            this.bocadillo.Name = "bocadillo";
            this.bocadillo.Size = new System.Drawing.Size(838, 347);
            this.bocadillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bocadillo.TabIndex = 1;
            this.bocadillo.TabStop = false;
            // 
            // texto_bocadillo
            // 
            this.texto_bocadillo.AutoSize = true;
            this.texto_bocadillo.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_bocadillo.Location = new System.Drawing.Point(589, 72);
            this.texto_bocadillo.Name = "texto_bocadillo";
            this.texto_bocadillo.Size = new System.Drawing.Size(531, 140);
            this.texto_bocadillo.TabIndex = 2;
            this.texto_bocadillo.Text = "¡Enhorabuena! has llegado al final y \r\nhas conseguido muchos o todos\r\nlos objetos" +
    ". Gracias a tí hemos conseguido\r\n salvar el tiempo. ¡Hasta pronto, nos vemos!";
            // 
            // fin
            // 
            this.fin.AutoSize = true;
            this.fin.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fin.Location = new System.Drawing.Point(889, 473);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(254, 80);
            this.fin.TabIndex = 3;
            this.fin.Text = "Fin\r\nGracias por jugar\r\n";
            this.fin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puntuacionFinalLable
            // 
            this.puntuacionFinalLable.AutoSize = true;
            this.puntuacionFinalLable.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionFinalLable.Location = new System.Drawing.Point(49, 33);
            this.puntuacionFinalLable.Name = "puntuacionFinalLable";
            this.puntuacionFinalLable.Size = new System.Drawing.Size(255, 31);
            this.puntuacionFinalLable.TabIndex = 4;
            this.puntuacionFinalLable.Text = "Puntuación final";
            // 
            // puntuacionesButton
            // 
            this.puntuacionesButton.Location = new System.Drawing.Point(964, 447);
            this.puntuacionesButton.Name = "puntuacionesButton";
            this.puntuacionesButton.Size = new System.Drawing.Size(119, 23);
            this.puntuacionesButton.TabIndex = 5;
            this.puntuacionesButton.Text = "Puntuaciones";
            this.puntuacionesButton.UseVisualStyleBackColor = true;
            this.puntuacionesButton.Click += new System.EventHandler(this.puntuacionesButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(929, 568);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(191, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Volver a jugar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 652);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.puntuacionesButton);
            this.Controls.Add(this.puntuacionFinalLable);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.texto_bocadillo);
            this.Controls.Add(this.bocadillo);
            this.Controls.Add(this.lucas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Final";
            this.Text = "Final";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Final_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lucas;
        private System.Windows.Forms.PictureBox bocadillo;
        private System.Windows.Forms.Label texto_bocadillo;
        private System.Windows.Forms.Label fin;
        private System.Windows.Forms.Label puntuacionFinalLable;
        private System.Windows.Forms.Button puntuacionesButton;
        private System.Windows.Forms.Button backButton;
    }
}