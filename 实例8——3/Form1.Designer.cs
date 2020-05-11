namespace 实例8__3
{
    partial class 温度监控
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "温度:";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(49, 147);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(55, 15);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "label2";
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Location = new System.Drawing.Point(49, 198);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(362, 118);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(182, 82);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 25);
            this.txtTemp.TabIndex = 3;
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(336, 82);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(89, 38);
            this.btnMonitor.TabIndex = 4;
            this.btnMonitor.Text = "监控";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // 温度监控
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label1);
            this.Name = "温度监控";
            this.Text = "温度监控";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnMonitor;
    }
}

