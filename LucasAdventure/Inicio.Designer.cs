namespace LucasAdventure
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lucas = new System.Windows.Forms.PictureBox();
            this.bocadillo = new System.Windows.Forms.PictureBox();
            this.texto_bocadillo = new System.Windows.Forms.Label();
            this.pista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo)).BeginInit();
            this.SuspendLayout();
            // 
            // lucas
            // 
            this.lucas.BackColor = System.Drawing.Color.Transparent;
            this.lucas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lucas.Image = ((System.Drawing.Image)(resources.GetObject("lucas.Image")));
            this.lucas.Location = new System.Drawing.Point(708, 12);
            this.lucas.Name = "lucas";
            this.lucas.Size = new System.Drawing.Size(564, 874);
            this.lucas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lucas.TabIndex = 0;
            this.lucas.TabStop = false;
            this.lucas.Click += new System.EventHandler(this.lucas_Click);
            this.lucas.MouseLeave += new System.EventHandler(this.lucas_MouseLeave);
            this.lucas.MouseHover += new System.EventHandler(this.lucas_MouseHover);
            // 
            // bocadillo
            // 
            this.bocadillo.BackColor = System.Drawing.Color.Transparent;
            this.bocadillo.Image = ((System.Drawing.Image)(resources.GetObject("bocadillo.Image")));
            this.bocadillo.Location = new System.Drawing.Point(67, 25);
            this.bocadillo.Name = "bocadillo";
            this.bocadillo.Size = new System.Drawing.Size(792, 346);
            this.bocadillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bocadillo.TabIndex = 1;
            this.bocadillo.TabStop = false;
            this.bocadillo.Visible = false;
            // 
            // texto_bocadillo
            // 
            this.texto_bocadillo.AutoSize = true;
            this.texto_bocadillo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_bocadillo.Location = new System.Drawing.Point(126, 75);
            this.texto_bocadillo.Name = "texto_bocadillo";
            this.texto_bocadillo.Size = new System.Drawing.Size(623, 145);
            this.texto_bocadillo.TabIndex = 2;
            this.texto_bocadillo.Text = resources.GetString("texto_bocadillo.Text");
            this.texto_bocadillo.Visible = false;
            // 
            // pista
            // 
            this.pista.AutoSize = true;
            this.pista.BackColor = System.Drawing.Color.Transparent;
            this.pista.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pista.Location = new System.Drawing.Point(26, 25);
            this.pista.Name = "pista";
            this.pista.Size = new System.Drawing.Size(403, 80);
            this.pista.TabIndex = 3;
            this.pista.Text = "Investiga el lugar, moviendo\r\nel ratón por toda la zona.\r\n";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1396, 705);
            this.Controls.Add(this.texto_bocadillo);
            this.Controls.Add(this.bocadillo);
            this.Controls.Add(this.lucas);
            this.Controls.Add(this.pista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "La Aventura de Lucas a través del tiempo";
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lucas;
        private System.Windows.Forms.PictureBox bocadillo;
        private System.Windows.Forms.Label texto_bocadillo;
        private System.Windows.Forms.Label pista;
    }
}