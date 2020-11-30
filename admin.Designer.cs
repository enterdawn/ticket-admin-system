
namespace 票务管理系统
{
    partial class admin
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
            this.ban = new System.Windows.Forms.Button();
            this.userban = new System.Windows.Forms.TextBox();
            this.userunban = new System.Windows.Forms.TextBox();
            this.unban = new System.Windows.Forms.Button();
            this.enableadmin = new System.Windows.Forms.Button();
            this.canceladmin = new System.Windows.Forms.Button();
            this.userinfoadmin = new System.Windows.Forms.Button();
            this.ticketinfoadmin = new System.Windows.Forms.Button();
            this.adminenable = new System.Windows.Forms.TextBox();
            this.admincancel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ban
            // 
            this.ban.Location = new System.Drawing.Point(230, 42);
            this.ban.Name = "ban";
            this.ban.Size = new System.Drawing.Size(89, 23);
            this.ban.TabIndex = 0;
            this.ban.Text = "封禁";
            this.ban.UseVisualStyleBackColor = true;
            // 
            // userban
            // 
            this.userban.Location = new System.Drawing.Point(102, 43);
            this.userban.Name = "userban";
            this.userban.Size = new System.Drawing.Size(100, 21);
            this.userban.TabIndex = 1;
            // 
            // userunban
            // 
            this.userunban.Location = new System.Drawing.Point(102, 71);
            this.userunban.Name = "userunban";
            this.userunban.Size = new System.Drawing.Size(100, 21);
            this.userunban.TabIndex = 2;
            // 
            // unban
            // 
            this.unban.Location = new System.Drawing.Point(230, 68);
            this.unban.Name = "unban";
            this.unban.Size = new System.Drawing.Size(89, 23);
            this.unban.TabIndex = 3;
            this.unban.Text = "解封";
            this.unban.UseVisualStyleBackColor = true;
            // 
            // enableadmin
            // 
            this.enableadmin.Location = new System.Drawing.Point(230, 97);
            this.enableadmin.Name = "enableadmin";
            this.enableadmin.Size = new System.Drawing.Size(89, 23);
            this.enableadmin.TabIndex = 4;
            this.enableadmin.Text = "添加为管理员";
            this.enableadmin.UseVisualStyleBackColor = true;
            // 
            // canceladmin
            // 
            this.canceladmin.Location = new System.Drawing.Point(230, 127);
            this.canceladmin.Name = "canceladmin";
            this.canceladmin.Size = new System.Drawing.Size(89, 23);
            this.canceladmin.TabIndex = 5;
            this.canceladmin.Text = "取消管理员";
            this.canceladmin.UseVisualStyleBackColor = true;
            // 
            // userinfoadmin
            // 
            this.userinfoadmin.Location = new System.Drawing.Point(102, 156);
            this.userinfoadmin.Name = "userinfoadmin";
            this.userinfoadmin.Size = new System.Drawing.Size(217, 23);
            this.userinfoadmin.TabIndex = 6;
            this.userinfoadmin.Text = "用户信息管理";
            this.userinfoadmin.UseVisualStyleBackColor = true;
            // 
            // ticketinfoadmin
            // 
            this.ticketinfoadmin.Location = new System.Drawing.Point(102, 185);
            this.ticketinfoadmin.Name = "ticketinfoadmin";
            this.ticketinfoadmin.Size = new System.Drawing.Size(217, 23);
            this.ticketinfoadmin.TabIndex = 7;
            this.ticketinfoadmin.Text = "票务信息管理";
            this.ticketinfoadmin.UseVisualStyleBackColor = true;
            // 
            // adminenable
            // 
            this.adminenable.Location = new System.Drawing.Point(102, 98);
            this.adminenable.Name = "adminenable";
            this.adminenable.Size = new System.Drawing.Size(100, 21);
            this.adminenable.TabIndex = 8;
            // 
            // admincancel
            // 
            this.admincancel.Location = new System.Drawing.Point(102, 127);
            this.admincancel.Name = "admincancel";
            this.admincancel.Size = new System.Drawing.Size(100, 21);
            this.admincancel.TabIndex = 9;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 266);
            this.Controls.Add(this.admincancel);
            this.Controls.Add(this.adminenable);
            this.Controls.Add(this.ticketinfoadmin);
            this.Controls.Add(this.userinfoadmin);
            this.Controls.Add(this.canceladmin);
            this.Controls.Add(this.enableadmin);
            this.Controls.Add(this.unban);
            this.Controls.Add(this.userunban);
            this.Controls.Add(this.userban);
            this.Controls.Add(this.ban);
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ban;
        private System.Windows.Forms.TextBox userban;
        private System.Windows.Forms.TextBox userunban;
        private System.Windows.Forms.Button unban;
        private System.Windows.Forms.Button enableadmin;
        private System.Windows.Forms.Button canceladmin;
        private System.Windows.Forms.Button userinfoadmin;
        private System.Windows.Forms.Button ticketinfoadmin;
        private System.Windows.Forms.TextBox adminenable;
        private System.Windows.Forms.TextBox admincancel;
    }
}