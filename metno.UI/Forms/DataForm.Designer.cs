namespace metno.UI
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LocationAddressLabel = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.nowcastListView = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metalertsListView = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FetchDataButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(994, 541);
            this.mainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mainTabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 500);
            this.panel2.TabIndex = 1;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(994, 500);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LocationAddressLabel);
            this.tabPage1.Controls.Add(this.LocationTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CreatedTextBox);
            this.tabPage1.Controls.Add(this.nowcastListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nedbørsdata";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LocationAddressLabel
            // 
            this.LocationAddressLabel.AutoSize = true;
            this.LocationAddressLabel.Location = new System.Drawing.Point(478, 9);
            this.LocationAddressLabel.Name = "LocationAddressLabel";
            this.LocationAddressLabel.Size = new System.Drawing.Size(0, 13);
            this.LocationAddressLabel.TabIndex = 5;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(332, 6);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(140, 20);
            this.LocationTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data for location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data generated";
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Location = new System.Drawing.Point(95, 6);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(140, 20);
            this.CreatedTextBox.TabIndex = 1;
            // 
            // nowcastListView
            // 
            this.nowcastListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nowcastListView.HideSelection = false;
            this.nowcastListView.Location = new System.Drawing.Point(3, 32);
            this.nowcastListView.Name = "nowcastListView";
            this.nowcastListView.Size = new System.Drawing.Size(980, 439);
            this.nowcastListView.TabIndex = 0;
            this.nowcastListView.UseCompatibleStateImageBehavior = false;
            this.nowcastListView.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metalertsListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(986, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Farevarsel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metalertsListView
            // 
            this.metalertsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metalertsListView.HideSelection = false;
            this.metalertsListView.Location = new System.Drawing.Point(0, 0);
            this.metalertsListView.Name = "metalertsListView";
            this.metalertsListView.Size = new System.Drawing.Size(986, 474);
            this.metalertsListView.TabIndex = 1;
            this.metalertsListView.UseCompatibleStateImageBehavior = false;
            this.metalertsListView.View = System.Windows.Forms.View.Details;
            this.metalertsListView.DoubleClick += new System.EventHandler(this.MetalertsListView_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FetchDataButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 41);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(98, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 29);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(55, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FetchDataButton
            // 
            this.FetchDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FetchDataButton.Image = global::metno.UI.Properties.Resources._112_RefreshArrow_Green_24x24_72;
            this.FetchDataButton.Location = new System.Drawing.Point(12, 6);
            this.FetchDataButton.Name = "FetchDataButton";
            this.FetchDataButton.Size = new System.Drawing.Size(37, 29);
            this.FetchDataButton.TabIndex = 0;
            this.FetchDataButton.UseVisualStyleBackColor = true;
            this.FetchDataButton.Click += new System.EventHandler(this.FetchDataButton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 541);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "met.no API Explorer";
            this.mainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FetchDataButton;
        private System.Windows.Forms.ListView nowcastListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView metalertsListView;
        private System.Windows.Forms.Label LocationAddressLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

