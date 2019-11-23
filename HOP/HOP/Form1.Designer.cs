namespace HOP
{
    partial class Form1
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.adminView = new System.Windows.Forms.Button();
            this.CleaningView = new System.Windows.Forms.Button();
            this.ReceptionView = new System.Windows.Forms.Button();
            this.KitchenView = new System.Windows.Forms.Button();
            this.CloseWindowBtn = new System.Windows.Forms.Label();
            this.MinimizeWindow = new System.Windows.Forms.Label();
            this.logInPage1 = new HOP.LogInPage();
            this.cleaningPanel1 = new HOP.CleaningPanel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.MinimizeWindow);
            this.MainPanel.Controls.Add(this.CloseWindowBtn);
            this.MainPanel.Controls.Add(this.adminView);
            this.MainPanel.Controls.Add(this.CleaningView);
            this.MainPanel.Controls.Add(this.ReceptionView);
            this.MainPanel.Controls.Add(this.KitchenView);
            this.MainPanel.Controls.Add(this.logInPage1);
            this.MainPanel.Controls.Add(this.cleaningPanel1);
            this.MainPanel.Location = new System.Drawing.Point(1, -1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1300, 650);
            this.MainPanel.TabIndex = 1;
            // 
            // adminView
            // 
            this.adminView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminView.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminView.Location = new System.Drawing.Point(675, 0);
            this.adminView.Name = "adminView";
            this.adminView.Size = new System.Drawing.Size(219, 47);
            this.adminView.TabIndex = 6;
            this.adminView.Text = "Admin";
            this.adminView.UseVisualStyleBackColor = true;
            // 
            // CleaningView
            // 
            this.CleaningView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleaningView.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleaningView.Location = new System.Drawing.Point(450, 0);
            this.CleaningView.Name = "CleaningView";
            this.CleaningView.Size = new System.Drawing.Size(219, 47);
            this.CleaningView.TabIndex = 5;
            this.CleaningView.Text = "Cleaning View";
            this.CleaningView.UseVisualStyleBackColor = true;
            this.CleaningView.Click += new System.EventHandler(this.CleaningView_Click);
            // 
            // ReceptionView
            // 
            this.ReceptionView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceptionView.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionView.Location = new System.Drawing.Point(0, 0);
            this.ReceptionView.Name = "ReceptionView";
            this.ReceptionView.Size = new System.Drawing.Size(219, 47);
            this.ReceptionView.TabIndex = 4;
            this.ReceptionView.Text = "Reception View";
            this.ReceptionView.UseVisualStyleBackColor = true;
            // 
            // KitchenView
            // 
            this.KitchenView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitchenView.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KitchenView.Location = new System.Drawing.Point(225, 0);
            this.KitchenView.Name = "KitchenView";
            this.KitchenView.Size = new System.Drawing.Size(219, 47);
            this.KitchenView.TabIndex = 1;
            this.KitchenView.Text = "Kitchen View";
            this.KitchenView.UseVisualStyleBackColor = true;
            // 
            // CloseWindowBtn
            // 
            this.CloseWindowBtn.AutoSize = true;
            this.CloseWindowBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindowBtn.Location = new System.Drawing.Point(1264, 7);
            this.CloseWindowBtn.Name = "CloseWindowBtn";
            this.CloseWindowBtn.Size = new System.Drawing.Size(33, 31);
            this.CloseWindowBtn.TabIndex = 7;
            this.CloseWindowBtn.Text = "X";
            this.CloseWindowBtn.Click += new System.EventHandler(this.label1_Click);
            // 
            // MinimizeWindow
            // 
            this.MinimizeWindow.AutoSize = true;
            this.MinimizeWindow.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeWindow.Location = new System.Drawing.Point(1225, 7);
            this.MinimizeWindow.Name = "MinimizeWindow";
            this.MinimizeWindow.Size = new System.Drawing.Size(28, 31);
            this.MinimizeWindow.TabIndex = 8;
            this.MinimizeWindow.Text = "_";
            this.MinimizeWindow.Click += new System.EventHandler(this.MinimizeWindow_Click);
            // 
            // logInPage1
            // 
            this.logInPage1.BackColor = System.Drawing.Color.Teal;
            this.logInPage1.Location = new System.Drawing.Point(0, 47);
            this.logInPage1.Name = "logInPage1";
            this.logInPage1.Size = new System.Drawing.Size(1300, 600);
            this.logInPage1.TabIndex = 3;
            // 
            // cleaningPanel1
            // 
            this.cleaningPanel1.BackColor = System.Drawing.Color.Teal;
            this.cleaningPanel1.Location = new System.Drawing.Point(0, 47);
            this.cleaningPanel1.Name = "cleaningPanel1";
            this.cleaningPanel1.Size = new System.Drawing.Size(1300, 600);
            this.cleaningPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button KitchenView;
        private CleaningPanel cleaningPanel1;
        private System.Windows.Forms.Button adminView;
        private System.Windows.Forms.Button CleaningView;
        private System.Windows.Forms.Button ReceptionView;
        private LogInPage logInPage1;
        private System.Windows.Forms.Label CloseWindowBtn;
        private System.Windows.Forms.Label MinimizeWindow;
    }
}

