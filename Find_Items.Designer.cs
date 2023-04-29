namespace Phase2
{
    partial class Find_Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.Find = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
            // 
            // Find
            // 
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.Location = new System.Drawing.Point(160, 212);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(60, 28);
            this.Find.TabIndex = 6;
            this.Find.Text = "Find ";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // View
            // 
            this.View.BackgroundColor = System.Drawing.Color.Olive;
            this.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.View.Location = new System.Drawing.Point(17, 302);
            this.View.Name = "View";
            this.View.RowHeadersWidth = 51;
            this.View.RowTemplate.Height = 24;
            this.View.Size = new System.Drawing.Size(338, 51);
            this.View.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 60);
            this.label2.TabIndex = 8;
            this.label2.Text = "    What Do You Need? \r\nSearch Now for a Supplier!";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(39, 134);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(300, 45);
            this.search.TabIndex = 9;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(280, 446);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 38);
            this.add.TabIndex = 10;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Find_Items
            // 
            this.BackgroundImage = global::Phase2.Properties.Resources.istockphoto_887933242_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 543);
            this.Controls.Add(this.add);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Find);
            this.Name = "Find_Items";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.DataGridView View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button add;
    }
}