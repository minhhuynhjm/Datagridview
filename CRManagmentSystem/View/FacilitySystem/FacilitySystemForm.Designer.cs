namespace CRManagmentSystem.View.FacilitySystem
{
    partial class FacilitySystemForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboStreet2 = new System.Windows.Forms.ComboBox();
            this.cboStreet1 = new System.Windows.Forms.ComboBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.cboPillar2 = new System.Windows.Forms.ComboBox();
            this.cboPillar1 = new System.Windows.Forms.ComboBox();
            this.lblPillar = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTier2 = new System.Windows.Forms.ComboBox();
            this.cboTier1 = new System.Windows.Forms.ComboBox();
            this.lblTier = new System.Windows.Forms.Label();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.txtSystemValue = new System.Windows.Forms.TextBox();
            this.cboSystemType = new System.Windows.Forms.ComboBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.dgvListFacility = new System.Windows.Forms.DataGridView();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnSystemEditing = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFacility)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.cboStreet2);
            this.grpSearch.Controls.Add(this.cboStreet1);
            this.grpSearch.Controls.Add(this.lblStreet);
            this.grpSearch.Controls.Add(this.cboPillar2);
            this.grpSearch.Controls.Add(this.cboPillar1);
            this.grpSearch.Controls.Add(this.lblPillar);
            this.grpSearch.Controls.Add(this.cboArea);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.cboTier2);
            this.grpSearch.Controls.Add(this.cboTier1);
            this.grpSearch.Controls.Add(this.lblTier);
            this.grpSearch.Controls.Add(this.cboPeriod);
            this.grpSearch.Controls.Add(this.lblPeriod);
            this.grpSearch.Controls.Add(this.txtEquipmentName);
            this.grpSearch.Controls.Add(this.lblEquipmentName);
            this.grpSearch.Controls.Add(this.txtSystemValue);
            this.grpSearch.Controls.Add(this.cboSystemType);
            this.grpSearch.Controls.Add(this.lblSystem);
            this.grpSearch.Controls.Add(this.txtDeviceId);
            this.grpSearch.Controls.Add(this.lblDeviceId);
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(742, 159);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "検索条件";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(646, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStreet2
            // 
            this.cboStreet2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet2.FormattingEnabled = true;
            this.cboStreet2.Location = new System.Drawing.Point(556, 125);
            this.cboStreet2.Name = "cboStreet2";
            this.cboStreet2.Size = new System.Drawing.Size(40, 24);
            this.cboStreet2.TabIndex = 19;
            // 
            // cboStreet1
            // 
            this.cboStreet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet1.FormattingEnabled = true;
            this.cboStreet1.Location = new System.Drawing.Point(510, 125);
            this.cboStreet1.Name = "cboStreet1";
            this.cboStreet1.Size = new System.Drawing.Size(40, 24);
            this.cboStreet1.TabIndex = 18;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(472, 129);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(32, 18);
            this.lblStreet.TabIndex = 17;
            this.lblStreet.Text = "通り";
            this.lblStreet.UseMnemonic = false;
            // 
            // cboPillar2
            // 
            this.cboPillar2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPillar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPillar2.FormattingEnabled = true;
            this.cboPillar2.Location = new System.Drawing.Point(426, 125);
            this.cboPillar2.Name = "cboPillar2";
            this.cboPillar2.Size = new System.Drawing.Size(40, 24);
            this.cboPillar2.TabIndex = 16;
            // 
            // cboPillar1
            // 
            this.cboPillar1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPillar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPillar1.FormattingEnabled = true;
            this.cboPillar1.Location = new System.Drawing.Point(380, 125);
            this.cboPillar1.Name = "cboPillar1";
            this.cboPillar1.Size = new System.Drawing.Size(40, 24);
            this.cboPillar1.TabIndex = 15;
            // 
            // lblPillar
            // 
            this.lblPillar.AutoSize = true;
            this.lblPillar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPillar.Location = new System.Drawing.Point(351, 129);
            this.lblPillar.Name = "lblPillar";
            this.lblPillar.Size = new System.Drawing.Size(23, 18);
            this.lblPillar.TabIndex = 14;
            this.lblPillar.Text = "柱";
            this.lblPillar.UseMnemonic = false;
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(305, 125);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(40, 24);
            this.cboArea.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "エリア";
            // 
            // cboTier2
            // 
            this.cboTier2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTier2.FormattingEnabled = true;
            this.cboTier2.Location = new System.Drawing.Point(214, 125);
            this.cboTier2.Name = "cboTier2";
            this.cboTier2.Size = new System.Drawing.Size(40, 24);
            this.cboTier2.TabIndex = 11;
            // 
            // cboTier1
            // 
            this.cboTier1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTier1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTier1.FormattingEnabled = true;
            this.cboTier1.Location = new System.Drawing.Point(168, 125);
            this.cboTier1.Name = "cboTier1";
            this.cboTier1.Size = new System.Drawing.Size(40, 24);
            this.cboTier1.TabIndex = 10;
            // 
            // lblTier
            // 
            this.lblTier.AutoSize = true;
            this.lblTier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTier.Location = new System.Drawing.Point(124, 129);
            this.lblTier.Name = "lblTier";
            this.lblTier.Size = new System.Drawing.Size(38, 18);
            this.lblTier.TabIndex = 9;
            this.lblTier.Text = "階層";
            // 
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(78, 125);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(40, 24);
            this.cboPeriod.TabIndex = 8;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(42, 129);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(23, 18);
            this.lblPeriod.TabIndex = 7;
            this.lblPeriod.Text = "期";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentName.Location = new System.Drawing.Point(78, 90);
            this.txtEquipmentName.MaxLength = 12;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(191, 24);
            this.txtEquipmentName.TabIndex = 6;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(30, 93);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(38, 18);
            this.lblEquipmentName.TabIndex = 5;
            this.lblEquipmentName.Text = "系統";
            // 
            // txtSystemValue
            // 
            this.txtSystemValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSystemValue.Location = new System.Drawing.Point(226, 59);
            this.txtSystemValue.Name = "txtSystemValue";
            this.txtSystemValue.Size = new System.Drawing.Size(240, 24);
            this.txtSystemValue.TabIndex = 4;
            // 
            // cboSystemType
            // 
            this.cboSystemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSystemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSystemType.FormattingEnabled = true;
            this.cboSystemType.Location = new System.Drawing.Point(78, 59);
            this.cboSystemType.Name = "cboSystemType";
            this.cboSystemType.Size = new System.Drawing.Size(142, 24);
            this.cboSystemType.TabIndex = 3;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(27, 61);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(38, 18);
            this.lblSystem.TabIndex = 2;
            this.lblSystem.Text = "系統";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceId.Location = new System.Drawing.Point(78, 26);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(191, 24);
            this.txtDeviceId.TabIndex = 1;
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceId.Location = new System.Drawing.Point(13, 29);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(52, 18);
            this.lblDeviceId.TabIndex = 0;
            this.lblDeviceId.Text = "装置ID";
            // 
            // dgvListFacility
            // 
            this.dgvListFacility.AllowUserToAddRows = false;
            this.dgvListFacility.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListFacility.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListFacility.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListFacility.Location = new System.Drawing.Point(12, 181);
            this.dgvListFacility.MultiSelect = false;
            this.dgvListFacility.Name = "dgvListFacility";
            this.dgvListFacility.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListFacility.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListFacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListFacility.Size = new System.Drawing.Size(742, 365);
            this.dgvListFacility.TabIndex = 1;
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(12, 565);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(90, 30);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "詳細";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.Location = new System.Drawing.Point(108, 565);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(90, 30);
            this.btnSystem.TabIndex = 3;
            this.btnSystem.Text = "系統";
            this.btnSystem.UseVisualStyleBackColor = true;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnMap
            // 
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(204, 565);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(100, 30);
            this.btnMap.TabIndex = 4;
            this.btnMap.Text = "マップ表示";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnSystemEditing
            // 
            this.btnSystemEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemEditing.Location = new System.Drawing.Point(310, 565);
            this.btnSystemEditing.Name = "btnSystemEditing";
            this.btnSystemEditing.Size = new System.Drawing.Size(100, 30);
            this.btnSystemEditing.TabIndex = 5;
            this.btnSystemEditing.Text = "系統編集";
            this.btnSystemEditing.UseVisualStyleBackColor = true;
            this.btnSystemEditing.Click += new System.EventHandler(this.btnSystemEditing_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(416, 565);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "エクスポート";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(664, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FacilitySystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 607);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSystemEditing);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnSystem);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.dgvListFacility);
            this.Controls.Add(this.grpSearch);
            this.Name = "FacilitySystemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacilitySystemForm";
            this.Load += new System.EventHandler(this.FacilitySystemForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFacility)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.ComboBox cboSystemType;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.TextBox txtSystemValue;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboStreet2;
        private System.Windows.Forms.ComboBox cboStreet1;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cboPillar2;
        private System.Windows.Forms.ComboBox cboPillar1;
        private System.Windows.Forms.Label lblPillar;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTier2;
        private System.Windows.Forms.ComboBox cboTier1;
        private System.Windows.Forms.Label lblTier;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.DataGridView dgvListFacility;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnSystemEditing;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
    }
}