namespace CRManagmentSystem.View.DeviceManagement
{
    partial class AddDeviceForm
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
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPillar = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblProcess = new System.Windows.Forms.Label();
            this.cboProcess = new System.Windows.Forms.ComboBox();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.cboFloor1 = new System.Windows.Forms.ComboBox();
            this.cboFloor2 = new System.Windows.Forms.ComboBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.cboPillar1 = new System.Windows.Forms.ComboBox();
            this.cboPillar2 = new System.Windows.Forms.ComboBox();
            this.cboStreet1 = new System.Windows.Forms.ComboBox();
            this.cboStreet2 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceId.Location = new System.Drawing.Point(25, 9);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(51, 16);
            this.lblDeviceId.TabIndex = 0;
            this.lblDeviceId.Text = "装置ID";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDeviceId.Location = new System.Drawing.Point(82, 6);
            this.txtDeviceId.MaxLength = 10;
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(201, 22);
            this.txtDeviceId.TabIndex = 1;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipmentName.Location = new System.Drawing.Point(23, 37);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(53, 16);
            this.lblEquipmentName.TabIndex = 2;
            this.lblEquipmentName.Text = "装置名";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(82, 34);
            this.txtDeviceName.MaxLength = 12;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(201, 22);
            this.txtDeviceName.TabIndex = 3;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(53, 64);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(23, 16);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "期";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.Location = new System.Drawing.Point(38, 90);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(38, 16);
            this.lblFloor.TabIndex = 6;
            this.lblFloor.Text = "階層";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(37, 117);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(39, 16);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "エリア";
            // 
            // lblPillar
            // 
            this.lblPillar.AutoSize = true;
            this.lblPillar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPillar.Location = new System.Drawing.Point(53, 144);
            this.lblPillar.Name = "lblPillar";
            this.lblPillar.Size = new System.Drawing.Size(23, 16);
            this.lblPillar.TabIndex = 11;
            this.lblPillar.Text = "柱";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(44, 171);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(32, 16);
            this.lblStreet.TabIndex = 14;
            this.lblStreet.Text = "通り";
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(38, 198);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(38, 16);
            this.lblProcess.TabIndex = 17;
            this.lblProcess.Text = "工程";
            // 
            // cboProcess
            // 
            this.cboProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProcess.FormattingEnabled = true;
            this.cboProcess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboProcess.Location = new System.Drawing.Point(82, 195);
            this.cboProcess.Name = "cboProcess";
            this.cboProcess.Size = new System.Drawing.Size(201, 24);
            this.cboProcess.TabIndex = 18;
            // 
            // cboPeriod
            // 
            this.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboPeriod.Location = new System.Drawing.Point(82, 61);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(47, 24);
            this.cboPeriod.TabIndex = 5;
            // 
            // cboFloor1
            // 
            this.cboFloor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloor1.FormattingEnabled = true;
            this.cboFloor1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboFloor1.Location = new System.Drawing.Point(82, 87);
            this.cboFloor1.Name = "cboFloor1";
            this.cboFloor1.Size = new System.Drawing.Size(47, 24);
            this.cboFloor1.TabIndex = 7;
            // 
            // cboFloor2
            // 
            this.cboFloor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFloor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloor2.FormattingEnabled = true;
            this.cboFloor2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboFloor2.Location = new System.Drawing.Point(135, 87);
            this.cboFloor2.Name = "cboFloor2";
            this.cboFloor2.Size = new System.Drawing.Size(47, 24);
            this.cboFloor2.TabIndex = 8;
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(82, 114);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(47, 24);
            this.cboArea.TabIndex = 10;
            // 
            // cboPillar1
            // 
            this.cboPillar1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPillar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPillar1.FormattingEnabled = true;
            this.cboPillar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboPillar1.Location = new System.Drawing.Point(82, 141);
            this.cboPillar1.Name = "cboPillar1";
            this.cboPillar1.Size = new System.Drawing.Size(47, 24);
            this.cboPillar1.TabIndex = 12;
            // 
            // cboPillar2
            // 
            this.cboPillar2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPillar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPillar2.FormattingEnabled = true;
            this.cboPillar2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboPillar2.Location = new System.Drawing.Point(135, 141);
            this.cboPillar2.Name = "cboPillar2";
            this.cboPillar2.Size = new System.Drawing.Size(47, 24);
            this.cboPillar2.TabIndex = 13;
            // 
            // cboStreet1
            // 
            this.cboStreet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet1.FormattingEnabled = true;
            this.cboStreet1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboStreet1.Location = new System.Drawing.Point(82, 168);
            this.cboStreet1.Name = "cboStreet1";
            this.cboStreet1.Size = new System.Drawing.Size(47, 24);
            this.cboStreet1.TabIndex = 15;
            // 
            // cboStreet2
            // 
            this.cboStreet2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStreet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet2.FormattingEnabled = true;
            this.cboStreet2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboStreet2.Location = new System.Drawing.Point(135, 168);
            this.cboStreet2.Name = "cboStreet2";
            this.cboStreet2.Size = new System.Drawing.Size(47, 24);
            this.cboStreet2.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(636, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 26);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 533);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 26);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(733, 567);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboStreet2);
            this.Controls.Add(this.cboStreet1);
            this.Controls.Add(this.cboPillar2);
            this.Controls.Add(this.cboPillar1);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.cboFloor2);
            this.Controls.Add(this.cboFloor1);
            this.Controls.Add(this.cboPeriod);
            this.Controls.Add(this.cboProcess);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblPillar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.lblDeviceId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDeviceForm";
            this.Load += new System.EventHandler(this.AddDeviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPillar;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.ComboBox cboProcess;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.ComboBox cboFloor1;
        private System.Windows.Forms.ComboBox cboFloor2;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.ComboBox cboPillar1;
        private System.Windows.Forms.ComboBox cboPillar2;
        private System.Windows.Forms.ComboBox cboStreet1;
        private System.Windows.Forms.ComboBox cboStreet2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
    }
}