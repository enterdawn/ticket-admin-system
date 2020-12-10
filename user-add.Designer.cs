
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttype = new System.Windows.Forms.ComboBox();
            this.tci = new System.Windows.Forms.TextBox();
            this.ttime = new System.Windows.Forms.DateTimePicker();
            this.tprice = new System.Windows.Forms.TextBox();
            this.Tseat = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "车次/航班号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "购买时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "座位";
            // 
            // ttype
            // 
            this.ttype.FormattingEnabled = true;
            this.ttype.Items.AddRange(new object[] {
            "train",
            "plain",
            "coach",
            "ship"});
            this.ttype.Location = new System.Drawing.Point(173, 42);
            this.ttype.Name = "ttype";
            this.ttype.Size = new System.Drawing.Size(121, 20);
            this.ttype.TabIndex = 5;
            // 
            // tci
            // 
            this.tci.Location = new System.Drawing.Point(173, 80);
            this.tci.Name = "tci";
            this.tci.Size = new System.Drawing.Size(121, 21);
            this.tci.TabIndex = 6;
            // 
            // ttime
            // 
            this.ttime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ttime.Location = new System.Drawing.Point(173, 112);
            this.ttime.Name = "ttime";
            this.ttime.Size = new System.Drawing.Size(200, 21);
            this.ttime.TabIndex = 7;
            // 
            // tprice
            // 
            this.tprice.Location = new System.Drawing.Point(173, 149);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(121, 21);
            this.tprice.TabIndex = 8;
            // 
            // Tseat
            // 
            this.Tseat.Location = new System.Drawing.Point(173, 184);
            this.Tseat.Name = "Tseat";
            this.Tseat.Size = new System.Drawing.Size(121, 21);
            this.Tseat.TabIndex = 9;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(173, 223);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 10;
            this.update.Text = "提交";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // user_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 293);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Tseat);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.ttime);
            this.Controls.Add(this.tci);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "user_add";
            this.Text = "user_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ttype;
        private System.Windows.Forms.TextBox tci;
        private System.Windows.Forms.DateTimePicker ttime;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.TextBox Tseat;
        private System.Windows.Forms.Button update;
    }
}