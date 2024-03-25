namespace ADO_AdventureWorks
{
    partial class ConnectDB
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WinMode = new System.Windows.Forms.RadioButton();
            this.MixedMode = new System.Windows.Forms.RadioButton();
            this.UserName = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDBName);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.Disconnect);
            this.groupBox1.Controls.Add(this.btConnect);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(615, 601);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Nối đến Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MixedMode);
            this.groupBox2.Controls.Add(this.txtPassWord);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.WinMode);
            this.groupBox2.Controls.Add(this.PassWord);
            this.groupBox2.Controls.Add(this.UserName);
            this.groupBox2.Location = new System.Drawing.Point(28, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chứng thực ";
            // 
            // WinMode
            // 
            this.WinMode.AutoSize = true;
            this.WinMode.Checked = true;
            this.WinMode.Location = new System.Drawing.Point(38, 52);
            this.WinMode.Name = "WinMode";
            this.WinMode.Size = new System.Drawing.Size(238, 29);
            this.WinMode.TabIndex = 0;
            this.WinMode.Text = "Windows Authenication";
            this.WinMode.UseVisualStyleBackColor = true;
            // 
            // MixedMode
            // 
            this.MixedMode.AutoSize = true;
            this.MixedMode.Location = new System.Drawing.Point(38, 97);
            this.MixedMode.Name = "MixedMode";
            this.MixedMode.Size = new System.Drawing.Size(261, 29);
            this.MixedMode.TabIndex = 0;
            this.MixedMode.Text = "SQL Server Authenication";
            this.MixedMode.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(33, 163);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(105, 25);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "UserName";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Location = new System.Drawing.Point(33, 217);
            this.PassWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(104, 25);
            this.PassWord.TabIndex = 0;
            this.PassWord.Text = "PassWord";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(145, 512);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(119, 41);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(351, 512);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(119, 41);
            this.Disconnect.TabIndex = 2;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(227, 44);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(281, 30);
            this.txtServerName.TabIndex = 3;
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(227, 101);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(281, 30);
            this.txtDBName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(199, 158);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(281, 30);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(199, 212);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(281, 30);
            this.txtPassWord.TabIndex = 3;
            // 
            // ConnectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 665);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectDB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton MixedMode;
        private System.Windows.Forms.RadioButton WinMode;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
    }
}