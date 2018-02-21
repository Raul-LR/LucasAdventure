namespace LucasAdventure
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.Info = new System.Windows.Forms.Label();
            this.nombreLable = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(119, 23);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(591, 170);
            this.Info.TabIndex = 0;
            this.Info.Text = resources.GetString("Info.Text");
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombreLable
            // 
            this.nombreLable.AutoSize = true;
            this.nombreLable.Font = new System.Drawing.Font("Colonna MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLable.Location = new System.Drawing.Point(306, 246);
            this.nombreLable.Name = "nombreLable";
            this.nombreLable.Size = new System.Drawing.Size(78, 18);
            this.nombreLable.TabIndex = 1;
            this.nombreLable.Text = "Nombre:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(407, 242);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 2;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(362, 311);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(95, 23);
            this.start.TabIndex = 3;
            this.start.Text = "¡Comenzar!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 396);
            this.Controls.Add(this.start);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.nombreLable);
            this.Controls.Add(this.Info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registro";
            this.Text = "registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label nombreLable;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button start;
    }
}