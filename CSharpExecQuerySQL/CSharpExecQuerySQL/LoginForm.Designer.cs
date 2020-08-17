namespace CSharpExecQuerySQL
{
    partial class LoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.dbNameTextBox = new System.Windows.Forms.TextBox();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.dbNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(224, 193);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(116, 50);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Connect to SQL Server";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(184, 28);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(213, 20);
            this.serverNameTextBox.TabIndex = 1;
            // 
            // dbNameTextBox
            // 
            this.dbNameTextBox.Location = new System.Drawing.Point(184, 71);
            this.dbNameTextBox.Name = "dbNameTextBox";
            this.dbNameTextBox.Size = new System.Drawing.Size(213, 20);
            this.dbNameTextBox.TabIndex = 2;
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(62, 31);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(69, 13);
            this.serverNameLabel.TabIndex = 3;
            this.serverNameLabel.Text = "Server Name";
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.AutoSize = true;
            this.dbNameLabel.Location = new System.Drawing.Point(62, 74);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(84, 13);
            this.dbNameLabel.TabIndex = 4;
            this.dbNameLabel.Text = "Database Name";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 255);
            this.Controls.Add(this.dbNameLabel);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.dbNameTextBox);
            this.Controls.Add(this.serverNameTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.TextBox dbNameTextBox;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label dbNameLabel;
    }
}