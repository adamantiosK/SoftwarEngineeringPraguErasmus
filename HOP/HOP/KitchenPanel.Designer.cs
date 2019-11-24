namespace HOP
{
    partial class KitchenPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KitchenLive = new System.Windows.Forms.Button();
            this.CleanGreenBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1300, 570);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.KitchenLive);
            this.panel1.Controls.Add(this.CleanGreenBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 29);
            this.panel1.TabIndex = 2;
            // 
            // KitchenLive
            // 
            this.KitchenLive.BackColor = System.Drawing.Color.Red;
            this.KitchenLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitchenLive.Location = new System.Drawing.Point(161, -1);
            this.KitchenLive.Name = "KitchenLive";
            this.KitchenLive.Size = new System.Drawing.Size(164, 27);
            this.KitchenLive.TabIndex = 3;
            this.KitchenLive.Text = "Kitchen Live";
            this.KitchenLive.UseVisualStyleBackColor = false;
            this.KitchenLive.Click += new System.EventHandler(this.RefreshRooms_Click);
            // 
            // CleanGreenBtn
            // 
            this.CleanGreenBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.CleanGreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanGreenBtn.Location = new System.Drawing.Point(0, -1);
            this.CleanGreenBtn.Name = "CleanGreenBtn";
            this.CleanGreenBtn.Size = new System.Drawing.Size(164, 27);
            this.CleanGreenBtn.TabIndex = 2;
            this.CleanGreenBtn.Text = "Clean Green";
            this.CleanGreenBtn.UseVisualStyleBackColor = false;
            this.CleanGreenBtn.Click += new System.EventHandler(this.CleanGreenBtn_Click);
            // 
            // KitchenPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "KitchenPanel";
            this.Size = new System.Drawing.Size(1300, 600);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button KitchenLive;
        private System.Windows.Forms.Button CleanGreenBtn;
    }
}
