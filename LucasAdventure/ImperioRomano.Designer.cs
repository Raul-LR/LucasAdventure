namespace LucasAdventure
{
    partial class ImperioRomano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImperioRomano));
            this.romano = new System.Windows.Forms.PictureBox();
            this.lucas = new System.Windows.Forms.PictureBox();
            this.antena = new System.Windows.Forms.PictureBox();
            this.bocadillo = new System.Windows.Forms.PictureBox();
            this.texto_bocadillo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLable = new System.Windows.Forms.Label();
            this.puntuacionLable = new System.Windows.Forms.Label();
            this.levelProgressLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.avion = new System.Windows.Forms.PictureBox();
            this.ventilador = new System.Windows.Forms.PictureBox();
            this.signal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.romano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signal)).BeginInit();
            this.SuspendLayout();
            // 
            // romano
            // 
            this.romano.BackColor = System.Drawing.Color.Transparent;
            this.romano.Image = ((System.Drawing.Image)(resources.GetObject("romano.Image")));
            this.romano.Location = new System.Drawing.Point(321, 312);
            this.romano.Name = "romano";
            this.romano.Size = new System.Drawing.Size(335, 420);
            this.romano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.romano.TabIndex = 1;
            this.romano.TabStop = false;
            this.romano.MouseLeave += new System.EventHandler(this.romano_MouseLeave);
            this.romano.MouseHover += new System.EventHandler(this.romano_MouseHover);
            // 
            // lucas
            // 
            this.lucas.BackColor = System.Drawing.Color.Transparent;
            this.lucas.Image = ((System.Drawing.Image)(resources.GetObject("lucas.Image")));
            this.lucas.Location = new System.Drawing.Point(1092, 349);
            this.lucas.Name = "lucas";
            this.lucas.Size = new System.Drawing.Size(110, 168);
            this.lucas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lucas.TabIndex = 2;
            this.lucas.TabStop = false;
            // 
            // antena
            // 
            this.antena.BackColor = System.Drawing.Color.Transparent;
            this.antena.Image = ((System.Drawing.Image)(resources.GetObject("antena.Image")));
            this.antena.Location = new System.Drawing.Point(321, 212);
            this.antena.Name = "antena";
            this.antena.Size = new System.Drawing.Size(34, 30);
            this.antena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.antena.TabIndex = 3;
            this.antena.TabStop = false;
            this.antena.Click += new System.EventHandler(this.antena_Click);
            // 
            // bocadillo
            // 
            this.bocadillo.BackColor = System.Drawing.Color.Transparent;
            this.bocadillo.Image = ((System.Drawing.Image)(resources.GetObject("bocadillo.Image")));
            this.bocadillo.Location = new System.Drawing.Point(558, 212);
            this.bocadillo.Name = "bocadillo";
            this.bocadillo.Size = new System.Drawing.Size(370, 223);
            this.bocadillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bocadillo.TabIndex = 4;
            this.bocadillo.TabStop = false;
            this.bocadillo.Visible = false;
            // 
            // texto_bocadillo
            // 
            this.texto_bocadillo.AutoSize = true;
            this.texto_bocadillo.BackColor = System.Drawing.Color.White;
            this.texto_bocadillo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_bocadillo.Location = new System.Drawing.Point(589, 275);
            this.texto_bocadillo.Name = "texto_bocadillo";
            this.texto_bocadillo.Size = new System.Drawing.Size(256, 25);
            this.texto_bocadillo.TabIndex = 5;
            this.texto_bocadillo.Text = "¡Que extraños ropajes llevaís!";
            this.texto_bocadillo.Visible = false;
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
            this.timeLable.Location = new System.Drawing.Point(1250, 39);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(64, 31);
            this.timeLable.TabIndex = 9;
            this.timeLable.Text = "15s";
            // 
            // puntuacionLable
            // 
            this.puntuacionLable.AutoSize = true;
            this.puntuacionLable.BackColor = System.Drawing.Color.Transparent;
            this.puntuacionLable.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionLable.Location = new System.Drawing.Point(78, 653);
            this.puntuacionLable.Name = "puntuacionLable";
            this.puntuacionLable.Size = new System.Drawing.Size(115, 31);
            this.puntuacionLable.TabIndex = 13;
            this.puntuacionLable.Text = "Puntos";
            // 
            // levelProgressLabel
            // 
            this.levelProgressLabel.AutoSize = true;
            this.levelProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelProgressLabel.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelProgressLabel.Location = new System.Drawing.Point(1153, 653);
            this.levelProgressLabel.Name = "levelProgressLabel";
            this.levelProgressLabel.Size = new System.Drawing.Size(161, 31);
            this.levelProgressLabel.TabIndex = 14;
            this.levelProgressLabel.Text = "Nivel 2/4";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressLabel.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(1131, 39);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(71, 31);
            this.progressLabel.TabIndex = 15;
            this.progressLabel.Text = "0/4";
            // 
            // avion
            // 
            this.avion.BackColor = System.Drawing.Color.Transparent;
            this.avion.Image = ((System.Drawing.Image)(resources.GetObject("avion.Image")));
            this.avion.Location = new System.Drawing.Point(843, 101);
            this.avion.Name = "avion";
            this.avion.Size = new System.Drawing.Size(100, 50);
            this.avion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avion.TabIndex = 16;
            this.avion.TabStop = false;
            this.avion.Click += new System.EventHandler(this.avion_Click);
            // 
            // ventilador
            // 
            this.ventilador.BackColor = System.Drawing.Color.Transparent;
            this.ventilador.Image = ((System.Drawing.Image)(resources.GetObject("ventilador.Image")));
            this.ventilador.Location = new System.Drawing.Point(123, 499);
            this.ventilador.Name = "ventilador";
            this.ventilador.Size = new System.Drawing.Size(60, 55);
            this.ventilador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ventilador.TabIndex = 17;
            this.ventilador.TabStop = false;
            this.ventilador.Click += new System.EventHandler(this.ventilador_Click);
            // 
            // signal
            // 
            this.signal.BackColor = System.Drawing.Color.Transparent;
            this.signal.Image = ((System.Drawing.Image)(resources.GetObject("signal.Image")));
            this.signal.Location = new System.Drawing.Point(1294, 376);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(49, 72);
            this.signal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signal.TabIndex = 18;
            this.signal.TabStop = false;
            this.signal.Click += new System.EventHandler(this.signal_Click);
            // 
            // ImperioRomano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1381, 712);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.ventilador);
            this.Controls.Add(this.avion);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.levelProgressLabel);
            this.Controls.Add(this.puntuacionLable);
            this.Controls.Add(this.timeLable);
            this.Controls.Add(this.texto_bocadillo);
            this.Controls.Add(this.bocadillo);
            this.Controls.Add(this.antena);
            this.Controls.Add(this.lucas);
            this.Controls.Add(this.romano);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImperioRomano";
            this.Text = "Imperio Romano";
            ((System.ComponentModel.ISupportInitialize)(this.romano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventilador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox romano;
        private System.Windows.Forms.PictureBox lucas;
        private System.Windows.Forms.PictureBox antena;
        private System.Windows.Forms.PictureBox bocadillo;
        private System.Windows.Forms.Label texto_bocadillo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Label puntuacionLable;
        private System.Windows.Forms.Label levelProgressLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.PictureBox avion;
        private System.Windows.Forms.PictureBox ventilador;
        private System.Windows.Forms.PictureBox signal;
    }
}