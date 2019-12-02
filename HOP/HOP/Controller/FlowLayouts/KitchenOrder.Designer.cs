namespace HOP
{
    partial class KitchenOrder
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
            this.DoneBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.WorkerIDtxt = new System.Windows.Forms.TextBox();
            this.OrderLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoLbl = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.RoomNoLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoneBtn
            // 
            this.DoneBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.DoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneBtn.Location = new System.Drawing.Point(988, 49);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(242, 34);
            this.DoneBtn.TabIndex = 21;
            this.DoneBtn.Text = "Execute Meal";
            this.DoneBtn.UseVisualStyleBackColor = false;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(950, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 95);
            this.panel3.TabIndex = 15;
            // 
            // WorkerIDtxt
            // 
            this.WorkerIDtxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerIDtxt.Location = new System.Drawing.Point(988, 9);
            this.WorkerIDtxt.Multiline = true;
            this.WorkerIDtxt.Name = "WorkerIDtxt";
            this.WorkerIDtxt.PasswordChar = '*';
            this.WorkerIDtxt.Size = new System.Drawing.Size(242, 34);
            this.WorkerIDtxt.TabIndex = 19;
            // 
            // OrderLbl
            // 
            this.OrderLbl.AutoSize = true;
            this.OrderLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderLbl.Location = new System.Drawing.Point(218, 26);
            this.OrderLbl.Name = "OrderLbl";
            this.OrderLbl.Size = new System.Drawing.Size(106, 23);
            this.OrderLbl.TabIndex = 16;
            this.OrderLbl.Text = "- One Meal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(186, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Details:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(163, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 95);
            this.panel1.TabIndex = 12;
            // 
            // NoLbl
            // 
            this.NoLbl.AutoSize = true;
            this.NoLbl.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NoLbl.Location = new System.Drawing.Point(47, 46);
            this.NoLbl.Name = "NoLbl";
            this.NoLbl.Size = new System.Drawing.Size(55, 34);
            this.NoLbl.TabIndex = 11;
            this.NoLbl.Text = "NO";
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Order.Location = new System.Drawing.Point(31, 9);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(95, 34);
            this.Order.TabIndex = 10;
            this.Order.Text = "Order:";
            // 
            // RoomNoLbl
            // 
            this.RoomNoLbl.AutoSize = true;
            this.RoomNoLbl.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RoomNoLbl.Location = new System.Drawing.Point(865, 46);
            this.RoomNoLbl.Name = "RoomNoLbl";
            this.RoomNoLbl.Size = new System.Drawing.Size(55, 34);
            this.RoomNoLbl.TabIndex = 23;
            this.RoomNoLbl.Text = "NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(849, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "Room:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(827, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 95);
            this.panel2.TabIndex = 16;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.messageLbl.Location = new System.Drawing.Point(658, 9);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(0, 23);
            this.messageLbl.TabIndex = 24;
            // 
            // KitchenOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RoomNoLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.WorkerIDtxt);
            this.Controls.Add(this.OrderLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NoLbl);
            this.Controls.Add(this.Order);
            this.Name = "KitchenOrder";
            this.Size = new System.Drawing.Size(1250, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox WorkerIDtxt;
        private System.Windows.Forms.Label OrderLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NoLbl;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Label RoomNoLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label messageLbl;
    }
}
