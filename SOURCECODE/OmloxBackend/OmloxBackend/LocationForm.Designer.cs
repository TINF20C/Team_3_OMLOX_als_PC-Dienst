namespace OmloxBackend
{
    partial class LocationForm
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
            this.allLocationsListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showOnMapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allLocationsListBox
            // 
            this.allLocationsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))));
            this.allLocationsListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.allLocationsListBox.FormattingEnabled = true;
            this.allLocationsListBox.Location = new System.Drawing.Point(12, 57);
            this.allLocationsListBox.Name = "allLocationsListBox";
            this.allLocationsListBox.Size = new System.Drawing.Size(208, 229);
            this.allLocationsListBox.TabIndex = 0;
            this.allLocationsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.allLocationsListBox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "newest location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "oldest location";
            // 
            // showOnMapButton
            // 
            this.showOnMapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))));
            this.showOnMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showOnMapButton.ForeColor = System.Drawing.SystemColors.Window;
            this.showOnMapButton.Location = new System.Drawing.Point(15, 12);
            this.showOnMapButton.Name = "showOnMapButton";
            this.showOnMapButton.Size = new System.Drawing.Size(89, 23);
            this.showOnMapButton.TabIndex = 3;
            this.showOnMapButton.Text = "show on Map";
            this.showOnMapButton.UseVisualStyleBackColor = false;
            this.showOnMapButton.Click += new System.EventHandler(this.showOnMapButton_Click);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 308);
            this.Controls.Add(this.showOnMapButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allLocationsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LocationForm";
            this.Text = "locations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox allLocationsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showOnMapButton;
    }
}