namespace GetWindowsHardwareInfo
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.打开主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.HostName_lab = new Sunny.UI.UILabel();
            this.UserName_lab = new Sunny.UI.UILabel();
            this.CPU_lab = new Sunny.UI.UILabel();
            this.Memory_lab = new Sunny.UI.UILabel();
            this.HardDisk_lab = new Sunny.UI.UILabel();
            this.GraphicsCard_lab = new Sunny.UI.UILabel();
            this.Display1_lab = new Sunny.UI.UILabel();
            this.Display2_lab = new Sunny.UI.UILabel();
            this.DigitalPlate_lab = new Sunny.UI.UILabel();
            this.MAC_lab = new Sunny.UI.UILabel();
            this.IP_lab = new Sunny.UI.UILabel();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            this.uiListBox2 = new Sunny.UI.UIListBox();
            this.OS_lab = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.uiListBox3 = new Sunny.UI.UIListBox();
            this.uiContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.uiContextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "主机配置";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(161, 56);
            this.uiContextMenuStrip1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 打开主界面ToolStripMenuItem
            // 
            this.打开主界面ToolStripMenuItem.Name = "打开主界面ToolStripMenuItem";
            this.打开主界面ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.打开主界面ToolStripMenuItem.Text = "打开主界面";
            this.打开主界面ToolStripMenuItem.Click += new System.EventHandler(this.打开主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(13, 47);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "主机名：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(13, 73);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "用户名：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(13, 123);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "CPU：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(13, 149);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "内存：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(13, 334);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 5;
            this.uiLabel5.Text = "硬盘：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(13, 175);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "显卡：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(13, 201);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(100, 23);
            this.uiLabel7.TabIndex = 7;
            this.uiLabel7.Text = "显示器1：";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(13, 227);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(100, 23);
            this.uiLabel8.TabIndex = 8;
            this.uiLabel8.Text = "显示器2：";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(13, 253);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(100, 23);
            this.uiLabel9.TabIndex = 9;
            this.uiLabel9.Text = "数位板：";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel9.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.Location = new System.Drawing.Point(13, 279);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 23);
            this.uiLabel10.TabIndex = 10;
            this.uiLabel10.Text = "MAC地址：";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel10.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.Location = new System.Drawing.Point(13, 305);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(100, 23);
            this.uiLabel11.TabIndex = 11;
            this.uiLabel11.Text = "ip地址：";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel11.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // HostName_lab
            // 
            this.HostName_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HostName_lab.Location = new System.Drawing.Point(101, 47);
            this.HostName_lab.Name = "HostName_lab";
            this.HostName_lab.Size = new System.Drawing.Size(373, 23);
            this.HostName_lab.TabIndex = 12;
            this.HostName_lab.Text = "读取中....";
            this.HostName_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HostName_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserName_lab
            // 
            this.UserName_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName_lab.Location = new System.Drawing.Point(101, 73);
            this.UserName_lab.Name = "UserName_lab";
            this.UserName_lab.Size = new System.Drawing.Size(373, 23);
            this.UserName_lab.TabIndex = 13;
            this.UserName_lab.Text = "读取中....";
            this.UserName_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CPU_lab
            // 
            this.CPU_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CPU_lab.Location = new System.Drawing.Point(101, 122);
            this.CPU_lab.Name = "CPU_lab";
            this.CPU_lab.Size = new System.Drawing.Size(497, 23);
            this.CPU_lab.TabIndex = 14;
            this.CPU_lab.Text = "读取中....";
            this.CPU_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CPU_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Memory_lab
            // 
            this.Memory_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Memory_lab.Location = new System.Drawing.Point(101, 147);
            this.Memory_lab.Name = "Memory_lab";
            this.Memory_lab.Size = new System.Drawing.Size(373, 23);
            this.Memory_lab.TabIndex = 15;
            this.Memory_lab.Text = "读取中....";
            this.Memory_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Memory_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // HardDisk_lab
            // 
            this.HardDisk_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HardDisk_lab.Location = new System.Drawing.Point(103, 335);
            this.HardDisk_lab.Name = "HardDisk_lab";
            this.HardDisk_lab.Size = new System.Drawing.Size(373, 23);
            this.HardDisk_lab.TabIndex = 16;
            this.HardDisk_lab.Text = "5";
            this.HardDisk_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HardDisk_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // GraphicsCard_lab
            // 
            this.GraphicsCard_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GraphicsCard_lab.Location = new System.Drawing.Point(101, 175);
            this.GraphicsCard_lab.Name = "GraphicsCard_lab";
            this.GraphicsCard_lab.Size = new System.Drawing.Size(373, 23);
            this.GraphicsCard_lab.TabIndex = 17;
            this.GraphicsCard_lab.Text = "读取中....";
            this.GraphicsCard_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GraphicsCard_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Display1_lab
            // 
            this.Display1_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Display1_lab.Location = new System.Drawing.Point(101, 200);
            this.Display1_lab.Name = "Display1_lab";
            this.Display1_lab.Size = new System.Drawing.Size(373, 23);
            this.Display1_lab.TabIndex = 18;
            this.Display1_lab.Text = "读取中....";
            this.Display1_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Display1_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Display2_lab
            // 
            this.Display2_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Display2_lab.Location = new System.Drawing.Point(101, 225);
            this.Display2_lab.Name = "Display2_lab";
            this.Display2_lab.Size = new System.Drawing.Size(373, 23);
            this.Display2_lab.TabIndex = 19;
            this.Display2_lab.Text = "暂无";
            this.Display2_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Display2_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // DigitalPlate_lab
            // 
            this.DigitalPlate_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DigitalPlate_lab.Location = new System.Drawing.Point(101, 252);
            this.DigitalPlate_lab.Name = "DigitalPlate_lab";
            this.DigitalPlate_lab.Size = new System.Drawing.Size(373, 23);
            this.DigitalPlate_lab.TabIndex = 20;
            this.DigitalPlate_lab.Text = "暂无";
            this.DigitalPlate_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DigitalPlate_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MAC_lab
            // 
            this.MAC_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MAC_lab.Location = new System.Drawing.Point(101, 279);
            this.MAC_lab.Name = "MAC_lab";
            this.MAC_lab.Size = new System.Drawing.Size(373, 23);
            this.MAC_lab.TabIndex = 21;
            this.MAC_lab.Text = "读取中....";
            this.MAC_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MAC_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // IP_lab
            // 
            this.IP_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IP_lab.Location = new System.Drawing.Point(101, 305);
            this.IP_lab.Name = "IP_lab";
            this.IP_lab.Size = new System.Drawing.Size(373, 23);
            this.IP_lab.TabIndex = 22;
            this.IP_lab.Text = "读取中....";
            this.IP_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IP_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiListBox1
            // 
            this.uiListBox1.FillColor = System.Drawing.Color.White;
            this.uiListBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiListBox1.Location = new System.Drawing.Point(457, 337);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.Radius = 0;
            this.uiListBox1.ShowText = false;
            this.uiListBox1.Size = new System.Drawing.Size(110, 120);
            this.uiListBox1.TabIndex = 23;
            this.uiListBox1.Text = "uiListBox1";
            this.uiListBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiListBox2
            // 
            this.uiListBox2.FillColor = System.Drawing.Color.White;
            this.uiListBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiListBox2.Location = new System.Drawing.Point(107, 337);
            this.uiListBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox2.Name = "uiListBox2";
            this.uiListBox2.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox2.Radius = 0;
            this.uiListBox2.ShowText = false;
            this.uiListBox2.Size = new System.Drawing.Size(342, 120);
            this.uiListBox2.TabIndex = 25;
            this.uiListBox2.Text = "uiListBox2";
            this.uiListBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // OS_lab
            // 
            this.OS_lab.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OS_lab.Location = new System.Drawing.Point(101, 97);
            this.OS_lab.Name = "OS_lab";
            this.OS_lab.Size = new System.Drawing.Size(506, 23);
            this.OS_lab.TabIndex = 28;
            this.OS_lab.Text = "读取中....";
            this.OS_lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OS_lab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(13, 98);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(100, 23);
            this.uiLabel13.TabIndex = 27;
            this.uiLabel13.Text = "系统：";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel13.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uiListBox3
            // 
            this.uiListBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiListBox3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiListBox3.ItemSelectForeColor = System.Drawing.Color.White;
            this.uiListBox3.Location = new System.Drawing.Point(107, 476);
            this.uiListBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox3.Name = "uiListBox3";
            this.uiListBox3.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox3.ShowText = false;
            this.uiListBox3.Size = new System.Drawing.Size(460, 180);
            this.uiListBox3.TabIndex = 29;
            this.uiListBox3.Text = "uiListBox3";
            this.uiListBox3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(629, 712);
            this.Controls.Add(this.uiListBox3);
            this.Controls.Add(this.OS_lab);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.uiListBox2);
            this.Controls.Add(this.uiListBox1);
            this.Controls.Add(this.IP_lab);
            this.Controls.Add(this.MAC_lab);
            this.Controls.Add(this.DigitalPlate_lab);
            this.Controls.Add(this.Display2_lab);
            this.Controls.Add(this.Display1_lab);
            this.Controls.Add(this.GraphicsCard_lab);
            this.Controls.Add(this.HardDisk_lab);
            this.Controls.Add(this.Memory_lab);
            this.Controls.Add(this.CPU_lab);
            this.Controls.Add(this.UserName_lab);
            this.Controls.Add(this.HostName_lab);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "主机配置";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 707, 394);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel HostName_lab;
        private Sunny.UI.UILabel UserName_lab;
        private Sunny.UI.UILabel CPU_lab;
        private Sunny.UI.UILabel Memory_lab;
        private Sunny.UI.UILabel HardDisk_lab;
        private Sunny.UI.UILabel GraphicsCard_lab;
        private Sunny.UI.UILabel Display1_lab;
        private Sunny.UI.UILabel Display2_lab;
        private Sunny.UI.UILabel DigitalPlate_lab;
        private Sunny.UI.UILabel MAC_lab;
        private Sunny.UI.UILabel IP_lab;
        private Sunny.UI.UIListBox uiListBox1;
        private Sunny.UI.UIListBox uiListBox2;
        private System.Windows.Forms.ToolStripMenuItem 打开主界面ToolStripMenuItem;
        private Sunny.UI.UILabel OS_lab;
        private Sunny.UI.UILabel uiLabel13;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIListBox uiListBox3;
    }
}

