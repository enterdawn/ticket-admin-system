
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
            this.updatemess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publicview
            // 
            this.publicview.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.publicview.GridLines = true;
            this.publicview.HideSelection = false;
            this.publicview.Location = new System.Drawing.Point(12, 84);
            this.publicview.Name = "publicview";
            this.publicview.Size = new System.Drawing.Size(860, 384);
            this.publicview.TabIndex = 0;
            this.publicview.UseCompatibleStateImageBehavior = false;
            this.publicview.View = System.Windows.Forms.View.Details;
            // 
            // updatemess
            // 
            this.updatemess.Location = new System.Drawing.Point(446, 24);
            this.updatemess.Name = "updatemess";
            this.updatemess.Size = new System.Drawing.Size(101, 43);
            this.updatemess.TabIndex = 1;
            this.updatemess.Text = "上传信息";
            this.updatemess.UseVisualStyleBackColor = true;
            // 
            // user_publicinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 480);
            this.Controls.Add(this.updatemess);
            this.Controls.Add(this.publicview);
            this.Name = "user_publicinfo";
            this.Text = "user_publicinfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView publicview;
        private System.Windows.Forms.Button updatemess;
    }
}