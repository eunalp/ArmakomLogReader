namespace ArmakomLogReader
{
    partial class frmConfigDisplayer
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
            this.txtDisplayer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDisplayer
            // 
            this.txtDisplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDisplayer.Location = new System.Drawing.Point(12, 12);
            this.txtDisplayer.Multiline = true;
            this.txtDisplayer.Name = "txtDisplayer";
            this.txtDisplayer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDisplayer.Size = new System.Drawing.Size(897, 573);
            this.txtDisplayer.TabIndex = 0;
            // 
            // frmConfigDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 597);
            this.Controls.Add(this.txtDisplayer);
            this.Name = "frmConfigDisplayer";
            this.Text = "frmConfigDisplayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplayer;
    }
}