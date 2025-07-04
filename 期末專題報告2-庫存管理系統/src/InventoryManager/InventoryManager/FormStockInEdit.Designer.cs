﻿namespace InventoryManager
{
    partial class FormStockInEdit
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupOperation = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.groupPartInfo = new System.Windows.Forms.GroupBox();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.lblCurrentQty = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.groupOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.groupPartInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(335, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(83, 490);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(165, 43);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupOperation
            // 
            this.groupOperation.Controls.Add(this.lblAmount);
            this.groupOperation.Controls.Add(this.lblNote);
            this.groupOperation.Controls.Add(this.txtNote);
            this.groupOperation.Controls.Add(this.numAmount);
            this.groupOperation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupOperation.Location = new System.Drawing.Point(62, 205);
            this.groupOperation.Name = "groupOperation";
            this.groupOperation.Size = new System.Drawing.Size(459, 240);
            this.groupOperation.TabIndex = 6;
            this.groupOperation.TabStop = false;
            this.groupOperation.Text = "操作內容";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAmount.Location = new System.Drawing.Point(6, 45);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 20);
            this.lblAmount.TabIndex = 29;
            this.lblAmount.Text = "入庫數量";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNote.Location = new System.Drawing.Point(6, 79);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(49, 20);
            this.lblNote.TabIndex = 30;
            this.lblNote.Text = "備註";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(61, 79);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(380, 144);
            this.txtNote.TabIndex = 1;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(118, 40);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(120, 31);
            this.numAmount.TabIndex = 0;
            // 
            // groupPartInfo
            // 
            this.groupPartInfo.Controls.Add(this.txtCurrentQty);
            this.groupPartInfo.Controls.Add(this.lblPartNumber);
            this.groupPartInfo.Controls.Add(this.lblCurrentQty);
            this.groupPartInfo.Controls.Add(this.txtPartName);
            this.groupPartInfo.Controls.Add(this.txtPartNumber);
            this.groupPartInfo.Controls.Add(this.lblPartName);
            this.groupPartInfo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupPartInfo.Location = new System.Drawing.Point(62, 20);
            this.groupPartInfo.Name = "groupPartInfo";
            this.groupPartInfo.Size = new System.Drawing.Size(459, 179);
            this.groupPartInfo.TabIndex = 5;
            this.groupPartInfo.TabStop = false;
            this.groupPartInfo.Text = "零件資訊";
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentQty.Location = new System.Drawing.Point(190, 116);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.ReadOnly = true;
            this.txtCurrentQty.Size = new System.Drawing.Size(172, 31);
            this.txtCurrentQty.TabIndex = 31;
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.AutoSize = true;
            this.lblPartNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPartNumber.Location = new System.Drawing.Point(75, 47);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(89, 20);
            this.lblPartNumber.TabIndex = 27;
            this.lblPartNumber.Text = "零件編號";
            // 
            // lblCurrentQty
            // 
            this.lblCurrentQty.AutoSize = true;
            this.lblCurrentQty.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrentQty.Location = new System.Drawing.Point(75, 121);
            this.lblCurrentQty.Name = "lblCurrentQty";
            this.lblCurrentQty.Size = new System.Drawing.Size(89, 20);
            this.lblCurrentQty.TabIndex = 29;
            this.lblCurrentQty.Text = "當前庫存";
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartName.Location = new System.Drawing.Point(190, 79);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.ReadOnly = true;
            this.txtPartName.Size = new System.Drawing.Size(172, 31);
            this.txtPartName.TabIndex = 30;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPartNumber.Location = new System.Drawing.Point(190, 42);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.ReadOnly = true;
            this.txtPartNumber.Size = new System.Drawing.Size(172, 31);
            this.txtPartNumber.TabIndex = 26;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPartName.Location = new System.Drawing.Point(75, 84);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(89, 20);
            this.lblPartName.TabIndex = 28;
            this.lblPartName.Text = "零件名稱\n";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWarning.Location = new System.Drawing.Point(82, 455);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 20);
            this.lblWarning.TabIndex = 9;
            // 
            // FormStockInEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupOperation);
            this.Controls.Add(this.groupPartInfo);
            this.Name = "FormStockInEdit";
            this.Text = "零件入庫操作";
            this.Load += new System.EventHandler(this.FormStockInEdit_Load);
            this.groupOperation.ResumeLayout(false);
            this.groupOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.groupPartInfo.ResumeLayout(false);
            this.groupPartInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.GroupBox groupOperation;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.GroupBox groupPartInfo;
        private System.Windows.Forms.TextBox txtCurrentQty;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.Label lblCurrentQty;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblWarning;
    }
}