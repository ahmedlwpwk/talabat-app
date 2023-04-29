
namespace Phase2
{
    partial class Form1
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tax = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 114);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 611);
            this.crystalReportViewer1.TabIndex = 8;
            // 
            // tax
            // 
            this.tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tax.Location = new System.Drawing.Point(404, 12);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(170, 80);
            this.tax.TabIndex = 10;
            this.tax.Text = "Supplier Taxes (Generate Reports)\r\n";
            this.tax.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.Location = new System.Drawing.Point(224, 12);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(170, 80);
            this.report.TabIndex = 9;
            this.report.Text = "Our Statistics (Generate Reports)\r\n";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Phase2.Properties.Resources.istockphoto_887933242_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 722);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.report);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button tax;
        private System.Windows.Forms.Button report;
    }
}