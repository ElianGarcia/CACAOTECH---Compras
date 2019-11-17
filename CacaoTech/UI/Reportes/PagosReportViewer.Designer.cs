using System;

namespace CacaoTech.UI.Reportes
{
    partial class PagosReportViewer
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
            this.pagosReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // pagosReportViewer1
            // 
            this.pagosReportViewer1.ActiveViewIndex = 0;
            this.pagosReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pagosReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pagosReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagosReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.pagosReportViewer1.Name = "pagosReportViewer1";
            this.pagosReportViewer1.ReportSource = "C:\\Users\\ASUS\\source\\repos\\ProyectoFinal\\CacaoTech\\UI\\Reportes\\ListadoPagos.rpt";
            this.pagosReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.pagosReportViewer1.TabIndex = 0;
            this.pagosReportViewer1.Load += new System.EventHandler(this.pagosReportViewer1_Load);
            // 
            // PagosReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pagosReportViewer1);
            this.Name = "PagosReportViewer";
            this.Text = "Reporte Pagos";
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer pagosReportViewer1;
    }
}