namespace SimplyCastSync_Desktop
{
    partial class Form1
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
            this.rdconfig_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdconfig_btn
            // 
            this.rdconfig_btn.Location = new System.Drawing.Point(65, 48);
            this.rdconfig_btn.Name = "rdconfig_btn";
            this.rdconfig_btn.Size = new System.Drawing.Size(76, 53);
            this.rdconfig_btn.TabIndex = 0;
            this.rdconfig_btn.Text = "Reading Config";
            this.rdconfig_btn.UseVisualStyleBackColor = true;
            this.rdconfig_btn.Click += new System.EventHandler(this.rdconfig_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 327);
            this.Controls.Add(this.rdconfig_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rdconfig_btn;
    }
}

