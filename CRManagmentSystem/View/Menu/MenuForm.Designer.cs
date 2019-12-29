namespace CRManagmentSystem.Menu
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnFacility = new System.Windows.Forms.Button();
            this.grbMenu = new System.Windows.Forms.GroupBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.panelDeviceManagement = new System.Windows.Forms.Panel();
            this.lblDeviceManagement = new System.Windows.Forms.Label();
            this.btnDeviceManagement = new System.Windows.Forms.Button();
            this.panelFacilitySystem = new System.Windows.Forms.Panel();
            this.btnFacilitySystem = new System.Windows.Forms.Button();
            this.lblFacilitySystem = new System.Windows.Forms.Label();
            this.panelPostManagement = new System.Windows.Forms.Panel();
            this.btnPostManagement = new System.Windows.Forms.Button();
            this.lblPostManagement = new System.Windows.Forms.Label();
            this.panelFacilityManagement = new System.Windows.Forms.Panel();
            this.lblFacilityManagement = new System.Windows.Forms.Label();
            this.btnFacilityManagement = new System.Windows.Forms.Button();
            this.panelRoleManagement = new System.Windows.Forms.Panel();
            this.lblRoleManagement = new System.Windows.Forms.Label();
            this.btnRoleManagement = new System.Windows.Forms.Button();
            this.panelUserManagement = new System.Windows.Forms.Panel();
            this.lblUserManagement = new System.Windows.Forms.Label();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.grbFunction = new System.Windows.Forms.GroupBox();
            this.grbMenu.SuspendLayout();
            this.panelDeviceManagement.SuspendLayout();
            this.panelFacilitySystem.SuspendLayout();
            this.panelPostManagement.SuspendLayout();
            this.panelFacilityManagement.SuspendLayout();
            this.panelRoleManagement.SuspendLayout();
            this.panelUserManagement.SuspendLayout();
            this.grbFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFacility
            // 
            this.btnFacility.Location = new System.Drawing.Point(11, 17);
            this.btnFacility.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacility.Name = "btnFacility";
            this.btnFacility.Size = new System.Drawing.Size(110, 40);
            this.btnFacility.TabIndex = 1;
            this.btnFacility.Text = "設備";
            this.btnFacility.UseVisualStyleBackColor = true;
            this.btnFacility.Click += new System.EventHandler(this.btnFacility_Click);
            // 
            // grbMenu
            // 
            this.grbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbMenu.Controls.Add(this.btnFinish);
            this.grbMenu.Controls.Add(this.btnMaintenance);
            this.grbMenu.Controls.Add(this.btnFacility);
            this.grbMenu.Location = new System.Drawing.Point(0, -6);
            this.grbMenu.Name = "grbMenu";
            this.grbMenu.Size = new System.Drawing.Size(133, 576);
            this.grbMenu.TabIndex = 1;
            this.grbMenu.TabStop = false;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFinish.Location = new System.Drawing.Point(11, 525);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 20);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(110, 40);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "終了";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(11, 61);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(110, 40);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "メンテナンス";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // panelDeviceManagement
            // 
            this.panelDeviceManagement.BackColor = System.Drawing.Color.White;
            this.panelDeviceManagement.Controls.Add(this.lblDeviceManagement);
            this.panelDeviceManagement.Controls.Add(this.btnDeviceManagement);
            this.panelDeviceManagement.Location = new System.Drawing.Point(6, 120);
            this.panelDeviceManagement.Name = "panelDeviceManagement";
            this.panelDeviceManagement.Size = new System.Drawing.Size(100, 100);
            this.panelDeviceManagement.TabIndex = 5;
            // 
            // lblDeviceManagement
            // 
            this.lblDeviceManagement.AutoSize = true;
            this.lblDeviceManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeviceManagement.Location = new System.Drawing.Point(22, 70);
            this.lblDeviceManagement.Name = "lblDeviceManagement";
            this.lblDeviceManagement.Size = new System.Drawing.Size(55, 13);
            this.lblDeviceManagement.TabIndex = 2;
            this.lblDeviceManagement.Text = "装置管理";
            this.lblDeviceManagement.Click += new System.EventHandler(this.lblDeviceManagement_Click);
            // 
            // btnDeviceManagement
            // 
            this.btnDeviceManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnDeviceManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeviceManagement.BackgroundImage")));
            this.btnDeviceManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeviceManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeviceManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeviceManagement.FlatAppearance.BorderSize = 0;
            this.btnDeviceManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeviceManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeviceManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeviceManagement.Location = new System.Drawing.Point(25, 8);
            this.btnDeviceManagement.Name = "btnDeviceManagement";
            this.btnDeviceManagement.Padding = new System.Windows.Forms.Padding(5);
            this.btnDeviceManagement.Size = new System.Drawing.Size(50, 50);
            this.btnDeviceManagement.TabIndex = 4;
            this.btnDeviceManagement.Text = "1";
            this.btnDeviceManagement.UseVisualStyleBackColor = false;
            this.btnDeviceManagement.Click += new System.EventHandler(this.btnDeviceManagement_Click);
            // 
            // panelFacilitySystem
            // 
            this.panelFacilitySystem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelFacilitySystem.Controls.Add(this.btnFacilitySystem);
            this.panelFacilitySystem.Controls.Add(this.lblFacilitySystem);
            this.panelFacilitySystem.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelFacilitySystem.Location = new System.Drawing.Point(6, 11);
            this.panelFacilitySystem.Name = "panelFacilitySystem";
            this.panelFacilitySystem.Size = new System.Drawing.Size(100, 100);
            this.panelFacilitySystem.TabIndex = 6;
            // 
            // btnFacilitySystem
            // 
            this.btnFacilitySystem.BackColor = System.Drawing.Color.Transparent;
            this.btnFacilitySystem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacilitySystem.BackgroundImage")));
            this.btnFacilitySystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacilitySystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacilitySystem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFacilitySystem.FlatAppearance.BorderSize = 0;
            this.btnFacilitySystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFacilitySystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFacilitySystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilitySystem.Location = new System.Drawing.Point(25, 8);
            this.btnFacilitySystem.Name = "btnFacilitySystem";
            this.btnFacilitySystem.Padding = new System.Windows.Forms.Padding(5);
            this.btnFacilitySystem.Size = new System.Drawing.Size(50, 50);
            this.btnFacilitySystem.TabIndex = 4;
            this.btnFacilitySystem.Text = "1";
            this.btnFacilitySystem.UseVisualStyleBackColor = false;
            this.btnFacilitySystem.Click += new System.EventHandler(this.btnFacilitySystem_Click);
            // 
            // lblFacilitySystem
            // 
            this.lblFacilitySystem.AutoSize = true;
            this.lblFacilitySystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFacilitySystem.Location = new System.Drawing.Point(16, 70);
            this.lblFacilitySystem.Name = "lblFacilitySystem";
            this.lblFacilitySystem.Size = new System.Drawing.Size(69, 13);
            this.lblFacilitySystem.TabIndex = 2;
            this.lblFacilitySystem.Text = "設備システム";
            this.lblFacilitySystem.Click += new System.EventHandler(this.lblFacilitySystem_Click);
            // 
            // panelPostManagement
            // 
            this.panelPostManagement.Controls.Add(this.btnPostManagement);
            this.panelPostManagement.Controls.Add(this.lblPostManagement);
            this.panelPostManagement.Location = new System.Drawing.Point(112, 11);
            this.panelPostManagement.Name = "panelPostManagement";
            this.panelPostManagement.Size = new System.Drawing.Size(100, 100);
            this.panelPostManagement.TabIndex = 7;
            // 
            // btnPostManagement
            // 
            this.btnPostManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnPostManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPostManagement.BackgroundImage")));
            this.btnPostManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPostManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPostManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPostManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPostManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostManagement.Location = new System.Drawing.Point(25, 8);
            this.btnPostManagement.Name = "btnPostManagement";
            this.btnPostManagement.Padding = new System.Windows.Forms.Padding(5);
            this.btnPostManagement.Size = new System.Drawing.Size(50, 50);
            this.btnPostManagement.TabIndex = 4;
            this.btnPostManagement.Text = "1";
            this.btnPostManagement.UseVisualStyleBackColor = false;
            this.btnPostManagement.Click += new System.EventHandler(this.btnPostManagement_Click);
            // 
            // lblPostManagement
            // 
            this.lblPostManagement.AutoSize = true;
            this.lblPostManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPostManagement.Location = new System.Drawing.Point(24, 70);
            this.lblPostManagement.Name = "lblPostManagement";
            this.lblPostManagement.Size = new System.Drawing.Size(55, 13);
            this.lblPostManagement.TabIndex = 2;
            this.lblPostManagement.Text = "区分管理";
            this.lblPostManagement.Click += new System.EventHandler(this.lblPostManagement_Click);
            // 
            // panelFacilityManagement
            // 
            this.panelFacilityManagement.Controls.Add(this.lblFacilityManagement);
            this.panelFacilityManagement.Controls.Add(this.btnFacilityManagement);
            this.panelFacilityManagement.Location = new System.Drawing.Point(218, 11);
            this.panelFacilityManagement.Name = "panelFacilityManagement";
            this.panelFacilityManagement.Size = new System.Drawing.Size(100, 100);
            this.panelFacilityManagement.TabIndex = 8;
            // 
            // lblFacilityManagement
            // 
            this.lblFacilityManagement.AutoSize = true;
            this.lblFacilityManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFacilityManagement.Location = new System.Drawing.Point(23, 70);
            this.lblFacilityManagement.Name = "lblFacilityManagement";
            this.lblFacilityManagement.Size = new System.Drawing.Size(55, 13);
            this.lblFacilityManagement.TabIndex = 2;
            this.lblFacilityManagement.Text = "設備管理";
            this.lblFacilityManagement.Click += new System.EventHandler(this.lblFacilityManagement_Click);
            // 
            // btnFacilityManagement
            // 
            this.btnFacilityManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnFacilityManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacilityManagement.BackgroundImage")));
            this.btnFacilityManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacilityManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacilityManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFacilityManagement.FlatAppearance.BorderSize = 0;
            this.btnFacilityManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFacilityManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFacilityManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacilityManagement.Location = new System.Drawing.Point(25, 8);
            this.btnFacilityManagement.Name = "btnFacilityManagement";
            this.btnFacilityManagement.Padding = new System.Windows.Forms.Padding(5);
            this.btnFacilityManagement.Size = new System.Drawing.Size(50, 50);
            this.btnFacilityManagement.TabIndex = 4;
            this.btnFacilityManagement.Text = "1";
            this.btnFacilityManagement.UseVisualStyleBackColor = false;
            this.btnFacilityManagement.Click += new System.EventHandler(this.btnFacilityManagement_Click);
            // 
            // panelRoleManagement
            // 
            this.panelRoleManagement.Controls.Add(this.lblRoleManagement);
            this.panelRoleManagement.Controls.Add(this.btnRoleManagement);
            this.panelRoleManagement.Location = new System.Drawing.Point(325, 11);
            this.panelRoleManagement.Name = "panelRoleManagement";
            this.panelRoleManagement.Size = new System.Drawing.Size(100, 100);
            this.panelRoleManagement.TabIndex = 9;
            // 
            // lblRoleManagement
            // 
            this.lblRoleManagement.AutoSize = true;
            this.lblRoleManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRoleManagement.Location = new System.Drawing.Point(22, 70);
            this.lblRoleManagement.Name = "lblRoleManagement";
            this.lblRoleManagement.Size = new System.Drawing.Size(60, 13);
            this.lblRoleManagement.TabIndex = 2;
            this.lblRoleManagement.Text = "ロール管理";
            this.lblRoleManagement.Click += new System.EventHandler(this.lblRoleManagement_Click);
            // 
            // btnRoleManagement
            // 
            this.btnRoleManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnRoleManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoleManagement.BackgroundImage")));
            this.btnRoleManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoleManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoleManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoleManagement.FlatAppearance.BorderSize = 0;
            this.btnRoleManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRoleManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRoleManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleManagement.Location = new System.Drawing.Point(25, 8);
            this.btnRoleManagement.Name = "btnRoleManagement";
            this.btnRoleManagement.Padding = new System.Windows.Forms.Padding(5);
            this.btnRoleManagement.Size = new System.Drawing.Size(50, 50);
            this.btnRoleManagement.TabIndex = 4;
            this.btnRoleManagement.Text = "1";
            this.btnRoleManagement.UseVisualStyleBackColor = false;
            this.btnRoleManagement.Click += new System.EventHandler(this.btnRoleManagement_Click);
            // 
            // panelUserManagement
            // 
            this.panelUserManagement.Controls.Add(this.lblUserManagement);
            this.panelUserManagement.Controls.Add(this.btnUserManagement);
            this.panelUserManagement.Location = new System.Drawing.Point(431, 11);
            this.panelUserManagement.Name = "panelUserManagement";
            this.panelUserManagement.Size = new System.Drawing.Size(100, 100);
            this.panelUserManagement.TabIndex = 10;
            // 
            // lblUserManagement
            // 
            this.lblUserManagement.AutoSize = true;
            this.lblUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserManagement.Location = new System.Drawing.Point(17, 70);
            this.lblUserManagement.Name = "lblUserManagement";
            this.lblUserManagement.Size = new System.Drawing.Size(71, 13);
            this.lblUserManagement.TabIndex = 2;
            this.lblUserManagement.Text = "ユーザー管理";
            this.lblUserManagement.Click += new System.EventHandler(this.lblUserManagement_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnUserManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserManagement.BackgroundImage")));
            this.btnUserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Location = new System.Drawing.Point(25, 8);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(5);
            this.btnUserManagement.Size = new System.Drawing.Size(50, 50);
            this.btnUserManagement.TabIndex = 4;
            this.btnUserManagement.Text = "1";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // grbFunction
            // 
            this.grbFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFunction.Controls.Add(this.panelUserManagement);
            this.grbFunction.Controls.Add(this.panelRoleManagement);
            this.grbFunction.Controls.Add(this.panelFacilityManagement);
            this.grbFunction.Controls.Add(this.panelPostManagement);
            this.grbFunction.Controls.Add(this.panelFacilitySystem);
            this.grbFunction.Controls.Add(this.panelDeviceManagement);
            this.grbFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbFunction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbFunction.Location = new System.Drawing.Point(136, -6);
            this.grbFunction.Name = "grbFunction";
            this.grbFunction.Size = new System.Drawing.Size(604, 576);
            this.grbFunction.TabIndex = 2;
            this.grbFunction.TabStop = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(733, 567);
            this.Controls.Add(this.grbFunction);
            this.Controls.Add(this.grbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "北上CR総合管理システム";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.grbMenu.ResumeLayout(false);
            this.panelDeviceManagement.ResumeLayout(false);
            this.panelDeviceManagement.PerformLayout();
            this.panelFacilitySystem.ResumeLayout(false);
            this.panelFacilitySystem.PerformLayout();
            this.panelPostManagement.ResumeLayout(false);
            this.panelPostManagement.PerformLayout();
            this.panelFacilityManagement.ResumeLayout(false);
            this.panelFacilityManagement.PerformLayout();
            this.panelRoleManagement.ResumeLayout(false);
            this.panelRoleManagement.PerformLayout();
            this.panelUserManagement.ResumeLayout(false);
            this.panelUserManagement.PerformLayout();
            this.grbFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFacility;
        private System.Windows.Forms.GroupBox grbMenu;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel panelDeviceManagement;
        private System.Windows.Forms.Label lblDeviceManagement;
        private System.Windows.Forms.Button btnDeviceManagement;
        private System.Windows.Forms.Panel panelFacilitySystem;
        private System.Windows.Forms.Button btnFacilitySystem;
        private System.Windows.Forms.Label lblFacilitySystem;
        private System.Windows.Forms.Panel panelPostManagement;
        private System.Windows.Forms.Button btnPostManagement;
        private System.Windows.Forms.Label lblPostManagement;
        private System.Windows.Forms.Panel panelFacilityManagement;
        private System.Windows.Forms.Label lblFacilityManagement;
        private System.Windows.Forms.Button btnFacilityManagement;
        private System.Windows.Forms.Panel panelRoleManagement;
        private System.Windows.Forms.Label lblRoleManagement;
        private System.Windows.Forms.Button btnRoleManagement;
        private System.Windows.Forms.Panel panelUserManagement;
        private System.Windows.Forms.Label lblUserManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.GroupBox grbFunction;
    }
}

