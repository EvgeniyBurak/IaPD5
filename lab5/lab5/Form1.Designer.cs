namespace lab5
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
            this.ListOfDevices = new System.Windows.Forms.ListView();
            this.DeviceDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TurnOn = new System.Windows.Forms.Button();
            this.TurnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListOfDevices
            // 
            this.ListOfDevices.Location = new System.Drawing.Point(16, 39);
            this.ListOfDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListOfDevices.Name = "ListOfDevices";
            this.ListOfDevices.Size = new System.Drawing.Size(260, 397);
            this.ListOfDevices.TabIndex = 0;
            this.ListOfDevices.UseCompatibleStateImageBehavior = false;
            this.ListOfDevices.View = System.Windows.Forms.View.Tile;
            // 
            // DeviceDescription
            // 
            this.DeviceDescription.Location = new System.Drawing.Point(285, 39);
            this.DeviceDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeviceDescription.Multiline = true;
            this.DeviceDescription.Name = "DeviceDescription";
            this.DeviceDescription.Size = new System.Drawing.Size(472, 436);
            this.DeviceDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of devices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Device description";
            // 
            // TurnOn
            // 
            this.TurnOn.Location = new System.Drawing.Point(16, 446);
            this.TurnOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TurnOn.Name = "TurnOn";
            this.TurnOn.Size = new System.Drawing.Size(100, 28);
            this.TurnOn.TabIndex = 4;
            this.TurnOn.Text = "Turn on";
            this.TurnOn.UseVisualStyleBackColor = true;
            // 
            // TurnOff
            // 
            this.TurnOff.Location = new System.Drawing.Point(177, 446);
            this.TurnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TurnOff.Name = "TurnOff";
            this.TurnOff.Size = new System.Drawing.Size(100, 28);
            this.TurnOff.TabIndex = 5;
            this.TurnOff.Text = "Turn off";
            this.TurnOff.UseVisualStyleBackColor = true;
          //  this.TurnOff.Click += new System.EventHandler(this.TurnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 491);
            this.Controls.Add(this.TurnOff);
            this.Controls.Add(this.TurnOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceDescription);
            this.Controls.Add(this.ListOfDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Device Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListOfDevices;
        private System.Windows.Forms.TextBox DeviceDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TurnOn;
        private System.Windows.Forms.Button TurnOff;
    }
}

