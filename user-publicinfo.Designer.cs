
namespace 票务管理系统
{
    partial class user_publicinfo
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
            this.publicview = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // publicview
            // 
            this.publicview.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.publicview.GridLines = true;
            this.publicview.HideSelection = false;
            this.publicview.Location = new System.Drawing.Point(24, 188);
            this.publicview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.publicview.Name = "publicview";
            this.publicview.Size = new System.Drawing.Size(1718, 996);
            this.publicview.TabIndex = 0;
            this.publicview.UseCompatibleStateImageBehavior = false;
            this.publicview.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "始发";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "终到";
            // 
            // click
            // 
            this.click.Location = new System.Drawing.Point(1392, 54);
            this.click.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(166, 42);
            this.click.TabIndex = 3;
            this.click.Text = "查询";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(310, 54);
            this.start.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(220, 35);
            this.start.TabIndex = 4;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(810, 54);
            this.end.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(252, 35);
            this.end.TabIndex = 5;
            // 
            // user_publicinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 1212);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publicview);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "user_publicinfo";
            this.Text = "user_publicinfo";
            this.Load += new System.EventHandler(this.user_publicinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView publicview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button click;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.TextBox end;
    }
}