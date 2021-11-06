namespace OmloxBackend
{
    partial class Mainscreen
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.deviceList = new System.Windows.Forms.CheckedListBox();
            this.deviceAddButton = new System.Windows.Forms.Button();
            this.deviceRemoveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(713, 13);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // deviceList
            // 
            this.deviceList.CheckOnClick = true;
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Items.AddRange(new object[] {
            "device 1",
            "device 2"});
            this.deviceList.Location = new System.Drawing.Point(26, 30);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(304, 364);
            this.deviceList.TabIndex = 2;
            // 
            // deviceAddButton
            // 
            this.deviceAddButton.Location = new System.Drawing.Point(337, 30);
            this.deviceAddButton.Name = "deviceAddButton";
            this.deviceAddButton.Size = new System.Drawing.Size(75, 23);
            this.deviceAddButton.TabIndex = 3;
            this.deviceAddButton.Text = "Add Device";
            this.deviceAddButton.UseVisualStyleBackColor = true;
            this.deviceAddButton.Click += new System.EventHandler(this.deviceAddButton_Click);
            // 
            // deviceRemoveButton
            // 
            this.deviceRemoveButton.Location = new System.Drawing.Point(337, 60);
            this.deviceRemoveButton.Name = "deviceRemoveButton";
            this.deviceRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.deviceRemoveButton.TabIndex = 4;
            this.deviceRemoveButton.Text = "Remove Device";
            this.deviceRemoveButton.UseVisualStyleBackColor = true;
            this.deviceRemoveButton.Click += new System.EventHandler(this.deviceRemoveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(337, 90);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.deviceRemoveButton);
            this.Controls.Add(this.deviceAddButton);
            this.Controls.Add(this.deviceList);
            this.Controls.Add(this.logoutButton);
            this.Name = "Mainscreen";
            this.Text = "Mainscreen";
            this.Load += new System.EventHandler(this.Mainscreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.CheckedListBox deviceList;
        private System.Windows.Forms.Button deviceAddButton;
        private System.Windows.Forms.Button deviceRemoveButton;
        private System.Windows.Forms.Button showButton;
    }
}