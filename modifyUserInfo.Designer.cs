
namespace 票务管理系统
{
    partial class modifyUserInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.IDCardNumber,
            this._admin,
            this._status,
            this.regTime,
            this.active,
            this.sex,
            this.phoneNum,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(11, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(979, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // username
            // 
            this.username.HeaderText = "用户名";
            this.username.MinimumWidth = 10;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // IDCardNumber
            // 
            this.IDCardNumber.HeaderText = "身份证号码";
            this.IDCardNumber.MinimumWidth = 10;
            this.IDCardNumber.Name = "IDCardNumber";
            // 
            // _admin
            // 
            this._admin.HeaderText = "管理权限";
            this._admin.MinimumWidth = 10;
            this._admin.Name = "_admin";
            // 
            // _status
            // 
            this._status.HeaderText = "账户状态";
            this._status.MinimumWidth = 10;
            this._status.Name = "_status";
            // 
            // regTime
            // 
            this.regTime.HeaderText = "注册时间";
            this.regTime.MinimumWidth = 10;
            this.regTime.Name = "regTime";
            // 
            // active
            // 
            this.active.HeaderText = "活跃度";
            this.active.MinimumWidth = 10;
            this.active.Name = "active";
            // 
            // sex
            // 
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 10;
            this.sex.Name = "sex";
            // 
            // phoneNum
            // 
            this.phoneNum.HeaderText = "手机号码";
            this.phoneNum.MinimumWidth = 10;
            this.phoneNum.Name = "phoneNum";
            // 
            // email
            // 
            this.email.HeaderText = "电子邮箱";
            this.email.MinimumWidth = 10;
            this.email.Name = "email";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(560, 424);
            this.btn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(110, 44);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "提交";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // modifyUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 512);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "modifyUserInfo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.modifyUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn _admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn _status;
        private System.Windows.Forms.DataGridViewTextBoxColumn regTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btn1;
    }
}