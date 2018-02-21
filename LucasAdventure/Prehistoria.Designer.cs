namespace LucasAdventure
{
    partial class Prehistoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prehistoria));
            this.nomada = new System.Windows.Forms.PictureBox();
            this.lucas = new System.Windows.Forms.PictureBox();
            this.mechero = new System.Windows.Forms.PictureBox();
            this.bocadillo1 = new System.Windows.Forms.PictureBox();
            this.texto_bocadillo1 = new System.Windows.Forms.Label();
            this.bocadillo2 = new System.Windows.Forms.PictureBox();
            this.texto_bocadillo2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLable = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.levelProgressLabel = new System.Windows.Forms.Label();
            this.puntuacionLable = new System.Windows.Forms.Label();
            this.tablet = new System.Windows.Forms.PictureBox();
            this.gatoSuertudo = new System.Windows.Forms.PictureBox();
            this.gafasSol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nomada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatoSuertudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gafasSol)).BeginInit();
            this.SuspendLayout();
            // 
            // nomada
            // 
            this.nomada.BackColor = System.Drawing.Color.Transparent;
            this.nomada.Image = ((System.Drawing.Image)(resources.GetObject("nomada.Image")));
            this.nomada.Location = new System.Drawing.Point(680, 269);
            this.nomada.Name = "nomada";
            this.nomada.Size = new System.Drawing.Size(438, 529);
            this.nomada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nomada.TabIndex = 1;
            this.nomada.TabStop = false;
            this.nomada.MouseLeave += new System.EventHandler(this.nomada_MouseLeave);
            this.nomada.MouseHover += new System.EventHandler(this.nomada_MouseHover);
            // 
            // lucas
            // 
            this.lucas.BackColor = System.Drawing.Color.Transparent;
            this.lucas.Image = ((System.Drawing.Image)(resources.GetObject("lucas.Image")));
            this.lucas.Location = new System.Drawing.Point(192, 249);
            this.lucas.Name = "lucas";
            this.lucas.Size = new System.Drawing.Size(96, 138);
            this.lucas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lucas.TabIndex = 2;
            this.lucas.TabStop = false;
            this.lucas.MouseLeave += new System.EventHandler(this.lucas_MouseLeave);
            this.lucas.MouseHover += new System.EventHandler(this.lucas_MouseHover);
            // 
            // mechero
            // 
            this.mechero.BackColor = System.Drawing.Color.Transparent;
            this.mechero.Image = ((System.Drawing.Image)(resources.GetObject("mechero.Image")));
            this.mechero.Location = new System.Drawing.Point(484, 472);
            this.mechero.Name = "mechero";
            this.mechero.Size = new System.Drawing.Size(39, 37);
            this.mechero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mechero.TabIndex = 3;
            this.mechero.TabStop = false;
            this.mechero.Click += new System.EventHandler(this.mechero_Click);
            // 
            // bocadillo1
            // 
            this.bocadillo1.BackColor = System.Drawing.Color.Transparent;
            this.bocadillo1.Image = ((System.Drawing.Image)(resources.GetObject("bocadillo1.Image")));
            this.bocadillo1.Location = new System.Drawing.Point(260, 159);
            this.bocadillo1.Name = "bocadillo1";
            this.bocadillo1.Size = new System.Drawing.Size(263, 140);
            this.bocadillo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bocadillo1.TabIndex = 4;
            this.bocadillo1.TabStop = false;
            this.bocadillo1.Visible = false;
            // 
            // texto_bocadillo1
            // 
            this.texto_bocadillo1.AutoSize = true;
            this.texto_bocadillo1.BackColor = System.Drawing.Color.White;
            this.texto_bocadillo1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_bocadillo1.Location = new System.Drawing.Point(293, 179);
            this.texto_bocadillo1.Name = "texto_bocadillo1";
            this.texto_bocadillo1.Size = new System.Drawing.Size(149, 57);
            this.texto_bocadillo1.TabIndex = 5;
            this.texto_bocadillo1.Text = "¡Bien ya llevas dos!, \r\nya faltan pocos\r\n¡Tu puedes!\r\n";
            this.texto_bocadillo1.Visible = false;
            // 
            // bocadillo2
            // 
            this.bocadillo2.BackColor = System.Drawing.Color.Transparent;
            this.bocadillo2.Image = ((System.Drawing.Image)(resources.GetObject("bocadillo2.Image")));
            this.bocadillo2.Location = new System.Drawing.Point(448, 179);
            this.bocadillo2.Name = "bocadillo2";
            this.bocadillo2.Size = new System.Drawing.Size(385, 208);
            this.bocadillo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bocadillo2.TabIndex = 6;
            this.bocadillo2.TabStop = false;
            this.bocadillo2.Visible = false;
            // 
            // texto_bocadillo2
            // 
            this.texto_bocadillo2.AutoSize = true;
            this.texto_bocadillo2.BackColor = System.Drawing.Color.White;
            this.texto_bocadillo2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_bocadillo2.Location = new System.Drawing.Point(479, 226);
            this.texto_bocadillo2.Name = "texto_bocadillo2";
            this.texto_bocadillo2.Size = new System.Drawing.Size(306, 54);
            this.texto_bocadillo2.TabIndex = 7;
            this.texto_bocadillo2.Text = "Mi familia, está entusiasmada \r\ncon sus nuevos descubrimientos.\r\n";
            this.texto_bocadillo2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLable
            // 
            this.timeLable.AutoSize = true;
            this.timeLable.BackColor = System.Drawing.Color.Transparent;
            this.timeLable.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLable.ForeColor = System.Drawing.Color.White;
            this.timeLable.Location = new System.Drawing.Point(1182, 42);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(64, 31);
            this.timeLable.TabIndex = 10;
            this.timeLable.Text = "15s";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressLabel.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.ForeColor = System.Drawing.Color.White;
            this.progressLabel.Location = new System.Drawing.Point(1069, 42);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(71, 31);
            this.progressLabel.TabIndex = 16;
            this.progressLabel.Text = "0/4";
            // 
            // levelProgressLabel
            // 
            this.levelProgressLabel.AutoSize = true;
            this.levelProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelProgressLabel.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelProgressLabel.ForeColor = System.Drawing.Color.White;
            this.levelProgressLabel.Location = new System.Drawing.Point(1084, 629);
            this.levelProgressLabel.Name = "levelProgressLabel";
            this.levelProgressLabel.Size = new System.Drawing.Size(162, 31);
            this.levelProgressLabel.TabIndex = 17;
            this.levelProgressLabel.Text = "Nivel 3/4";
            // 
            // puntuacionLable
            // 
            this.puntuacionLable.AutoSize = true;
            this.puntuacionLable.BackColor = System.Drawing.Color.Transparent;
            this.puntuacionLable.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionLable.ForeColor = System.Drawing.Color.White;
            this.puntuacionLable.Location = new System.Drawing.Point(68, 629);
            this.puntuacionLable.Name = "puntuacionLable";
            this.puntuacionLable.Size = new System.Drawing.Size(115, 31);
            this.puntuacionLable.TabIndex = 18;
            this.puntuacionLable.Text = "Puntos";
            // 
            // tablet
            // 
            this.tablet.BackColor = System.Drawing.Color.Transparent;
            this.tablet.Image = ((System.Drawing.Image)(resources.GetObject("tablet.Image")));
            this.tablet.Location = new System.Drawing.Point(205, 448);
            this.tablet.Name = "tablet";
            this.tablet.Size = new System.Drawing.Size(40, 50);
            this.tablet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tablet.TabIndex = 19;
            this.tablet.TabStop = false;
            this.tablet.Click += new System.EventHandler(this.tablet_Click);
            // 
            // gatoSuertudo
            // 
            this.gatoSuertudo.BackColor = System.Drawing.Color.Transparent;
            this.gatoSuertudo.Image = ((System.Drawing.Image)(resources.GetObject("gatoSuertudo.Image")));
            this.gatoSuertudo.Location = new System.Drawing.Point(738, 570);
            this.gatoSuertudo.Name = "gatoSuertudo";
            this.gatoSuertudo.Size = new System.Drawing.Size(47, 58);
            this.gatoSuertudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gatoSuertudo.TabIndex = 20;
            this.gatoSuertudo.TabStop = false;
            this.gatoSuertudo.Click += new System.EventHandler(this.gatoSuertudo_Click);
            // 
            // gafasSol
            // 
            this.gafasSol.BackColor = System.Drawing.Color.Transparent;
            this.gafasSol.Image = ((System.Drawing.Image)(resources.GetObject("gafasSol.Image")));
            this.gafasSol.Location = new System.Drawing.Point(1159, 269);
            this.gafasSol.Name = "gafasSol";
            this.gafasSol.Size = new System.Drawing.Size(50, 30);
            this.gafasSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gafasSol.TabIndex = 21;
            this.gafasSol.TabStop = false;
            this.gafasSol.Click += new System.EventHandler(this.gafasSol_Click);
            // 
            // Prehistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 690);
            this.Controls.Add(this.gafasSol);
            this.Controls.Add(this.gatoSuertudo);
            this.Controls.Add(this.tablet);
            this.Controls.Add(this.puntuacionLable);
            this.Controls.Add(this.levelProgressLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.timeLable);
            this.Controls.Add(this.texto_bocadillo2);
            this.Controls.Add(this.bocadillo2);
            this.Controls.Add(this.texto_bocadillo1);
            this.Controls.Add(this.bocadillo1);
            this.Controls.Add(this.mechero);
            this.Controls.Add(this.lucas);
            this.Controls.Add(this.nomada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prehistoria";
            this.Text = "Prehistoria";
            ((System.ComponentModel.ISupportInitialize)(this.nomada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mechero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatoSuertudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gafasSol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox nomada;
        private System.Windows.Forms.PictureBox lucas;
        private System.Windows.Forms.PictureBox mechero;
        private System.Windows.Forms.PictureBox bocadillo1;
        private System.Windows.Forms.Label texto_bocadillo1;
        private System.Windows.Forms.PictureBox bocadillo2;
        private System.Windows.Forms.Label texto_bocadillo2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label levelProgressLabel;
        private System.Windows.Forms.Label puntuacionLable;
        private System.Windows.Forms.PictureBox tablet;
        private System.Windows.Forms.PictureBox gatoSuertudo;
        private System.Windows.Forms.PictureBox gafasSol;
    }
}