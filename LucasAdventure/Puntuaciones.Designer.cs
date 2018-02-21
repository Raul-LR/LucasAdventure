namespace LucasAdventure
{
    partial class Puntuaciones
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puntuaciones));
            this.JugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SistemaPuntuacionDataSet = new LucasAdventure.SistemaPuntuacionDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.JugadoresTableAdapter = new LucasAdventure.SistemaPuntuacionDataSetTableAdapters.JugadoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaPuntuacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // JugadoresBindingSource
            // 
            this.JugadoresBindingSource.DataMember = "Jugadores";
            this.JugadoresBindingSource.DataSource = this.SistemaPuntuacionDataSet;
            // 
            // SistemaPuntuacionDataSet
            // 
            this.SistemaPuntuacionDataSet.DataSetName = "SistemaPuntuacionDataSet";
            this.SistemaPuntuacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Jugadores";
            reportDataSource1.Value = this.JugadoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LucasAdventure.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(680, 413);
            this.reportViewer1.TabIndex = 0;
            // 
            // JugadoresTableAdapter
            // 
            this.JugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // Puntuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 417);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Puntuaciones";
            this.Text = "Puntuaciones";
            this.Load += new System.EventHandler(this.Puntuaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SistemaPuntuacionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource JugadoresBindingSource;
        private SistemaPuntuacionDataSet SistemaPuntuacionDataSet;
        private SistemaPuntuacionDataSetTableAdapters.JugadoresTableAdapter JugadoresTableAdapter;
    }
}