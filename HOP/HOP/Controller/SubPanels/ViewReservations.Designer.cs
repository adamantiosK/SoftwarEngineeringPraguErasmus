namespace HOP.Controller.SubPanels
{
    partial class ViewReservations
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
            this.activeResidenciesPanel1 = new HOP.Controller.SubPanels.ActiveResidenciesPanel();
            this.allReservationsPanel1 = new HOP.Controller.SubPanels.AllReservationsPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(650, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Active Residences";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(650, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(650, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "All Reservations";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // activeResidenciesPanel1
            // 
            this.activeResidenciesPanel1.BackColor = System.Drawing.Color.Teal;
            this.activeResidenciesPanel1.Location = new System.Drawing.Point(0, 30);
            this.activeResidenciesPanel1.Name = "activeResidenciesPanel1";
            this.activeResidenciesPanel1.Size = new System.Drawing.Size(1300, 540);
            this.activeResidenciesPanel1.TabIndex = 2;
            // 
            // allReservationsPanel1
            // 
            this.allReservationsPanel1.BackColor = System.Drawing.Color.Teal;
            this.allReservationsPanel1.Location = new System.Drawing.Point(0, 30);
            this.allReservationsPanel1.Name = "allReservationsPanel1";
            this.allReservationsPanel1.Size = new System.Drawing.Size(1300, 540);
            this.allReservationsPanel1.TabIndex = 3;
            // 
            // ViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.allReservationsPanel1);
            this.Controls.Add(this.activeResidenciesPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ViewReservations";
            this.Size = new System.Drawing.Size(1300, 570);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ActiveResidenciesPanel activeResidenciesPanel1;
        private AllReservationsPanel allReservationsPanel1;
    }
}
