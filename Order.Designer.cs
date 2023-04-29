namespace Phase2
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.uer_id = new System.Windows.Forms.TextBox();
            this.btn_showCopies = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uer_id
            // 
            this.uer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uer_id.Location = new System.Drawing.Point(467, 33);
            this.uer_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uer_id.Name = "uer_id";
            this.uer_id.Size = new System.Drawing.Size(132, 26);
            this.uer_id.TabIndex = 2;
            // 
            // btn_showCopies
            // 
            this.btn_showCopies.Location = new System.Drawing.Point(467, 406);
            this.btn_showCopies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_showCopies.Name = "btn_showCopies";
            this.btn_showCopies.Size = new System.Drawing.Size(100, 28);
            this.btn_showCopies.TabIndex = 3;
            this.btn_showCopies.Text = "Show Order";
            this.btn_showCopies.UseVisualStyleBackColor = true;
            this.btn_showCopies.Click += new System.EventHandler(this.btn_showCopies_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 174);
            this.dataGridView1.TabIndex = 4;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_showCopies);
            this.Controls.Add(this.uer_id);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uer_id;
        private System.Windows.Forms.Button btn_showCopies;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}