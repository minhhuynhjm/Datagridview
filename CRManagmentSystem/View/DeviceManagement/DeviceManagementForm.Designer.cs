namespace CRManagmentSystem.View.DeviceManagement
{
    partial class DeviceManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.cboStreet2 = new System.Windows.Forms.ComboBox();
            this.cboPillar2 = new System.Windows.Forms.ComboBox();
            this.cboFloor2 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboProcess = new System.Windows.Forms.ComboBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.cboStreet1 = new System.Windows.Forms.ComboBox();
            this.cboPillar1 = new System.Windows.Forms.ComboBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.cboFloor1 = new System.Windows.Forms.ComboBox();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPillar = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblTier = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.cboStreet2);
            this.grpSearch.Controls.Add(this.cboPillar2);
            this.grpSearch.Controls.Add(this.cboFloor2);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.cboProcess);
            this.grpSearch.Controls.Add(this.lblProcess);
            this.grpSearch.Controls.Add(this.cboStreet1);
            this.grpSearch.Controls.Add(this.cboPillar1);
            this.grpSearch.Controls.Add(this.cboArea);
            this.grpSearch.Controls.Add(this.cboFloor1);
            this.grpSearch.Controls.Add(this.cboPeriod);
            this.grpSearch.Controls.Add(this.lblStreet);
            this.grpSearch.Controls.Add(this.lblPillar);
            this.grpSearch.Controls.Add(this.lblArea);
            this.grpSearch.Controls.Add(this.lblTier);
            this.grpSearch.Controls.Add(this.lblPeriod);
            this.grpSearch.Controls.Add(this.txtDeviceName);
            this.grpSearch.Controls.Add(this.lblEquipmentName);
            this.grpSearch.Controls.Add(this.txtDeviceId);
            this.grpSearch.Controls.Add(this.lblDeviceId);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(8, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(722, 122);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "検索条件";
            // 
            // cboStreet2
            // 
            this.cboStreet2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet2.FormattingEnabled = true;
            this.cboStreet2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboStreet2.Location = new System.Drawing.Point(562, 58);
            this.cboStreet2.Name = "cboStreet2";
            this.cboStreet2.Size = new System.Drawing.Size(36, 24);
            this.cboStreet2.TabIndex = 16;
            // 
            // cboPillar2
            // 
            this.cboPillar2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPillar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPillar2.FormattingEnabled = true;
            this.cboPillar2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboPillar2.Location = new System.Drawing.Point(432, 58);
            this.cboPillar2.Name = "cboPillar2";
            this.cboPillar2.Size = new System.Drawing.Size(36, 24);
            this.cboPillar2.TabIndex = 13;
            // 
            // cboFloor2
            // 
            this.cboFloor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloor2.FormattingEnabled = true;
            this.cboFloor2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboFloor2.Location = new System.Drawing.Point(222, 58);
            this.cboFloor2.Name = "cboFloor2";
            this.cboFloor2.Size = new System.Drawing.Size(36, 24);
            this.cboFloor2.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(637, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 26);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboProcess
            // 
            this.cboProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProcess.FormattingEnabled = true;
            this.cboProcess.Location = new System.Drawing.Point(88, 87);
            this.cboProcess.Name = "cboProcess";
            this.cboProcess.Size = new System.Drawing.Size(201, 24);
            this.cboProcess.TabIndex = 18;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(44, 90);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(38, 16);
            this.lblProcess.TabIndex = 17;
            this.lblProcess.Text = "工程";
            // 
            // cboStreet1
            // 
            this.cboStreet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet1.FormattingEnabled = true;
            this.cboStreet1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboStreet1.Location = new System.Drawing.Point(520, 58);
            this.cboStreet1.Name = "cboStreet1";
            this.cboStreet1.Size = new System.Drawing.Size(36, 24);
            this.cboStreet1.TabIndex = 15;
            // 
            // cboPillar1
            // 
            this.cboPillar1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPillar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPillar1.FormattingEnabled = true;
            this.cboPillar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboPillar1.Location = new System.Drawing.Point(390, 58);
            this.cboPillar1.Name = "cboPillar1";
            this.cboPillar1.Size = new System.Drawing.Size(36, 24);
            this.cboPillar1.TabIndex = 12;
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboArea.Location = new System.Drawing.Point(314, 58);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(36, 24);
            this.cboArea.TabIndex = 10;
            // 
            // cboFloor1
            // 
            this.cboFloor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloor1.FormattingEnabled = true;
            this.cboFloor1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboFloor1.Location = new System.Drawing.Point(180, 58);
            this.cboFloor1.Name = "cboFloor1";
            this.cboFloor1.Size = new System.Drawing.Size(36, 24);
            this.cboFloor1.TabIndex = 7;
            // 
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboPeriod.Location = new System.Drawing.Point(89, 58);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(36, 24);
            this.cboPeriod.TabIndex = 5;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(482, 61);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(32, 16);
            this.lblStreet.TabIndex = 14;
            this.lblStreet.Text = "通り";
            // 
            // lblPillar
            // 
            this.lblPillar.AutoSize = true;
            this.lblPillar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPillar.Location = new System.Drawing.Point(361, 61);
            this.lblPillar.Name = "lblPillar";
            this.lblPillar.Size = new System.Drawing.Size(23, 16);
            this.lblPillar.TabIndex = 11;
            this.lblPillar.Text = "柱";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(269, 61);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "エリア";
            // 
            // lblTier
            // 
            this.lblTier.AutoSize = true;
            this.lblTier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTier.Location = new System.Drawing.Point(143, 61);
            this.lblTier.Name = "lblTier";
            this.lblTier.Size = new System.Drawing.Size(38, 16);
            this.lblTier.TabIndex = 6;
            this.lblTier.Text = "階層";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(59, 61);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(23, 16);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "期";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(353, 27);
            this.txtDeviceName.MaxLength = 12;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(201, 22);
            this.txtDeviceName.TabIndex = 3;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(297, 30);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(53, 16);
            this.lblEquipmentName.TabIndex = 2;
            this.lblEquipmentName.Text = "装置名";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDeviceId.Location = new System.Drawing.Point(88, 27);
            this.txtDeviceId.MaxLength = 10;
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(201, 22);
            this.txtDeviceId.TabIndex = 1;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceId.Location = new System.Drawing.Point(31, 30);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(51, 16);
            this.lblDeviceId.TabIndex = 0;
            this.lblDeviceId.Text = "装置ID";
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDevice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDevice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDevice.Location = new System.Drawing.Point(8, 158);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.ReadOnly = true;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(722, 377);
            this.dgvDevice.TabIndex = 1;
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(8, 539);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(85, 26);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "詳細";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(190, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 26);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(281, 539);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 26);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(645, 539);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(99, 539);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(372, 539);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "エクスポート";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DeviceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(733, 567);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.dgvDevice);
            this.Controls.Add(this.grpSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeviceManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "装置メンテナンス";
            this.Load += new System.EventHandler(this.DeviceMaintenanceForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblTier;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPillar;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.ComboBox cboStreet1;
        private System.Windows.Forms.ComboBox cboPillar1;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.ComboBox cboFloor1;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ComboBox cboProcess;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cboFloor2;
        private System.Windows.Forms.ComboBox cboPillar2;
        private System.Windows.Forms.ComboBox cboStreet2;
    }
}