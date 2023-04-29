
namespace Phase2
{
    partial class driver
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
            this.cmb_d_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_o_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_d_id
            // 
            this.cmb_d_id.Font = new System.Drawing.Font("Engravers MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_d_id.FormattingEnabled = true;
            this.cmb_d_id.Location = new System.Drawing.Point(193, 67);
            this.cmb_d_id.Name = "cmb_d_id";
            this.cmb_d_id.Size = new System.Drawing.Size(188, 37);
            this.cmb_d_id.TabIndex = 0;
            this.cmb_d_id.SelectedIndexChanged += new System.EventHandler(this.cmb_d_id_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver id";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show order id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_o_count
            // 
            this.txt_o_count.Font = new System.Drawing.Font("Engravers MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_o_count.Location = new System.Drawing.Point(193, 129);
            this.txt_o_count.Name = "txt_o_count";
            this.txt_o_count.Size = new System.Drawing.Size(188, 37);
            this.txt_o_count.TabIndex = 3;
            this.txt_o_count.TextChanged += new System.EventHandler(this.txt_o_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orders count";
            // 
            // driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Phase2.Properties.Resources.istockphoto_1343822386_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_o_count);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_d_id);
            this.Name = "driver";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.driver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_d_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_o_count;
        private System.Windows.Forms.Label label2;
    }
}