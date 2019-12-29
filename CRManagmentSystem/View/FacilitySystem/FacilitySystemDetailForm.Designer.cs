namespace CRManagmentSystem.View.FacilitySystem
{
    partial class FacilitySystemDetailForm
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
            this.lblCondition = new System.Windows.Forms.Label();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControlFacilitySystem = new System.Windows.Forms.TabControl();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnSelectLineSearch = new System.Windows.Forms.Button();
            this.btnAddPattern = new System.Windows.Forms.Button();
            this.btnDeletePattern = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(12, 24);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(38, 16);
            this.lblCondition.TabIndex = 0;
            this.lblCondition.Text = "条件";
            // 
            // txtCondition
            // 
            this.txtCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.Location = new System.Drawing.Point(49, 19);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ReadOnly = true;
            this.txtCondition.Size = new System.Drawing.Size(686, 22);
            this.txtCondition.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(741, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControlFacilitySystem
            // 
            this.tabControlFacilitySystem.Location = new System.Drawing.Point(12, 51);
            this.tabControlFacilitySystem.Name = "tabControlFacilitySystem";
            this.tabControlFacilitySystem.SelectedIndex = 0;
            this.tabControlFacilitySystem.Size = new System.Drawing.Size(819, 486);
            this.tabControlFacilitySystem.TabIndex = 3;
            // 
            // btnMap
            // 
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Location = new System.Drawing.Point(12, 545);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(90, 30);
            this.btnMap.TabIndex = 4;
            this.btnMap.Text = "マップ表示";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnSelectLineSearch
            // 
            this.btnSelectLineSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLineSearch.Location = new System.Drawing.Point(108, 545);
            this.btnSelectLineSearch.Name = "btnSelectLineSearch";
            this.btnSelectLineSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSelectLineSearch.TabIndex = 5;
            this.btnSelectLineSearch.Text = "選択系統検索";
            this.btnSelectLineSearch.UseVisualStyleBackColor = true;
            this.btnSelectLineSearch.Click += new System.EventHandler(this.btnSelectLineSearch_Click);
            // 
            // btnAddPattern
            // 
            this.btnAddPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPattern.Location = new System.Drawing.Point(224, 545);
            this.btnAddPattern.Name = "btnAddPattern";
            this.btnAddPattern.Size = new System.Drawing.Size(110, 30);
            this.btnAddPattern.TabIndex = 6;
            this.btnAddPattern.Text = "パターン追加";
            this.btnAddPattern.UseVisualStyleBackColor = true;
            this.btnAddPattern.Click += new System.EventHandler(this.btnAddPattern_Click);
            // 
            // btnDeletePattern
            // 
            this.btnDeletePattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePattern.Location = new System.Drawing.Point(340, 545);
            this.btnDeletePattern.Name = "btnDeletePattern";
            this.btnDeletePattern.Size = new System.Drawing.Size(110, 30);
            this.btnDeletePattern.TabIndex = 7;
            this.btnDeletePattern.Text = "パターン削除";
            this.btnDeletePattern.UseVisualStyleBackColor = true;
            this.btnDeletePattern.Click += new System.EventHandler(this.btnDeletePattern_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(741, 545);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FacilitySystemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 587);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDeletePattern);
            this.Controls.Add(this.btnAddPattern);
            this.Controls.Add(this.btnSelectLineSearch);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.tabControlFacilitySystem);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.lblCondition);
            this.Name = "FacilitySystemDetailForm";
            this.Text = "装置系統詳細画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControlFacilitySystem;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnSelectLineSearch;
        private System.Windows.Forms.Button btnAddPattern;
        private System.Windows.Forms.Button btnDeletePattern;
        private System.Windows.Forms.Button btnUpdate;
    }
}