
namespace Phase2
{
    partial class MainForm
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
            this.finditem = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.drivers = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Talabat Main Page\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finditem
            // 
            this.finditem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.finditem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finditem.Location = new System.Drawing.Point(150, 131);
            this.finditem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.finditem.Name = "finditem";
            this.finditem.Size = new System.Drawing.Size(350, 95);
            this.finditem.TabIndex = 1;
            this.finditem.Text = "Find An Item";
            this.finditem.UseVisualStyleBackColor = false;
            this.finditem.Click += new System.EventHandler(this.finditem_Click);
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(150, 261);
            this.Order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(350, 95);
            this.Order.TabIndex = 2;
            this.Order.Text = "Show Order\r\n";
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // drivers
            // 
            this.drivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.drivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivers.Location = new System.Drawing.Point(150, 392);
            this.drivers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(350, 95);
            this.drivers.TabIndex = 3;
            this.drivers.Text = "Know More About Drivers";
            this.drivers.UseVisualStyleBackColor = false;
            this.drivers.Click += new System.EventHandler(this.drivers_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(150, 522);
            this.user.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(350, 95);
            this.user.TabIndex = 4;
            this.user.Text = "New User";
            this.user.UseVisualStyleBackColor = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(150, 658);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 95);
            this.button1.TabIndex = 5;
            this.button1.Text = "Check Reports and Statistics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Phase2.Properties.Resources.istockphoto_1447140859_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 870);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.drivers);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.finditem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Talabat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finditem;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button drivers;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Button button1;
    }
}