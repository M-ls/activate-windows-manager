namespace activate_windows_manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startClick = new System.Windows.Forms.Button();
            this.stopClick = new System.Windows.Forms.Button();
            this.customArguments = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpButton = new System.Windows.Forms.Button();
            this.consoleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startClick
            // 
            this.startClick.Location = new System.Drawing.Point(35, 36);
            this.startClick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startClick.Name = "startClick";
            this.startClick.Size = new System.Drawing.Size(146, 91);
            this.startClick.TabIndex = 0;
            this.startClick.Text = "开启";
            this.startClick.UseVisualStyleBackColor = true;
            this.startClick.Click += new System.EventHandler(this.startClick_Click);
            // 
            // stopClick
            // 
            this.stopClick.Location = new System.Drawing.Point(220, 36);
            this.stopClick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stopClick.Name = "stopClick";
            this.stopClick.Size = new System.Drawing.Size(146, 91);
            this.stopClick.TabIndex = 1;
            this.stopClick.Text = "关闭";
            this.stopClick.UseVisualStyleBackColor = true;
            this.stopClick.Click += new System.EventHandler(this.stopClick_Click);
            // 
            // customArguments
            // 
            this.customArguments.Location = new System.Drawing.Point(35, 170);
            this.customArguments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.customArguments.Name = "customArguments";
            this.customArguments.Size = new System.Drawing.Size(282, 22);
            this.customArguments.TabIndex = 2;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.OwnerDraw = true;
            this.toolTip.ReshowDelay = 5000;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(356, 170);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(55, 22);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // consoleButton
            // 
            this.consoleButton.Location = new System.Drawing.Point(56, 231);
            this.consoleButton.Name = "consoleButton";
            this.consoleButton.Size = new System.Drawing.Size(103, 61);
            this.consoleButton.TabIndex = 4;
            this.consoleButton.Text = "显示日志";
            this.consoleButton.UseVisualStyleBackColor = true;
            this.consoleButton.Click += new System.EventHandler(this.consoleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 338);
            this.Controls.Add(this.consoleButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.customArguments);
            this.Controls.Add(this.stopClick);
            this.Controls.Add(this.startClick);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "activate-windows";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startClick;
        private System.Windows.Forms.Button stopClick;
        private System.Windows.Forms.TextBox customArguments;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button consoleButton;
    }
}

