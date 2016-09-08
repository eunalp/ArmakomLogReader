namespace ArmakomLogReader
{
    partial class frmLogDetail
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtException = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtLogger = new System.Windows.Forms.TextBox();
            this.txtLogTime = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtCallSite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Call Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Log Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Logger";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Exception";
            // 
            // txtException
            // 
            this.txtException.Location = new System.Drawing.Point(105, 280);
            this.txtException.Multiline = true;
            this.txtException.Name = "txtException";
            this.txtException.ReadOnly = true;
            this.txtException.Size = new System.Drawing.Size(647, 252);
            this.txtException.TabIndex = 7;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(105, 207);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(647, 52);
            this.txtMessage.TabIndex = 8;
            // 
            // txtLogger
            // 
            this.txtLogger.Location = new System.Drawing.Point(105, 161);
            this.txtLogger.Name = "txtLogger";
            this.txtLogger.ReadOnly = true;
            this.txtLogger.Size = new System.Drawing.Size(647, 20);
            this.txtLogger.TabIndex = 9;
            // 
            // txtLogTime
            // 
            this.txtLogTime.Location = new System.Drawing.Point(105, 119);
            this.txtLogTime.Name = "txtLogTime";
            this.txtLogTime.ReadOnly = true;
            this.txtLogTime.Size = new System.Drawing.Size(647, 20);
            this.txtLogTime.TabIndex = 11;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(105, 75);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(647, 20);
            this.txtLevel.TabIndex = 12;
            // 
            // txtCallSite
            // 
            this.txtCallSite.Location = new System.Drawing.Point(105, 32);
            this.txtCallSite.Name = "txtCallSite";
            this.txtCallSite.ReadOnly = true;
            this.txtCallSite.Size = new System.Drawing.Size(647, 20);
            this.txtCallSite.TabIndex = 13;
            // 
            // frmLogDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 557);
            this.Controls.Add(this.txtCallSite);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtLogTime);
            this.Controls.Add(this.txtLogger);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtException);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogDetail";
            this.ShowIcon = false;
            this.Text = "Log Detayı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtException;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtLogger;
        private System.Windows.Forms.TextBox txtLogTime;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtCallSite;
    }
}