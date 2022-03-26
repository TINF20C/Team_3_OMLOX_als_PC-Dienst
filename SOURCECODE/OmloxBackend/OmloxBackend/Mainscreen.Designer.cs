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
            this.userDocButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateDeviceButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(244)))), ((int)(((byte)(144)))));
            this.deviceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deviceList.CheckOnClick = true;
            this.deviceList.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(26)))), ((int)(((byte)(56)))));
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Items.AddRange(new object[] {
            "device 1",
            "device 2"});
            this.deviceList.Location = new System.Drawing.Point(6, 3);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(794, 168);
            this.deviceList.TabIndex = 2;
            this.deviceList.SelectedIndexChanged += new System.EventHandler(this.deviceList_SelectedIndexChanged);
            // 
            // deviceAddButton
            // 
            this.deviceAddButton.FlatAppearance.BorderSize = 0;
            this.deviceAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deviceAddButton.Image = ((System.Drawing.Image)(resources.GetObject("deviceAddButton.Image")));
            this.deviceAddButton.Location = new System.Drawing.Point(10, 10);
            this.deviceAddButton.Name = "deviceAddButton";
            this.deviceAddButton.Size = new System.Drawing.Size(70, 70);
            this.deviceAddButton.TabIndex = 3;
            this.deviceAddButton.UseVisualStyleBackColor = true;
            this.deviceAddButton.Click += new System.EventHandler(this.deviceAddButton_Click);
            // 
            // deviceRemoveButton
            // 
            this.deviceRemoveButton.FlatAppearance.BorderSize = 0;
            this.deviceRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deviceRemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("deviceRemoveButton.Image")));
            this.deviceRemoveButton.Location = new System.Drawing.Point(10, 100);
            this.deviceRemoveButton.Name = "deviceRemoveButton";
            this.deviceRemoveButton.Size = new System.Drawing.Size(70, 70);
            this.deviceRemoveButton.TabIndex = 4;
            this.deviceRemoveButton.UseVisualStyleBackColor = true;
            this.deviceRemoveButton.Click += new System.EventHandler(this.deviceRemoveButton_Click);
            // 
            // showButton
            // 
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Image = ((System.Drawing.Image)(resources.GetObject("showButton.Image")));
            this.showButton.Location = new System.Drawing.Point(10, 190);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(70, 70);
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
            this.updateButton.Location = new System.Drawing.Point(10, 280);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(70, 70);
            this.updateButton.TabIndex = 6;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.userDocButton);
            this.panel1.Controls.Add(this.deviceAddButton);
            this.panel1.Controls.Add(this.deviceRemoveButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.showButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 461);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userDocButton
            // 
            this.userDocButton.FlatAppearance.BorderSize = 0;
            this.userDocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userDocButton.Image = ((System.Drawing.Image)(resources.GetObject("userDocButton.Image")));
            this.userDocButton.Location = new System.Drawing.Point(10, 370);
            this.userDocButton.Name = "userDocButton";
            this.userDocButton.Size = new System.Drawing.Size(70, 70);
            this.userDocButton.TabIndex = 7;
            this.userDocButton.UseVisualStyleBackColor = true;
            this.userDocButton.Click += new System.EventHandler(this.userDocButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.deviceList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(90, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 181);
            this.panel2.TabIndex = 8;
            // 
            // updateDeviceButton
            // 
            this.updateDeviceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(244)))), ((int)(((byte)(144)))));
            this.updateDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateDeviceButton.Location = new System.Drawing.Point(96, 251);
            this.updateDeviceButton.Name = "updateDeviceButton";
            this.updateDeviceButton.Size = new System.Drawing.Size(107, 23);
            this.updateDeviceButton.TabIndex = 9;
            this.updateDeviceButton.Text = "Update Location";
            this.updateDeviceButton.UseVisualStyleBackColor = false;
            this.updateDeviceButton.Click += new System.EventHandler(this.updateDeviceButton_Click);
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.updateDeviceButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Mainscreen";
            this.Text = "OMLOX PC-Service";
            this.Load += new System.EventHandler(this.Mainscreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox deviceList;
        private System.Windows.Forms.Button deviceAddButton;
        private System.Windows.Forms.Button deviceRemoveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button userDocButton;
        private System.Windows.Forms.Button updateDeviceButton;
    }
}