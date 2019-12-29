namespace CRManagmentSystem.View.FacilityManagement
{
    partial class DetailFacilityManagementForm
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
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPillar = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblEquipmentName = new System.Windows.Forms.Label();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.txtEquipmentID = new System.Windows.Forms.TextBox();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.cboEquipmentList = new System.Windows.Forms.ComboBox();
            this.cboStreet2 = new System.Windows.Forms.ComboBox();
            this.cboPillar2 = new System.Windows.Forms.ComboBox();
            this.cboFloor2 = new System.Windows.Forms.ComboBox();
            this.cboStreet1 = new System.Windows.Forms.ComboBox();
            this.cboPillar1 = new System.Windows.Forms.ComboBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.cboFloor1 = new System.Windows.Forms.ComboBox();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(654, 543);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStreet.Location = new System.Drawing.Point(53, 432);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(27, 13);
            this.lblStreet.TabIndex = 46;
            this.lblStreet.Text = "通り";
            // 
            // lblPillar
            // 
            this.lblPillar.AutoSize = true;
            this.lblPillar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPillar.Location = new System.Drawing.Point(53, 377);
            this.lblPillar.Name = "lblPillar";
            this.lblPillar.Size = new System.Drawing.Size(19, 13);
            this.lblPillar.TabIndex = 45;
            this.lblPillar.Text = "柱";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblArea.Location = new System.Drawing.Point(53, 325);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 44;
            this.lblArea.Text = "エリア";
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFloor.Location = new System.Drawing.Point(53, 270);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(31, 13);
            this.lblFloor.TabIndex = 43;
            this.lblFloor.Text = "階層";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPeriod.Location = new System.Drawing.Point(53, 219);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(19, 13);
            this.lblPeriod.TabIndex = 42;
            this.lblPeriod.Text = "期";
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEquipmentName.Location = new System.Drawing.Point(53, 156);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(43, 13);
            this.lblEquipmentName.TabIndex = 41;
            this.lblEquipmentName.Text = "設備名";
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEquipmentID.Location = new System.Drawing.Point(53, 101);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(42, 13);
            this.lblEquipmentID.TabIndex = 40;
            this.lblEquipmentID.Text = "設備ID";
            // 
            // lblEquipment
            // 
            this.lblEquipment.AutoSize = true;
            this.lblEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEquipment.Location = new System.Drawing.Point(40, 44);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(55, 13);
            this.lblEquipment.TabIndex = 39;
            this.lblEquipment.Text = "設備区分";
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtEquipmentID.Location = new System.Drawing.Point(140, 90);
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.ReadOnly = true;
            this.txtEquipmentID.Size = new System.Drawing.Size(345, 26);
            this.txtEquipmentID.TabIndex = 27;
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtEquipmentName.Location = new System.Drawing.Point(140, 145);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.ReadOnly = true;
            this.txtEquipmentName.Size = new System.Drawing.Size(345, 26);
            this.txtEquipmentName.TabIndex = 28;
            // 
            // cboEquipmentList
            // 
            this.cboEquipmentList.Enabled = false;
            this.cboEquipmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEquipmentList.FormattingEnabled = true;
            this.cboEquipmentList.Location = new System.Drawing.Point(140, 33);
            this.cboEquipmentList.Name = "cboEquipmentList";
            this.cboEquipmentList.Size = new System.Drawing.Size(345, 28);
            this.cboEquipmentList.TabIndex = 26;
            // 
            // cboStreet2
            // 
            this.cboStreet2.Enabled = false;
            this.cboStreet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet2.FormattingEnabled = true;
            this.cboStreet2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboStreet2.Location = new System.Drawing.Point(238, 421);
            this.cboStreet2.Name = "cboStreet2";
            this.cboStreet2.Size = new System.Drawing.Size(78, 28);
            this.cboStreet2.TabIndex = 36;
            // 
            // cboPillar2
            // 
            this.cboPillar2.Enabled = false;
            this.cboPillar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPillar2.FormattingEnabled = true;
            this.cboPillar2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboPillar2.Location = new System.Drawing.Point(238, 366);
            this.cboPillar2.Name = "cboPillar2";
            this.cboPillar2.Size = new System.Drawing.Size(78, 28);
            this.cboPillar2.TabIndex = 34;
            // 
            // cboFloor2
            // 
            this.cboFloor2.Enabled = false;
            this.cboFloor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloor2.FormattingEnabled = true;
            this.cboFloor2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboFloor2.Location = new System.Drawing.Point(238, 259);
            this.cboFloor2.Name = "cboFloor2";
            this.cboFloor2.Size = new System.Drawing.Size(78, 28);
            this.cboFloor2.TabIndex = 31;
            // 
            // cboStreet1
            // 
            this.cboStreet1.Enabled = false;
            this.cboStreet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStreet1.FormattingEnabled = true;
            this.cboStreet1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboStreet1.Location = new System.Drawing.Point(140, 421);
            this.cboStreet1.Name = "cboStreet1";
            this.cboStreet1.Size = new System.Drawing.Size(78, 28);
            this.cboStreet1.TabIndex = 35;
            // 
            // cboPillar1
            // 
            this.cboPillar1.Enabled = false;
            this.cboPillar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPillar1.FormattingEnabled = true;
            this.cboPillar1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboPillar1.Location = new System.Drawing.Point(140, 366);
            this.cboPillar1.Name = "cboPillar1";
            this.cboPillar1.Size = new System.Drawing.Size(78, 28);
            this.cboPillar1.TabIndex = 33;
            // 
            // cboArea
            // 
            this.cboArea.Enabled = false;
            this.cboArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(140, 314);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(78, 28);
            this.cboArea.TabIndex = 32;
            // 
            // cboFloor1
            // 
            this.cboFloor1.Enabled = false;
            this.cboFloor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFloor1.FormattingEnabled = true;
            this.cboFloor1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboFloor1.Location = new System.Drawing.Point(140, 259);
            this.cboFloor1.Name = "cboFloor1";
            this.cboFloor1.Size = new System.Drawing.Size(78, 28);
            this.cboFloor1.TabIndex = 30;
            // 
            // cboPeriod
            // 
            this.cboPeriod.Enabled = false;
            this.cboPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cboPeriod.Location = new System.Drawing.Point(140, 208);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(78, 28);
            this.cboPeriod.TabIndex = 29;
            // 
            // DetailFacilityManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblPillar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblEquipmentID);
            this.Controls.Add(this.lblEquipment);
            this.Controls.Add(this.txtEquipmentID);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.cboEquipmentList);
            this.Controls.Add(this.cboStreet2);
            this.Controls.Add(this.cboPillar2);
            this.Controls.Add(this.cboFloor2);
            this.Controls.Add(this.cboStreet1);
            this.Controls.Add(this.cboPillar1);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.cboFloor1);
            this.Controls.Add(this.cboPeriod);
            this.Name = "DetailFacilityManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteEquipmentManagement";
            this.Load += new System.EventHandler(this.DetailEquipmentManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPillar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblEquipmentName;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.TextBox txtEquipmentID;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.ComboBox cboEquipmentList;
        private System.Windows.Forms.ComboBox cboStreet2;
        private System.Windows.Forms.ComboBox cboPillar2;
        private System.Windows.Forms.ComboBox cboFloor2;
        private System.Windows.Forms.ComboBox cboStreet1;
        private System.Windows.Forms.ComboBox cboPillar1;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.ComboBox cboFloor1;
        private System.Windows.Forms.ComboBox cboPeriod;
    }
}