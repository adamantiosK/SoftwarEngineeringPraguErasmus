namespace HOP
{
    partial class ReceptionPanel
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
            this.button2 = new System.Windows.Forms.Button();
            this.Loginout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logInPage1 = new HOP.LogInPage();
            this.viewReservations1 = new HOP.Controller.SubPanels.ViewReservations();
            this.makeAReservation1 = new HOP.Controller.SubPanels.MakeAReservation();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(291, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make a Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(786, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(514, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "View Reservations";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Loginout
            // 
            this.Loginout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Loginout.Location = new System.Drawing.Point(134, 0);
            this.Loginout.Name = "Loginout";
            this.Loginout.Size = new System.Drawing.Size(160, 30);
            this.Loginout.TabIndex = 2;
            this.Loginout.Text = "Log In";
            this.Loginout.UseVisualStyleBackColor = true;
            this.Loginout.Click += new System.EventHandler(this.Loginout_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 30);
            this.textBox1.TabIndex = 3;
            // 
            // logInPage1
            // 
            this.logInPage1.BackColor = System.Drawing.Color.Teal;
            this.logInPage1.Location = new System.Drawing.Point(0, 30);
            this.logInPage1.Name = "logInPage1";
            this.logInPage1.Size = new System.Drawing.Size(1300, 570);
            this.logInPage1.TabIndex = 6;
            // 
            // viewReservations1
            // 
            this.viewReservations1.BackColor = System.Drawing.Color.Teal;
            this.viewReservations1.Location = new System.Drawing.Point(0, 30);
            this.viewReservations1.Name = "viewReservations1";
            this.viewReservations1.Size = new System.Drawing.Size(1300, 570);
            this.viewReservations1.TabIndex = 5;
            // 
            // makeAReservation1
            // 
            this.makeAReservation1.BackColor = System.Drawing.Color.Teal;
            this.makeAReservation1.Location = new System.Drawing.Point(0, 30);
            this.makeAReservation1.Name = "makeAReservation1";
            this.makeAReservation1.Size = new System.Drawing.Size(1300, 570);
            this.makeAReservation1.TabIndex = 4;
            // 
            // ReceptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.logInPage1);
            this.Controls.Add(this.viewReservations1);
            this.Controls.Add(this.makeAReservation1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Loginout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ReceptionPanel";
            this.Size = new System.Drawing.Size(1300, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Loginout;
        private System.Windows.Forms.TextBox textBox1;
        private Controller.SubPanels.MakeAReservation makeAReservation1;
        private Controller.SubPanels.ViewReservations viewReservations1;
        private LogInPage logInPage1;
    }
}
