using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;
using System.Threading;
using Sunny.UI;
using System.Text.RegularExpressions;

namespace GetWindowsHardwareInfo
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CPU = "CPU：" + 系统_CPU名称信息();
        string GPU = "显卡：" + 取显卡信息();
        string Memory = "内存：" + 获取内存条大小及频率();
        string MainBoard = "主板：" + 系统_主板厂商() + " " + 系统_主板型号();
        string IP = DoGetHostEntry();
        static string[] display = Get显示器().Split('\\');//处理获取信息 依据实际情况为准
        string Displ1 = "显示器1：" + display[1];
        string Mac = GetMACAddress();
        string OS = Get操作系统().Substring(9, 15) + "  " + 系统_64位() + "位";
        string HostName = System.Net.Dns.GetHostName();
        string UserName = GetUserName();
        string DiskID = GetHardDiskID();
        //string Disp1 = "";
        //string Disp2 = "";
        ITAssetManageMentEntities it = new ITAssetManageMentEntities();
        tb_ComputerConfigure config = new tb_ComputerConfigure();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            DataInteractive();
        }

        public void GetInfo()
        {
            UserName_lab.Text = GetUserName();
            HostName_lab.Text = System.Net.Dns.GetHostName();
            CPU_lab.Text = 系统_CPU名称信息().Trim();
            Memory_lab.Text = 获取内存条大小及频率();
            HardDisk_lab.Text = GetHardDiskID();
            GraphicsCard_lab.Text = 取显卡信息();
            Display1_lab.Text = display[1];
            IP_lab.Text = DoGetHostEntry();
            MAC_lab.Text = GetMACAddress();

            string OSName = Get操作系统();
            OS_lab.Text = OS;

            //var user = it.tb_Configuration.Where(j => j.IP == IP_lab.Text).ToList();
            //this.Text = user[0].Owner + "(" + user[0].AssetNumber + ")";

            this.Text= GetUserName();
            var ll = getExternalDisk().ToList();
            foreach (var item in ll)
            {
                uiListBox2.Items.Add(item.DiskName);
            }

            var list = GetDiskListInfo().ToList();
            foreach (var item in list)
            {
                uiListBox1.Items.Add(item.PartitionName + ManagerDoubleValue(item.SumSpace, 0) + "GB");
            }


            var usb = GetUsbdevices().ToList();
            foreach (var item in usb)
            {
                uiListBox3.Items.Add(item.UsbName);
            }
        }

        public void DataInteractive()
        {
            var ccc = it.tb_ComputerConfigure.Where(i => i.MAC == Mac).ToList();
            if (ccc.Count > 0)
            {
                ccc[0].UserName = GetUserName();
                ccc[0].HostName = System.Net.Dns.GetHostName();
                ccc[0].CPU = 系统_CPU名称信息();
                ccc[0].Memory = 获取内存条大小及频率();
                ccc[0].HardDisk = GetHardDiskID();
                ccc[0].GraphicsCard = 取显卡信息();
                ccc[0].Display1 = display[1];
                ccc[0].IP = DoGetHostEntry();
                ccc[0].MAC = GetMACAddress();
                ccc[0].LastUpdated = DateTime.Now.ToLongDateString();
                it.SaveChanges();
                Flies(ccc[0].IP);
            }
            else
            {
                config.UserName = GetUserName();
                config.HostName = System.Net.Dns.GetHostName();
                config.CPU = 系统_CPU名称信息();
                config.Memory = 获取内存条大小及频率();
                config.HardDisk = GetHardDiskID();
                config.GraphicsCard = 取显卡信息();
                config.Display1 = display[1];
                config.IP = DoGetHostEntry();
                config.MAC = GetMACAddress();
                config.LastUpdated = DateTime.Now.ToLongDateString();
                it.tb_ComputerConfigure.Add(config);
                it.SaveChanges();
                Flies(config.IP);
            }
        }

        public void Flies(string ip)
        {
            var user = it.tb_Configuration.Where(j => j.IP == ip).ToList();
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("D:\\" + user[0].Owner + "-主机配置详情(请不要删除).txt", false))
            {
                sw.WriteLine("用户名：" + UserName);
                sw.WriteLine("电脑名：" + HostName);
                sw.WriteLine("操作系统：" + OS);
                sw.WriteLine(CPU);
                sw.WriteLine(GPU);
                sw.WriteLine(Memory);
                //sw.WriteLine("硬盘ID：" + DiskID);
                sw.WriteLine(MainBoard);
                sw.WriteLine(Displ1);
                //sw.WriteLine("显示器1名：" + Disp1);
                //sw.WriteLine("显示器2名：" + Disp2);
                sw.WriteLine("MAC地址：" + Mac);
                sw.WriteLine("IP地址：" + IP);
                try
                {
                    List<HardDiskPartition> listInfo = GetDiskListInfo();
                    if (listInfo != null && listInfo.Count > 0)
                    {
                        sw.WriteLine("硬盘：");
                        var lll = getExternalDisk().ToList();
                        for (int i = 0; i < lll.Count; i++)
                        {
                            sw.WriteLine("" + i + ":" + lll[i].DiskName);
                        }
                        foreach (HardDiskPartition disk in listInfo)
                        {
                            sw.WriteLine(disk.PartitionName + "" + ManagerDoubleValue(disk.SumSpace, 1) + "GB");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                }
                sw.Close();//关闭对文件的占用
            }
            //UpLoadFile(@"D:\\" + user[0].Owner + "-主机配置详情(请不要删除).txt", @"\\192.168.19.170\配置详情", "XiaoShiXin", "Tosehz123");
        }

        public void UpLoadFile(string fileNamePath, string urlPath, string User, string Pwd)
        {
            string newFileName = fileNamePath.Substring(fileNamePath.LastIndexOf(@"\") + 1);//取文件名称
            if (urlPath.EndsWith(@"\") == false) urlPath = urlPath + @"\";

            urlPath = urlPath + newFileName;

            WebClient myWebClient = new WebClient();
            NetworkCredential cread = new NetworkCredential(User, Pwd, "Domain");
            myWebClient.Credentials = cread;
            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);

            try
            {
                byte[] postArray = r.ReadBytes((int)fs.Length);
                Stream postStream = myWebClient.OpenWrite(urlPath);
                // postStream.m
                if (postStream.CanWrite)
                {
                    postStream.Write(postArray, 0, postArray.Length);
                }
                else
                {
                }

                postStream.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public class USB
        {
            public string DeviceID;
            public string PNPDeviceID;
            public string Description;
            public string UsbName;
        }

        public List<USB> GetUsbdevices()
        {
            List<USB> UsbDevices = new List<USB>();

            // 获取USB控制器及其相关联的设备实体
            ManagementObjectCollection USBControllerDeviceCollection = new ManagementObjectSearcher("SELECT * FROM Win32_USBControllerDevice").Get();
            if (USBControllerDeviceCollection != null)
            {
                foreach (ManagementObject USBControllerDevice in USBControllerDeviceCollection)
                {   // 获取设备实体的DeviceID
                    String Dependent = (USBControllerDevice["Dependent"] as String).Split(new Char[] { '=' })[1];
                    //if (!String.IsNullOrEmpty(PNPDeviceID))
                    //{   // 注意：忽视大小写
                    //    if (Dependent.IndexOf(PNPDeviceID, 1, PNPDeviceID.Length - 2, StringComparison.OrdinalIgnoreCase) == -1) continue;
                    //}

                    // 过滤掉没有VID和PID的USB设备
                    Match match = Regex.Match(Dependent, "VID_[0-9|A-F]{4}&PID_[0-9|A-F]{4}");
                    if (match.Success)
                    {
                        ManagementObjectCollection PnPEntityCollection = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE DeviceID=" + Dependent).Get();
                        if (PnPEntityCollection != null)
                        {
                            foreach (ManagementObject Entity in PnPEntityCollection)
                            {
                                USB u = new USB();
                                
                                if (Entity["Description"] as String=="USB 输入设备" || Entity["Description"] as String == "Generic USB Hub")
                                {
                                    continue;
                                }
                                else
                                {
                                    u.UsbName = Entity["Description"].ToString();
                                }
                                //PnPEntityInfo Element;
                                //Element.PNPDeviceID = Entity["PNPDeviceID"] as String;  // 设备ID
                                //Element.Name = Entity["Name"] as String;                // 设备名称
                                //Element.Description = Entity["Description"] as String;  // 设备描述
                                //Element.Service = Entity["Service"] as String;          // 服务
                                //Element.Status = Entity["Status"] as String;            // 设备状态
                                //Element.VendorID = Convert.ToUInt16(match.Value.Substring(4, 4), 16);   // 供应商标识   
                                //Element.ProductID = Convert.ToUInt16(match.Value.Substring(13, 4), 16); // 产品编号
                                //Element.ClassGuid = new Guid(Entity["ClassGuid"] as String);            // 设备安装类GUID

                                UsbDevices.Add(u);
                            }
                        }
                    }
                }
            }
            //if (UsbDevices.Count == 0) return null; else return UsbDevices.ToArray();




            //List<USB> list = new List<USB>();
            //ManagementObjectCollection collection;
            ////Win32_USBControllerDevice  WIN32_SerialPort
            //using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity"))
            //{
            //    collection = searcher.Get();
            //}

            //foreach (var device in collection)
            //{
            //    USB u = new USB();
            //    u.DeviceID = device.GetPropertyValue("DeviceID").ToString();
            //    //u.PNPDeviceID = device.GetPropertyValue("PNPDeviceID").ToString();
            //    //u.Description = device.GetPropertyValue("Description").ToString();
            //    //u.UsbName = device.GetPropertyValue("Name").ToString();
            //    list.Add(u);
            //}
            //collection.Dispose();
            //return list;
            return UsbDevices;
        }

        public static string 获取内存条大小()
        {
            double capacity = 0;
            ManagementClass cimobject1 = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc1 = cimobject1.GetInstances();
            foreach (ManagementObject mo1 in moc1)
            {
                capacity += ((Math.Round(Int64.Parse(mo1.Properties["Capacity"].Value.ToString()) / 1024 / 1024 / 1024.0, 1)));
            }
            moc1.Dispose();
            cimobject1.Dispose();
            return capacity.ToString();
        }

        public static string 系统_取内存个数()
        {
            ManagementObjectSearcher searcherd = new ManagementObjectSearcher("Select * From Win32_PhysicalMemory");
            foreach (ManagementObject mo in searcherd.Get())
            {
                return mo["Tag"].ToString();
            }
            return null;
        }

        public static string 取显卡信息()
        {
            try
            {
                ManagementObjectSearcher objvide = new ManagementObjectSearcher("select * from Win32_DisplayConfiguration");
                foreach (ManagementObject obj in objvide.Get())
                {
                    return obj["DeviceName"].ToString();
                }
                return "........";
            }
            catch
            {
                return "........";
            }
        }

        public static string 系统_主板厂商()
        {
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * from Win32_BaseBoard");
                foreach (ManagementObject mo in mos.Get())
                {
                    return mo["Manufacturer"].ToString();
                }
                return "........";
            }
            catch
            {
                return "........";
            }
        }

        public static string 系统_主板型号()
        {
            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * from Win32_BaseBoard");
                foreach (ManagementObject mo in mos.Get())
                {
                    return mo["Product"].ToString();
                }
                return "........";
            }
            catch
            {
                return "........";
            }
        }

        public static string 系统_CPU名称信息()
        {
            ManagementObjectSearcher driveId = new ManagementObjectSearcher("Select * from Win32_Processor");
            foreach (ManagementObject o in driveId.Get())
            {
                return o["Name"].ToString();
            }
            return null;
        }

        public static string 系统_64位()
        {
            if (Environment.Is64BitOperatingSystem == true)
            {
                return "64";
            }
            else return "32";
        }

        public static string Get显示器()
        {
            string str = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * from Win32_DesktopMonitor");
            foreach (ManagementObject mo in mos.Get())
            {
                str = mo["PNPDeviceID"].ToString();
            }
            return str;
        }

        //显示器个数
        public static int Get显示器个数()
        {
            int ssss;
            //string str = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * from Win32_DesktopMonitor");
            ssss = mos.Get().Count;
            
            //foreach (ManagementObject mo in mos.Get())
            //{
            //    str = mo["PNPDeviceID"].ToString();
            //}
            return ssss;
        }

        public static string GetMACAddress()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE ((MACAddress Is Not NULL) AND (Manufacturer <> 'Microsoft'))");
                string NetCardMACAddress = "";
                foreach (ManagementObject mo in searcher.Get())
                {
                    NetCardMACAddress = mo["MACAddress"].ToString().Trim();
                }
                return NetCardMACAddress;
            }
            catch
            {
                return "未知";
            }
        }

        //硬盘类
        public class HardDisk
        {
            public string DiskName;//分区名称

            public string DiskCaption;//产品名称

            public string Size;//总空间

            public string PNPDeviceID;

        }
        //获取所有硬盘
        public List<HardDisk> getExternalDisk()
        {
            List<HardDisk> list = new List<HardDisk>();
            
            ManagementClass mgtCls = new ManagementClass("Win32_DiskDrive");
            var disks = mgtCls.GetInstances();
            foreach (ManagementObject mo in disks)
            {
                //if (mo.Properties["MediaType"].Value != null &&
                //  !(mo.Properties["MediaType"].Value.ToString() == "Fixed hard disk media"))
                //{
                    foreach (ManagementObject diskPartition in mo.GetRelated("Win32_DiskPartition"))
                    {
                    foreach (ManagementBaseObject disk in diskPartition.GetRelated("Win32_LogicalDisk"))
                    { 
                        HardDisk disklist = new HardDisk();
                        disklist.DiskCaption = mo.Properties["Caption"].Value.ToString();
                        disklist.PNPDeviceID = mo.Properties["PNPDeviceID"].Value.ToString();
                        disklist.Size = mo.Properties["Size"].Value.ToString();
                        disklist.DiskName = mo.Properties["Caption"].Value.ToString();
                        var aaaaa = list.Where(i => i.DiskName == disklist.DiskName).ToList();
                        if (aaaaa.Count>0)
                        {
                            //MessageBox.Show("Test");
                        }
                        else
                        {
                            list.Add(disklist);
                            //HardDisk_lab.Text =list[list.Count-1].DiskName;
                            HardDisk_lab.Text = list[0].DiskName;
                        }
                    }                  
                }    
                //}
            }           
            return list;
        }

        public static string GetHardDiskID()
        {
            try
            {
                string hdId = string.Empty;
                ManagementClass hardDisk = new ManagementClass("win32_DiskDrive");
                ManagementObjectCollection hardDiskC = hardDisk.GetInstances();
                foreach (ManagementObject m in hardDiskC)
                {
                    hdId = m.Properties["Model"].Value.ToString();//
                }
                return hdId;
            }
            catch
            {
                return "未知";
            }
        }

        public static string Get操作系统()
        {
            try
            {
                //Win32_OperatingSystem
                //Win32_PhysicalMedia
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                string OS = "";
                foreach (ManagementObject mo in searcher.Get())
                {
                    OS = mo["Name"].ToString().Trim();
                    break;
                }
                return OS;
            }
            catch
            {
                return "";
            }
        }

        public static string GetUserName()
        {
            try
            {
                string st = "";
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {

                    st = mo["UserName"].ToString();

                }
                moc = null;
                mc = null;
                return st;
            }
            catch
            {
                return "unknow";
            }
            finally
            {
            }

        }

        public static string 获取内存条大小及频率()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher();   //用于查询一些如系统信息的管理对象 
            searcher.Query = new SelectQuery("Win32_PhysicalMemory ", "", new string[] { "Capacity" });//设置查询条件 
            ManagementObjectCollection collection = searcher.Get();   //获取内存容量 
            ManagementObjectCollection.ManagementObjectEnumerator em = collection.GetEnumerator();

            long capacity = 0;
            while (em.MoveNext())
            {
                ManagementBaseObject baseObj = em.Current;
                if (baseObj.Properties["Capacity"].Value != null)
                {
                    try
                    {
                        capacity += (long.Parse(baseObj.Properties["Capacity"].Value.ToString())) / 1024 / 1024 / 1024;
                    }
                    catch
                    {
                        capacity = 0;
                    }
                }
            }

            searcher.Query = new SelectQuery("Win32_PhysicalMemory ", "", new string[] { "Speed" });//设置查询条件 
            collection = searcher.Get();   //获取内存速度（即频率） 
            em = collection.GetEnumerator();

            string speed = "";
            while (em.MoveNext())
            {
                ManagementBaseObject baseObj = em.Current;
                if (baseObj.Properties["Speed"].Value != null)
                {
                    try
                    {
                        speed = baseObj.Properties["Speed"].Value.ToString();
                    }
                    catch
                    {
                        speed = "";
                    }
                }
            }
            string mi = "";
            if (capacity > 0 && speed.Length > 0)
            {
                mi = capacity.ToString() + " GB   " + speed + "MHz";
            }
            return mi;
        }

        /// <summary>
        /// 获得本机IP地址
        /// </summary>
        /// <param name="hostname"></param>
        /// <returns></returns>
        public static string DoGetHostEntry()
        {
            System.Net.IPHostEntry IpEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            string localhostipv4Address = "";

            for (int i = 0; i != IpEntry.AddressList.Length; i++)
            {
                if (!IpEntry.AddressList[i].IsIPv6LinkLocal)
                {
                    localhostipv4Address = IpEntry.AddressList[i].ToString();
                    break;
                }
            }

            return localhostipv4Address;
        }

        //获取硬盘信息
        public class HardDiskPartition
        {
            private string _PartitionName;//分区名称

            private double _FreeSpace;//空余大小

            private double _SumSpace;//总空间

            public double FreeSpace//空闲时间
            {
                get { return _FreeSpace; }
                set { this._FreeSpace = value; }
            }

            public double UseSpace// 使用空间
            {
                get { return _SumSpace - _FreeSpace; }
            }

            public double SumSpace//总空间
            {
                get { return _SumSpace; }
                set { this._SumSpace = value; }
            }

            public string PartitionName//分区名称
            {
                get { return _PartitionName; }
                set { this._PartitionName = value; }
            }

            public bool IsPrimary//是否主分区
            {
                get
                {
                    //判断是否为系统安装分区
                    if (System.Environment.GetEnvironmentVariable("windir").Remove(2) == this._PartitionName)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// 处理Double值，精确到小数点后几位
        /// </summary>
        /// <param name="_value">值</param>
        /// <param name="Length">精确到小数点后几位</param>
        /// <returns>返回值</returns>
        private double ManagerDoubleValue(double _value, int Length)
        {
            if (Length < 0)
            {
                Length = 0;
            }
            return System.Math.Round(_value, Length);
        }

        /// <summary>
        /// 获取硬盘上所有的盘符空间信息列表
        /// </summary>
        /// <returns></returns>
        private List<HardDiskPartition> GetDiskListInfo()
        {
            List<HardDiskPartition> list = null;
            //指定分区的容量信息
            try
            {
                SelectQuery selectQuery = new SelectQuery("select * from win32_logicaldisk");

                ManagementObjectSearcher searcher = new ManagementObjectSearcher(selectQuery);

                ManagementObjectCollection diskcollection = searcher.Get();
                if (diskcollection != null && diskcollection.Count > 0)
                {
                    list = new List<HardDiskPartition>();
                    HardDiskPartition harddisk = null;
                    foreach (ManagementObject disk in searcher.Get())
                    {
                        int nType = Convert.ToInt32(disk["DriveType"]);
                        if (nType != Convert.ToInt32(DriveType.Fixed))
                        {
                            continue;
                        }
                        else
                        {
                            harddisk = new HardDiskPartition();
                            harddisk.FreeSpace = Convert.ToDouble(disk["FreeSpace"]) / (1024 * 1024 * 1024);
                            harddisk.SumSpace = Convert.ToDouble(disk["Size"]) / (1024 * 1024 * 1024);
                            harddisk.PartitionName = disk["DeviceID"].ToString();
                            list.Add(harddisk);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return list;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            uiListBox1.Items.Clear();
            uiListBox2.Items.Clear();
            //uiListBox3.Items.Clear();
            timer1.Start();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            var user = it.tb_Configuration.Where(j => j.IP == IP).ToList();
            this.Text = user[0].Owner + "(" + user[0].AssetNumber + ")";
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 打开主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uiListBox1.Items.Clear();
            uiListBox2.Items.Clear();
            timer1.Start();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            var user = it.tb_Configuration.Where(j => j.IP == IP).ToList();
            this.Text = user[0].Owner + "(" + user[0].AssetNumber + ")";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            GetInfo();
            timer1.Stop();
        }
    }
}
