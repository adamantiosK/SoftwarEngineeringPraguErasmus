namespace HOP
{
    partial class CleaningPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CleanGreenBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RefreshRooms = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.RefreshRooms);
            this.panel1.Controls.Add(this.CleanGreenBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 29);
            this.panel1.TabIndex = 1;
            // 
            // CleanGreenBtn
            // 
            this.CleanGreenBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.CleanGreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanGreenBtn.Location = new System.Drawing.Point(0, -1);
            this.CleanGreenBtn.Name = "CleanGreenBtn";
            this.CleanGreenBtn.Size = new System.Drawing.Size(164, 30);
            this.CleanGreenBtn.TabIndex = 2;
            this.CleanGreenBtn.Text = "Clean Green";
            this.CleanGreenBtn.UseVisualStyleBackColor = false;
            this.CleanGreenBtn.Click += new System.EventHandler(this.CleanGreenBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1297, 572);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // RefreshRooms
            // 
            this.RefreshRooms.BackColor = System.Drawing.Color.DarkGreen;
            this.RefreshRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshRooms.Location = new System.Drawing.Point(161, -1);
            this.RefreshRooms.Name = "RefreshRooms";
            this.RefreshRooms.Size = new System.Drawing.Size(164, 30);
            this.RefreshRooms.TabIndex = 3;
            this.RefreshRooms.Text = "Refresh Rooms";
            this.RefreshRooms.UseVisualStyleBackColor = false;
            this.RefreshRooms.Click += new System.EventHandler(this.RefreshRooms_Click);
            // 
            // CleaningPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "CleaningPanel";
            this.Size = new System.Drawing.Size(1300, 600);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CleanGreenBtn;
        private System.Windows.Forms.Button RefreshRooms;
    }
}
