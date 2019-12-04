namespace QYYH
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblserver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbldb = new System.Windows.Forms.Label();
            this.txtserver = new System.Windows.Forms.ComboBox();
            this.txtuser = new System.Windows.Forms.ComboBox();
            this.cmbdb = new System.Windows.Forms.ComboBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(155, 112);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(53, 12);
            this.lblserver.TabIndex = 0;
            this.lblserver.Text = "服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户：";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(236, 200);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(179, 21);
            this.txtpwd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码：";
            // 
            // lbldb
            // 
            this.lbldb.AutoSize = true;
            this.lbldb.Location = new System.Drawing.Point(157, 254);
            this.lbldb.Name = "lbldb";
            this.lbldb.Size = new System.Drawing.Size(41, 12);
            this.lbldb.TabIndex = 7;
            this.lbldb.Text = "账套：";
            // 
            // txtserver
            // 
            this.txtserver.FormattingEnabled = true;
            this.txtserver.Location = new System.Drawing.Point(236, 109);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(179, 20);
            this.txtserver.TabIndex = 8;
            // 
            // txtuser
            // 
            this.txtuser.FormattingEnabled = true;
            this.txtuser.Location = new System.Drawing.Point(236, 153);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(179, 20);
            this.txtuser.TabIndex = 9;
            // 
            // cmbdb
            // 
            this.cmbdb.FormattingEnabled = true;
            this.cmbdb.Location = new System.Drawing.Point(236, 246);
            this.cmbdb.Name = "cmbdb";
            this.cmbdb.Size = new System.Drawing.Size(179, 20);
            this.cmbdb.TabIndex = 10;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(214, 297);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 11;
            this.cmdOk.Text = "确定";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(349, 297);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 12;
            this.cmdCancel.Text = "取消";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(552, 386);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.cmbdb);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.lbldb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblserver);
            this.Name = "frmLogin";
            this.Text = "系统登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbldb;
        private System.Windows.Forms.ComboBox txtserver;
        private System.Windows.Forms.ComboBox txtuser;
        private System.Windows.Forms.ComboBox cmbdb;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
    }
}

