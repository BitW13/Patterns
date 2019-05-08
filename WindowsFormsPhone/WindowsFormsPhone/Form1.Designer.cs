namespace WindowsFormsPhone
{
    partial class Form1
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
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.listBoxPhones = new System.Windows.Forms.ListBox();
            this.lblPhones = new System.Windows.Forms.Label();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtBoxAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.manageGroupBox = new System.Windows.Forms.GroupBox();
            this.btnTopUpAccount = new System.Windows.Forms.Button();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.txtBoxCallProbability = new System.Windows.Forms.TextBox();
            this.lblCallProbability = new System.Windows.Forms.Label();
            this.detailsGroupBox.SuspendLayout();
            this.manageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Controls.Add(this.lblCallProbability);
            this.detailsGroupBox.Controls.Add(this.txtBoxCallProbability);
            this.detailsGroupBox.Controls.Add(this.btnDelete);
            this.detailsGroupBox.Controls.Add(this.btnSave);
            this.detailsGroupBox.Controls.Add(this.lblAccount);
            this.detailsGroupBox.Controls.Add(this.txtBoxAccount);
            this.detailsGroupBox.Controls.Add(this.lblNumber);
            this.detailsGroupBox.Controls.Add(this.txtBoxNumber);
            this.detailsGroupBox.Controls.Add(this.btnAddPhone);
            this.detailsGroupBox.Controls.Add(this.lblPhones);
            this.detailsGroupBox.Controls.Add(this.listBoxPhones);
            this.detailsGroupBox.Location = new System.Drawing.Point(47, 30);
            this.detailsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsGroupBox.Size = new System.Drawing.Size(667, 394);
            this.detailsGroupBox.TabIndex = 0;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Details";
            // 
            // listBoxPhones
            // 
            this.listBoxPhones.FormattingEnabled = true;
            this.listBoxPhones.ItemHeight = 16;
            this.listBoxPhones.Location = new System.Drawing.Point(21, 48);
            this.listBoxPhones.Name = "listBoxPhones";
            this.listBoxPhones.Size = new System.Drawing.Size(348, 276);
            this.listBoxPhones.TabIndex = 0;
            this.listBoxPhones.SelectedIndexChanged += new System.EventHandler(this.ListBoxPhones_SelectedIndexChanged);
            // 
            // lblPhones
            // 
            this.lblPhones.AutoSize = true;
            this.lblPhones.Location = new System.Drawing.Point(18, 28);
            this.lblPhones.Name = "lblPhones";
            this.lblPhones.Size = new System.Drawing.Size(60, 17);
            this.lblPhones.TabIndex = 1;
            this.lblPhones.Text = "Phones:";
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(55, 336);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(253, 43);
            this.btnAddPhone.TabIndex = 2;
            this.btnAddPhone.Text = "Add";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.BtnAddPhone_Click);
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(419, 57);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(208, 22);
            this.txtBoxNumber.TabIndex = 3;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(416, 37);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(62, 17);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Number:";
            // 
            // txtBoxAccount
            // 
            this.txtBoxAccount.Location = new System.Drawing.Point(419, 102);
            this.txtBoxAccount.Name = "txtBoxAccount";
            this.txtBoxAccount.Size = new System.Drawing.Size(208, 22);
            this.txtBoxAccount.TabIndex = 5;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(416, 82);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(63, 17);
            this.lblAccount.TabIndex = 6;
            this.lblAccount.Text = "Account:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(419, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 43);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // manageGroupBox
            // 
            this.manageGroupBox.Controls.Add(this.btnEndCall);
            this.manageGroupBox.Controls.Add(this.btnCall);
            this.manageGroupBox.Controls.Add(this.btnPickUp);
            this.manageGroupBox.Controls.Add(this.btnTopUpAccount);
            this.manageGroupBox.Location = new System.Drawing.Point(721, 30);
            this.manageGroupBox.Name = "manageGroupBox";
            this.manageGroupBox.Size = new System.Drawing.Size(428, 394);
            this.manageGroupBox.TabIndex = 1;
            this.manageGroupBox.TabStop = false;
            this.manageGroupBox.Text = "Manage";
            // 
            // btnTopUpAccount
            // 
            this.btnTopUpAccount.Location = new System.Drawing.Point(106, 57);
            this.btnTopUpAccount.Name = "btnTopUpAccount";
            this.btnTopUpAccount.Size = new System.Drawing.Size(261, 48);
            this.btnTopUpAccount.TabIndex = 0;
            this.btnTopUpAccount.Text = "TopUpAccount";
            this.btnTopUpAccount.UseVisualStyleBackColor = true;
            this.btnTopUpAccount.Click += new System.EventHandler(this.BtnTopUpAccount_Click);
            // 
            // btnPickUp
            // 
            this.btnPickUp.Location = new System.Drawing.Point(106, 112);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(261, 57);
            this.btnPickUp.TabIndex = 1;
            this.btnPickUp.Text = "PickUp";
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.BtnPickUp_Click);
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(106, 176);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(261, 62);
            this.btnCall.TabIndex = 2;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // btnEndCall
            // 
            this.btnEndCall.Location = new System.Drawing.Point(106, 245);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(261, 59);
            this.btnEndCall.TabIndex = 3;
            this.btnEndCall.Text = "EndCall";
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.BtnEndCall_Click);
            // 
            // txtBoxCallProbability
            // 
            this.txtBoxCallProbability.Location = new System.Drawing.Point(419, 151);
            this.txtBoxCallProbability.Name = "txtBoxCallProbability";
            this.txtBoxCallProbability.Size = new System.Drawing.Size(208, 22);
            this.txtBoxCallProbability.TabIndex = 9;
            // 
            // lblCallProbability
            // 
            this.lblCallProbability.AutoSize = true;
            this.lblCallProbability.Location = new System.Drawing.Point(419, 131);
            this.lblCallProbability.Name = "lblCallProbability";
            this.lblCallProbability.Size = new System.Drawing.Size(101, 17);
            this.lblCallProbability.TabIndex = 10;
            this.lblCallProbability.Text = "Call Probability";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 645);
            this.Controls.Add(this.manageGroupBox);
            this.Controls.Add(this.detailsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.detailsGroupBox.ResumeLayout(false);
            this.detailsGroupBox.PerformLayout();
            this.manageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Label lblPhones;
        private System.Windows.Forms.ListBox listBoxPhones;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtBoxAccount;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox manageGroupBox;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.Button btnTopUpAccount;
        private System.Windows.Forms.Label lblCallProbability;
        private System.Windows.Forms.TextBox txtBoxCallProbability;
    }
}

