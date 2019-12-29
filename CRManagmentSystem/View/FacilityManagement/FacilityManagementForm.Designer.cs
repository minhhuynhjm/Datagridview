namespace CRManagmentSystem.View.FacilityManagement
{
    partial class FacilityManagementForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.cboEquipmentList = new System.Windows.Forms.ComboBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(664, 548);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(120, 548);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AllowUserToDeleteRows = false;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Location = new System.Drawing.Point(6, 158);
            this.dgvEquipment.MultiSelect = false;
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.ReadOnly = true;
            this.dgvEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipment.Size = new System.Drawing.Size(748, 376);
            this.dgvEquipment.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(664, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEquipmentName.Location = new System.Drawing.Point(68, 108);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(345, 26);
            this.txtEquipmentName.TabIndex = 2;
            this.txtEquipmentName.TextChanged += new System.EventHandler(this.txtEquipmentName_TextChanged);
            // 
            // cboEquipmentList
            // 
            this.cboEquipmentList.BackColor = System.Drawing.Color.White;
            this.cboEquipmentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEquipmentList.FormattingEnabled = true;
            this.cboEquipmentList.Location = new System.Drawing.Point(68, 27);
            this.cboEquipmentList.Name = "cboEquipmentList";
            this.cboEquipmentList.Size = new System.Drawing.Size(345, 28);
            this.cboEquipmentList.TabIndex = 0;
            this.cboEquipmentList.TextChanged += new System.EventHandler(this.cboEquipmentList_TextChanged);
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Location = new System.Drawing.Point(6, 116);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(43, 13);
            this.lblEquipmentName.TabIndex = 2;
            this.lblEquipmentName.Text = "設備名";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Location = new System.Drawing.Point(6, 75);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(42, 13);
            this.lblEquipmentID.TabIndex = 1;
            this.lblEquipmentID.Text = "設備ID";
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.Location = new System.Drawing.Point(7, 35);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(55, 13);
            this.lblEquipment.TabIndex = 0;
            this.lblEquipment.Text = "設備区分";
            // 
            // grpBox
            // 
            this.grpBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBox.Controls.Add(this.txtEquipmentID);
            this.grpBox.Controls.Add(this.btnDetail);
            this.grpBox.Controls.Add(this.btnExport);
            this.grpBox.Controls.Add(this.btnDelete);
            this.grpBox.Controls.Add(this.btnUpdate);
            this.grpBox.Controls.Add(this.btnClose);
            this.grpBox.Controls.Add(this.btnAdd);
            this.grpBox.Controls.Add(this.dgvEquipment);
            this.grpBox.Controls.Add(this.btnSearch);
            this.grpBox.Controls.Add(this.txtEquipmentName);
            this.grpBox.Controls.Add(this.cboEquipmentList);
            this.grpBox.Controls.Add(this.lblEquipmentName);
            this.grpBox.Controls.Add(this.lblEquipmentID);
            this.grpBox.Controls.Add(this.lblEquipment);
            this.grpBox.Location = new System.Drawing.Point(12, 12);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(760, 587);
            this.grpBox.TabIndex = 12;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "検索条件";
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEquipmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtEquipmentID.Location = new System.Drawing.Point(68, 67);
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.Size = new System.Drawing.Size(345, 26);
            this.txtEquipmentID.TabIndex = 1;
            this.txtEquipmentID.TextChanged += new System.EventHandler(this.txtEquipmentID_TextChanged);
            // 
            // btnDetail
            // 
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Location = new System.Drawing.Point(6, 548);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(90, 35);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "詳細";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(465, 548);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 35);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "エクスポート";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(350, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(235, 548);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FacilityManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.grpBox);
            this.Name = "FacilityManagementForm";
            this.Text = "EquipmentManagement";
            this.Load += new System.EventHandler(this.EquipmentManagement_Load);
            this.Shown += new System.EventHandler(this.EquipmentManagementForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.ComboBox cboEquipmentList;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.TextBox txtEquipmentID;
    }
}