namespace LucasAdventure
{
    partial class AntiguoEgipto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntiguoEgipto));
            this.egipcio = new System.Windows.Forms.PictureBox();
            this.lucas = new System.Windows.Forms.PictureBox();
            this.pista = new System.Windows.Forms.Label();
            this.calculadora = new System.Windows.Forms.PictureBox();
            this.bocadillo1 = new System.Windows.Forms.PictureBox();
            this.bocadillo2 = new System.Windows.Forms.PictureBox();
            this.texto_bocadillo2 = new System.Windows.Forms.Label();
            this.texto_bocadillo1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLable = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.levelProgressLabel = new System.Windows.Forms.Label();
            this.robot = new System.Windows.Forms.PictureBox();
            this.puntuacionLable = new System.Windows.Forms.Label();
            this.termo = new System.Windows.Forms.PictureBox();
            this.todoterreno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.egipcio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoterreno)).BeginInit();
            this.SuspendLayout();
            // 
            // egipcio
            // 
            this.egipcio.BackColor = System.Drawing.Color.Transparent;
            this.egipcio.Image = ((System.Drawing.Image)(resources.GetObject("egipcio.Image")));
            this.egipcio.Location = new System.Drawing.Point(750, 109);
            this.egipcio.Name = "egipcio";
            this.egipcio.Size = new System.Drawing.Size(536, 681);
            this.egipcio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egipcio.TabIndex = 0;
            this.egipcio.TabStop = false;
            this.egipcio.MouseLeave += new System.EventHandler(this.egipcio_MouseLeave);
            this.egipcio.MouseHover += new System.EventHandler(this.egipcio_MouseHover);
            // 
            // lucas
            // 
            this.lucas.BackColor = System.Drawing.Color.Transparent;
            this.lucas.Image = ((System.Drawing.Image)(resources.GetObject("lucas.Image")));
            this.lucas.Location = new System.Drawing.Point(465, 204);
            this.lucas.Name = "lucas";
            this.lucas.Size = new System.Drawing.Size(185, 267);
            this.lucas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lucas.TabIndex = 1;
            this.lucas.TabStop = false;
            this.lucas.MouseLeave += new System.EventHandler(this.lucas_MouseLeave);
            this.lucas.MouseHover += new System.EventHandler(this.lucas_MouseHover);
            // 
            // pista
            // 
            this.pista.AutoSize = true;
            this.pista.BackColor = System.Drawing.Color.Transparent;
            this.pista.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pista.Location = new System.Drawing.Point(28, 27);
            this.pista.Name = "pista";
            this.pista.Size = new System.Drawing.Size(494, 120);
            this.pista.TabIndex = 2;
            this.pista.Text = "Busca el objeto, moviendo el ratón\r\npor la zona, una vez lo encuentres\r\npincha so" +
    "bre él.\r\n";
            // 
            // calculadora
            // 
            this.calculadora.BackColor = System.Drawing.Color.Transparent;
            this.calculadora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.calculadora.Image = ((System.Drawing.Image)(resources.GetObject("calculadora.Image")));
            this.calculadora.Location = new System.Drawing.Point(153, 549);
            this.calculadora.Name = "calculadora";
            this.calculadora.Size = new System.Drawing.Size(45, 45);
            this.calculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calculadora.TabIndex = 3;
            this.calculadora.TabStop = false;
            this.calculadora.Click += new System.EventHandler(this.calculadora_Click);
            // 
            // bocadillo1
            // 
            this.bocadillo1.BackColor = System.Drawing.Color.Transparent;
            this.bocadillo1.Image = ((System.Drawing.Image)(resources.GetObject("bocadillo1.Image")));
            this.bocadillo1.Location = new System.Drawing.Point(598, 155);
            this.bocadillo1.Name = "bocadillo1";
            this.bocadillo1.Size = new System.Drawing.Size(325, 154);
            this.bocadillo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bocadillo1.TabIndex = 4;
            this.bocadillo1.TabStop = false;
            this.bocadillo1.Visible = false;
            // 
            // bocadillo2
            // 
            this.bocadillo2.BackColor = System.Drawing.Color.Transparent;
            this.bocadillo2.Image = ((System.Drawing.Image)(resources.GetObject("bocadillo2.Image")));
            this.bocadillo2.Location = new System.Drawing.Point(552, 43);
            this.bocadillo2.Name = "bocadillo2";
            this.bocadillo2.Size = new System.Drawing.Size(405, 243);
            this.bocadillo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bocadillo2.TabIndex = 5;
            this.bocadillo2.TabStop = false;
            this.bocadillo2.Visible = false;
            // 
            // texto_bocadillo2
            // 
            this.texto_bocadillo2.AutoSize = true;
            this.texto_bocadillo2.BackColor = System.Drawing.Color.White;
            this.texto_bocadillo2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_bocadillo2.Location = new System.Drawing.Point(583, 96);
            this.texto_bocadillo2.Name = "texto_bocadillo2";
            this.texto_bocadillo2.Size = new System.Drawing.Size(310, 81);
            this.texto_bocadillo2.TabIndex = 6;
            this.texto_bocadillo2.Text = "Me ha parecido ver, un artilugio\r\nextraño cerca del camello.\r\n\r\n";
            this.texto_bocadillo2.Visible = false;
            // 
            // texto_bocadillo1
            // 
            this.texto_bocadillo1.AutoSize = true;
            this.texto_bocadillo1.BackColor = System.Drawing.Color.White;
            this.texto_bocadillo1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto_bocadillo1.Location = new System.Drawing.Point(620, 194);
            this.texto_bocadillo1.Name = "texto_bocadillo1";
            this.texto_bocadillo1.Size = new System.Drawing.Size(216, 21);
            this.texto_bocadillo1.TabIndex = 7;
            this.texto_bocadillo1.Text = "¿Encuentras algo ya, amigo?";
            this.texto_bocadillo1.Visible = false;
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
            this.timeLable.Location = new System.Drawing.Point(1163, 33);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(64, 31);
            this.timeLable.TabIndex = 8;
            this.timeLable.Text = "15s";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressLabel.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(1043, 33);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(71, 31);
            this.progressLabel.TabIndex = 9;
            this.progressLabel.Text = "0/4";
            // 
            // levelProgressLabel
            // 
            this.levelProgressLabel.AutoSize = true;
            this.levelProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelProgressLabel.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelProgressLabel.Location = new System.Drawing.Point(1084, 648);
            this.levelProgressLabel.Name = "levelProgressLabel";
            this.levelProgressLabel.Size = new System.Drawing.Size(155, 31);
            this.levelProgressLabel.TabIndex = 10;
            this.levelProgressLabel.Text = "Nivel 1/4";
            // 
            // robot
            // 
            this.robot.BackColor = System.Drawing.Color.Transparent;
            this.robot.Image = ((System.Drawing.Image)(resources.GetObject("robot.Image")));
            this.robot.Location = new System.Drawing.Point(1069, 558);
            this.robot.Name = "robot";
            this.robot.Size = new System.Drawing.Size(45, 45);
            this.robot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.robot.TabIndex = 11;
            this.robot.TabStop = false;
            this.robot.Click += new System.EventHandler(this.robot_Click);
            // 
            // puntuacionLable
            // 
            this.puntuacionLable.AutoSize = true;
            this.puntuacionLable.BackColor = System.Drawing.Color.Transparent;
            this.puntuacionLable.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionLable.Location = new System.Drawing.Point(61, 648);
            this.puntuacionLable.Name = "puntuacionLable";
            this.puntuacionLable.Size = new System.Drawing.Size(115, 31);
            this.puntuacionLable.TabIndex = 12;
            this.puntuacionLable.Text = "Puntos";
            // 
            // termo
            // 
            this.termo.BackColor = System.Drawing.Color.Transparent;
            this.termo.Image = ((System.Drawing.Image)(resources.GetObject("termo.Image")));
            this.termo.Location = new System.Drawing.Point(316, 340);
            this.termo.Name = "termo";
            this.termo.Size = new System.Drawing.Size(44, 31);
            this.termo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.termo.TabIndex = 13;
            this.termo.TabStop = false;
            this.termo.Click += new System.EventHandler(this.termo_Click);
            // 
            // todoterreno
            // 
            this.todoterreno.BackColor = System.Drawing.Color.Transparent;
            this.todoterreno.Image = ((System.Drawing.Image)(resources.GetObject("todoterreno.Image")));
            this.todoterreno.Location = new System.Drawing.Point(1209, 325);
            this.todoterreno.Name = "todoterreno";
            this.todoterreno.Size = new System.Drawing.Size(48, 29);
            this.todoterreno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.todoterreno.TabIndex = 14;
            this.todoterreno.TabStop = false;
            this.todoterreno.Click += new System.EventHandler(this.todoterreno_Click);
            // 
            // AntiguoEgipto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 698);
            this.Controls.Add(this.todoterreno);
            this.Controls.Add(this.termo);
            this.Controls.Add(this.puntuacionLable);
            this.Controls.Add(this.robot);
            this.Controls.Add(this.levelProgressLabel);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.timeLable);
            this.Controls.Add(this.texto_bocadillo2);
            this.Controls.Add(this.bocadillo2);
            this.Controls.Add(this.texto_bocadillo1);
            this.Controls.Add(this.bocadillo1);
            this.Controls.Add(this.calculadora);
            this.Controls.Add(this.pista);
            this.Controls.Add(this.lucas);
            this.Controls.Add(this.egipcio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AntiguoEgipto";
            this.Text = "Antiguo Egipto";
            ((System.ComponentModel.ISupportInitialize)(this.egipcio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bocadillo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoterreno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox egipcio;
        private System.Windows.Forms.PictureBox lucas;
        private System.Windows.Forms.Label pista;
        private System.Windows.Forms.PictureBox calculadora;
        private System.Windows.Forms.PictureBox bocadillo1;
        private System.Windows.Forms.PictureBox bocadillo2;
        private System.Windows.Forms.Label texto_bocadillo2;
        private System.Windows.Forms.Label texto_bocadillo1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label levelProgressLabel;
        private System.Windows.Forms.PictureBox robot;
        private System.Windows.Forms.Label puntuacionLable;
        private System.Windows.Forms.PictureBox termo;
        private System.Windows.Forms.PictureBox todoterreno;
    }
}