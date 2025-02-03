using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activate_windows_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            miscell();
            this.Resize += MyForm_Resize;
        }
        string tips = "参数：\n-p: 预设参数（\"mac\"、\"bsd\"、\"linux\"、\"hurd\"、\"windows\"、\"unix\"、\"deck\"、\"reactos\"、\"m$\"）\n-t: 自定义标题行\n-m: 自定义内容行\n-b: 加粗\n-i: 斜体\n-f: 自定义字体\n-c: 自定义颜色\n-w: 自定义叠加层宽度\n-h: 自定义叠加层高度\n-s: 自定义缩放\n";
        private async void startClick_Click(object sender, EventArgs e)
        {
            await stableActivity("start", customArguments);
        }
        private async void stopClick_Click(object sender, EventArgs e)
        {
            await stableActivity("stop", customArguments);
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            toolTip.Show(tips, helpButton, 5000);
        }
        private void ShowWindow(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowWindow(sender, e);
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MyForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false; 
                this.Hide();
            }
        }
        public void miscell()
        {
            ToolTip tooltip = new ToolTip()
            {
                OwnerDraw = true // 启用自定义绘制
            };
            toolTip.SetToolTip(customArguments, tips);
            toolTip.SetToolTip(helpButton, tips);
            toolTip.Draw += ToolTip_Draw;

            // 初始化 NotifyIcon
            NotifyIcon notifyIcon = new NotifyIcon
            {
                Icon = this.Icon, // 设置托盘图标（可以替换为自定义图标）
                Text = "activate-windows", // 鼠标悬停时显示的提示文本
                Visible = true
            };
            // 创建右键菜单
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("显示窗口", null, ShowWindow);
            contextMenu.Items.Add("退出", null, ExitApplication);
            notifyIcon.ContextMenuStrip = contextMenu;

            // 添加双击事件
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
        }
        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            using (Font font = new Font("Consolas", 9, FontStyle.Bold)) // 自定义字体
            {
                // 设置背景颜色
                e.Graphics.FillRectangle(Brushes.Azure, e.Bounds);

                // 绘制文本
                e.Graphics.DrawString(e.ToolTipText, font, Brushes.Black, e.Bounds);
            }
        }
        static async Task stableActivity(string stable, TextBox customArguments)
        {
            try
            {
                // 获取当前程序的运行目录
                string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // 构建可执行文件的绝对路径
                string exePath = Path.Combine(exeDirectory, "Resources", "activate-windows-mingw64.exe");

                // 创建 ProcessStartInfo 对象
                ProcessStartInfo processInfo = new ProcessStartInfo
                {
                    FileName = exePath,                                            // 可执行文件路径
                    Arguments = stable == "start" ? customArguments.Text : "-K",   // 传递给可执行文件的参数
                    RedirectStandardOutput = true,                                 // 重定向标准输出（可选）
                    RedirectStandardError = true,                                  // 重定向标准错误（可选）
                    CreateNoWindow = true,                                         // 禁止创建窗口
                    UseShellExecute = false                                        // 使用操作系统 shell 执行，设为 false 可隐藏窗口
                };

                // 启动进程
                using (Process process = Process.Start(processInfo))
                {
                    // 读取标准输出（如果需要查看执行结果）
                    string output = await process.StandardOutput.ReadToEndAsync();
                    string error = await process.StandardError.ReadToEndAsync();

                    // 等待进程结束
                    await Task.Run(() => process.WaitForExit());

                    // 输出结果（可选）
                    Console.WriteLine("Output: " + output);
                    Console.WriteLine("Error: " + error);
                }
            }
            catch (Exception ex)
            {
                // 捕获并处理异常
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
