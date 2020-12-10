
namespace 票务管理系统
{
    partial class user_add
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttime = new System.Windows.Forms.DateTimePicker();
            this.tprice = new System.Windows.Forms.TextBox();
            this.Tseat = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.ticketid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "票号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "购买时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "座位";
            // 
            // ttime
            // 
            this.ttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ttime.Location = new System.Drawing.Point(115, 85);
            this.ttime.Name = "ttime";
            this.ttime.ShowUpDown = true;
            this.ttime.Size = new System.Drawing.Size(165, 21);
            this.ttime.TabIndex = 7;
            // 
            // tprice
            // 
            this.tprice.Location = new System.Drawing.Point(115, 119);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(165, 21);
            this.tprice.TabIndex = 8;
            // 
            // Tseat
            // 
            this.Tseat.Location = new System.Drawing.Point(115, 154);
            this.Tseat.Name = "Tseat";
            this.Tseat.Size = new System.Drawing.Size(165, 21);
            this.Tseat.TabIndex = 9;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(138, 198);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 10;
            this.update.Text = "提交";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // ticketid
            // 
            this.ticketid.Location = new System.Drawing.Point(115, 54);
            this.ticketid.Name = "ticketid";
            this.ticketid.Size = new System.Drawing.Size(165, 21);
            this.ticketid.TabIndex = 11;
            // 
            // user_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 254);
            this.Controls.Add(this.ticketid);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Tseat);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.ttime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "user_add";
            this.Text = "user_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ttime;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.TextBox Tseat;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox ticketid;
    }
}