namespace HOP.Controller.FlowLayouts
{
    partial class ResidencyPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.SURNAME = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.CheckOutDATE = new System.Windows.Forms.Label();
            this.CheckInDateLbl = new System.Windows.Forms.Label();
            this.NO = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1106, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Generate Invoice";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SURNAME
            // 
            this.SURNAME.AutoSize = true;
            this.SURNAME.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SURNAME.Location = new System.Drawing.Point(307, 10);
            this.SURNAME.Name = "SURNAME";
            this.SURNAME.Size = new System.Drawing.Size(86, 23);
            this.SURNAME.TabIndex = 10;
            this.SURNAME.Text = "Surname";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(159, 10);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(59, 23);
            this.NAME.TabIndex = 9;
            this.NAME.Text = "Name";
            // 
            // CheckOutDATE
            // 
            this.CheckOutDATE.AutoSize = true;
            this.CheckOutDATE.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDATE.Location = new System.Drawing.Point(658, 10);
            this.CheckOutDATE.Name = "CheckOutDATE";
            this.CheckOutDATE.Size = new System.Drawing.Size(146, 23);
            this.CheckOutDATE.TabIndex = 8;
            this.CheckOutDATE.Text = "Check Out Date";
            // 
            // CheckInDateLbl
            // 
            this.CheckInDateLbl.AutoSize = true;
            this.CheckInDateLbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInDateLbl.Location = new System.Drawing.Point(470, 10);
            this.CheckInDateLbl.Name = "CheckInDateLbl";
            this.CheckInDateLbl.Size = new System.Drawing.Size(132, 23);
            this.CheckInDateLbl.TabIndex = 7;
            this.CheckInDateLbl.Text = "Check In Date";
            // 
            // NO
            // 
            this.NO.AutoSize = true;
            this.NO.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NO.Location = new System.Drawing.Point(24, 10);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(39, 23);
            this.NO.TabIndex = 6;
            this.NO.Text = "NO";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(904, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Make an Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ResidencyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SURNAME);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.CheckOutDATE);
            this.Controls.Add(this.CheckInDateLbl);
            this.Controls.Add(this.NO);
            this.Name = "ResidencyPanel";
            this.Size = new System.Drawing.Size(1300, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SURNAME;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label CheckOutDATE;
        private System.Windows.Forms.Label CheckInDateLbl;
        private System.Windows.Forms.Label NO;
        private System.Windows.Forms.Button button2;
    }
}
