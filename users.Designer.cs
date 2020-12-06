
namespace 票务管理系统
{
    partial class users
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
            this.addticket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.changeuserinfo = new System.Windows.Forms.Button();
            this.delticket = new System.Windows.Forms.Button();
            this.changeticket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addticket
            // 
            this.addticket.Location = new System.Drawing.Point(256, 78);
            this.addticket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addticket.Name = "addticket";
            this.addticket.Size = new System.Drawing.Size(188, 92);
            this.addticket.TabIndex = 1;
            this.addticket.Text = "添加行程";
            this.addticket.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "我的行程";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // changeuserinfo
            // 
            this.changeuserinfo.Location = new System.Drawing.Point(485, 79);
            this.changeuserinfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.changeuserinfo.Name = "changeuserinfo";
            this.changeuserinfo.Size = new System.Drawing.Size(214, 92);
            this.changeuserinfo.TabIndex = 3;
            this.changeuserinfo.Text = "个人信息";
            this.changeuserinfo.UseVisualStyleBackColor = true;
            this.changeuserinfo.Click += new System.EventHandler(this.changeuserinfo_Click);
            // 
            // delticket
            // 
            this.delticket.Location = new System.Drawing.Point(767, 79);
            this.delticket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.delticket.Name = "delticket";
            this.delticket.Size = new System.Drawing.Size(182, 92);
            this.delticket.TabIndex = 4;
            this.delticket.Text = "删除该行程";
            this.delticket.UseVisualStyleBackColor = true;
            // 
            // changeticket
            // 
            this.changeticket.Location = new System.Drawing.Point(1007, 78);
            this.changeticket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.changeticket.Name = "changeticket";
            this.changeticket.Size = new System.Drawing.Size(212, 92);
            this.changeticket.TabIndex = 5;
            this.changeticket.Text = "修改该行程";
            this.changeticket.UseVisualStyleBackColor = true;
            this.changeticket.Click += new System.EventHandler(this.changeticket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "A先生/女士，早上好。";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(50, 182);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1400, 484);
            this.listBox1.TabIndex = 7;
            // 
            // users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 694);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeticket);
            this.Controls.Add(this.delticket);
            this.Controls.Add(this.changeuserinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addticket);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "users";
            this.Text = "users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeuserinfo;
        private System.Windows.Forms.Button delticket;
        private System.Windows.Forms.Button changeticket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}