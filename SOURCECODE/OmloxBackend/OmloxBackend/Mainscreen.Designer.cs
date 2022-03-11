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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainscreen));
            this.deviceList = new System.Windows.Forms.CheckedListBox();
            this.deviceAddButton = new System.Windows.Forms.Button();
            this.deviceRemoveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.CheckOnClick = true;
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Items.AddRange(new object[] {
            "device 1",
            "device 2"});
            this.deviceList.Location = new System.Drawing.Point(453, 11);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(200, 439);
            this.deviceList.TabIndex = 2;
            // 
            // deviceAddButton
            // 
            this.deviceAddButton.FlatAppearance.BorderSize = 0;
            this.deviceAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deviceAddButton.Image = ((System.Drawing.Image)(resources.GetObject("deviceAddButton.Image")));
            this.deviceAddButton.Location = new System.Drawing.Point(5, 10);
            this.deviceAddButton.Name = "deviceAddButton";
            this.deviceAddButton.Size = new System.Drawing.Size(100, 100);
            this.deviceAddButton.TabIndex = 3;
            this.deviceAddButton.UseVisualStyleBackColor = true;
            this.deviceAddButton.Click += new System.EventHandler(this.deviceAddButton_Click);
            // 
            // deviceRemoveButton
            // 
            this.deviceRemoveButton.FlatAppearance.BorderSize = 0;
            this.deviceRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deviceRemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("deviceRemoveButton.Image")));
            this.deviceRemoveButton.Location = new System.Drawing.Point(5, 120);
            this.deviceRemoveButton.Name = "deviceRemoveButton";
            this.deviceRemoveButton.Size = new System.Drawing.Size(100, 100);
            this.deviceRemoveButton.TabIndex = 4;
            this.deviceRemoveButton.UseVisualStyleBackColor = true;
            this.deviceRemoveButton.Click += new System.EventHandler(this.deviceRemoveButton_Click);
            // 
            // showButton
            // 
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Image = ((System.Drawing.Image)(resources.GetObject("showButton.Image")));
            this.showButton.Location = new System.Drawing.Point(5, 230);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(100, 100);
            this.showButton.TabIndex = 5;
            this.showButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.Location = new System.Drawing.Point(5, 340);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 100);
            this.updateButton.TabIndex = 6;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.deviceAddButton);
            this.panel1.Controls.Add(this.deviceRemoveButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.showButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 450);
            this.panel1.TabIndex = 7;
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deviceList);
            this.Controls.Add(this.panel1);
            this.Name = "Mainscreen";
            this.Text = "Mainscreen";
            this.Load += new System.EventHandler(this.Mainscreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox deviceList;
        private System.Windows.Forms.Button deviceAddButton;
        private System.Windows.Forms.Button deviceRemoveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panel1;
    }
}