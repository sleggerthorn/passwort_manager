
namespace AutoTyper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.cbUser = new System.Windows.Forms.CheckBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbExtraKey = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(228, 114);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(60, 15);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(228, 171);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(381, 332);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Location = new System.Drawing.Point(139, 132);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(84, 19);
            this.cbUser.TabIndex = 6;
            this.cbUser.Text = "Username?";
            this.cbUser.UseVisualStyleBackColor = true;
            this.cbUser.CheckedChanged += new System.EventHandler(this.cbUser_CheckedChanged);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(228, 132);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(378, 23);
            this.tbUser.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(228, 189);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(378, 23);
            this.tbPassword.TabIndex = 8;
            // 
            // cbExtraKey
            // 
            this.cbExtraKey.AutoSize = true;
            this.cbExtraKey.Location = new System.Drawing.Point(228, 218);
            this.cbExtraKey.Name = "cbExtraKey";
            this.cbExtraKey.Size = new System.Drawing.Size(155, 19);
            this.cbExtraKey.TabIndex = 9;
            this.cbExtraKey.Text = "Perform extra Key press?";
            this.cbExtraKey.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbExtraKey);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUser);
            this.Name = "Form1";
            this.Text = "Auto-Typer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.CheckBox cbUser;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbExtraKey;
    }
}

