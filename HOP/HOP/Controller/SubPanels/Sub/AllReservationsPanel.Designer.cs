﻿namespace HOP.Controller.SubPanels
{
    partial class AllReservationsPanel
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
            this.AllReservationFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AllReservationFlow
            // 
            this.AllReservationFlow.Location = new System.Drawing.Point(3, 0);
            this.AllReservationFlow.Name = "AllReservationFlow";
            this.AllReservationFlow.Size = new System.Drawing.Size(1297, 540);
            this.AllReservationFlow.TabIndex = 0;
            // 
            // AllReservationsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.AllReservationFlow);
            this.Name = "AllReservationsPanel";
            this.Size = new System.Drawing.Size(1300, 540);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AllReservationFlow;
    }
}
