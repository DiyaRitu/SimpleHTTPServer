namespace SimpleHTTPServer
{
    partial class Form1
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
            this.ServerLogsText = new System.Windows.Forms.TextBox();
            this.StartServerBtn = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Label();
            this.ServerPortText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StopServerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerLogsText
            // 
            this.ServerLogsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerLogsText.Location = new System.Drawing.Point(171, 28);
            this.ServerLogsText.Multiline = true;
            this.ServerLogsText.Name = "ServerLogsText";
            this.ServerLogsText.Size = new System.Drawing.Size(759, 484);
            this.ServerLogsText.TabIndex = 0;
            this.ServerLogsText.TextChanged += new System.EventHandler(this.ServerLogsText_TextChanged);
            // 
            // StartServerBtn
            // 
            this.StartServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServerBtn.Location = new System.Drawing.Point(38, 28);
            this.StartServerBtn.Name = "StartServerBtn";
            this.StartServerBtn.Size = new System.Drawing.Size(100, 30);
            this.StartServerBtn.TabIndex = 1;
            this.StartServerBtn.Text = "Start Server";
            this.StartServerBtn.UseVisualStyleBackColor = true;
            this.StartServerBtn.Click += new System.EventHandler(this.StartServerBtn_Click);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(44, 175);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(74, 16);
            this.S.TabIndex = 2;
            this.S.Text = "Server Port";
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // ServerPortText
            // 
            this.ServerPortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortText.Location = new System.Drawing.Point(38, 191);
            this.ServerPortText.Name = "ServerPortText";
            this.ServerPortText.Size = new System.Drawing.Size(100, 22);
            this.ServerPortText.TabIndex = 3;
            this.ServerPortText.TextChanged += new System.EventHandler(this.ServerPortText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Logs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StopServerBtn
            // 
            this.StopServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopServerBtn.Location = new System.Drawing.Point(38, 78);
            this.StopServerBtn.Name = "StopServerBtn";
            this.StopServerBtn.Size = new System.Drawing.Size(100, 30);
            this.StopServerBtn.TabIndex = 5;
            this.StopServerBtn.Text = "Stop Server";
            this.StopServerBtn.UseVisualStyleBackColor = true;
            this.StopServerBtn.Click += new System.EventHandler(this.StopServerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 524);
            this.Controls.Add(this.StopServerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServerPortText);
            this.Controls.Add(this.S);
            this.Controls.Add(this.StartServerBtn);
            this.Controls.Add(this.ServerLogsText);
            this.Name = "Form1";
            this.Text = "Simple HTTP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerLogsText;
        private System.Windows.Forms.Button StartServerBtn;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.TextBox ServerPortText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StopServerBtn;
    }
}

