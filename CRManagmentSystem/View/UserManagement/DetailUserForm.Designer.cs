namespace CRManagmentSystem.View.UserManagement
{
    partial class DetailUserForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.dgvDetailUser = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(96, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 15);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(80, 132);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(31, 15);
            this.lblFullName.TabIndex = 4;
            this.lblFullName.Text = "氏名";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(80, 172);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(31, 15);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "部署";
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Location = new System.Drawing.Point(26, 91);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(78, 15);
            this.lblPasswordConfirm.TabIndex = 3;
            this.lblPasswordConfirm.Text = "パスワード確認";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(54, 53);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "パスワード";
            // 
            // txtPassword
            // 
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPassword.Location = new System.Drawing.Point(124, 53);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(217, 21);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFullName
            // 
            this.txtFullName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtFullName.Location = new System.Drawing.Point(124, 132);
            this.txtFullName.MaxLength = 25;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(217, 21);
            this.txtFullName.TabIndex = 9;
            // 
            // txtId
            // 
            this.txtId.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtId.Location = new System.Drawing.Point(124, 14);
            this.txtId.MaxLength = 10;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(149, 21);
            this.txtId.TabIndex = 6;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPasswordConfirm.Location = new System.Drawing.Point(124, 91);
            this.txtPasswordConfirm.MaxLength = 16;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.ReadOnly = true;
            this.txtPasswordConfirm.Size = new System.Drawing.Size(217, 21);
            this.txtPasswordConfirm.TabIndex = 8;
            this.txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // dgvDetailUser
            // 
            this.dgvDetailUser.AllowUserToAddRows = false;
            this.dgvDetailUser.AllowUserToDeleteRows = false;
            this.dgvDetailUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailUser.Location = new System.Drawing.Point(7, 237);
            this.dgvDetailUser.MultiSelect = false;
            this.dgvDetailUser.Name = "dgvDetailUser";
            this.dgvDetailUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetailUser.Size = new System.Drawing.Size(842, 370);
            this.dgvDetailUser.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(764, 616);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 26);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Enabled = false;
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboDepartment.Location = new System.Drawing.Point(124, 172);
            this.cboDepartment.MaxLength = 10;
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(217, 23);
            this.cboDepartment.TabIndex = 10;
            // 
            // DetailUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 654);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDetailUser);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPasswordConfirm);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DetailUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ユーザー詳細画面";
            this.Load += new System.EventHandler(this.DetailUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.DataGridView dgvDetailUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboDepartment;
    }
}