using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Management;
using System.Management.Instrumentation;
using System.Collections.Specialized;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        NotifyIcon cpuPercentNotifyIcon;//notify icon in notification center
        Thread cpuPercentageNotify;
        Thread cpuPercentageWindow;
        Thread ramPercentageWindow;
        Thread hardDriveReadWrite;

        Icon cpuPercentIcon;//program basic icon
        #region icon_percent_declare
        Icon cpu1PercentIcon;
        Icon cpu2PercentIcon;
        Icon cpu3PercentIcon;
        Icon cpu4PercentIcon;
        Icon cpu5PercentIcon;
        Icon cpu6PercentIcon;
        Icon cpu7PercentIcon;
        Icon cpu8PercentIcon;
        Icon cpu9PercentIcon;
        Icon cpu10PercentIcon;
        Icon cpu11PercentIcon;
        Icon cpu12PercentIcon;
        Icon cpu13PercentIcon;
        Icon cpu14PercentIcon;
        Icon cpu15PercentIcon;
        Icon cpu16PercentIcon;
        Icon cpu17PercentIcon;
        Icon cpu18PercentIcon;
        Icon cpu19PercentIcon;
        Icon cpu20PercentIcon;
        Icon cpu21PercentIcon;
        Icon cpu22PercentIcon;
        Icon cpu23PercentIcon;
        Icon cpu24PercentIcon;
        Icon cpu25PercentIcon;
        Icon cpu26PercentIcon;
        Icon cpu27PercentIcon;
        Icon cpu28PercentIcon;
        Icon cpu29PercentIcon;
        Icon cpu30PercentIcon;
        Icon cpu31PercentIcon;
        Icon cpu32PercentIcon;
        Icon cpu33PercentIcon;
        Icon cpu34PercentIcon;
        Icon cpu35PercentIcon;
        Icon cpu36PercentIcon;
        Icon cpu37PercentIcon;
        Icon cpu38PercentIcon;
        Icon cpu39PercentIcon;
        Icon cpu40PercentIcon;
        Icon cpu41PercentIcon;
        Icon cpu42PercentIcon;
        Icon cpu43PercentIcon;
        Icon cpu44PercentIcon;
        Icon cpu45PercentIcon;
        Icon cpu46PercentIcon;
        Icon cpu47PercentIcon;
        Icon cpu48PercentIcon;
        Icon cpu49PercentIcon;
        Icon cpu50PercentIcon;
        Icon cpu51PercentIcon;
        Icon cpu52PercentIcon;
        Icon cpu53PercentIcon;
        Icon cpu54PercentIcon;
        Icon cpu55PercentIcon;
        Icon cpu56PercentIcon;
        Icon cpu57PercentIcon;
        Icon cpu58PercentIcon;
        Icon cpu59PercentIcon;
        Icon cpu60PercentIcon;
        Icon cpu61PercentIcon;
        Icon cpu62PercentIcon;
        Icon cpu63PercentIcon;
        Icon cpu64PercentIcon;
        Icon cpu65PercentIcon;
        Icon cpu66PercentIcon;
        Icon cpu67PercentIcon;
        Icon cpu68PercentIcon;
        Icon cpu69PercentIcon;
        Icon cpu70PercentIcon;
        Icon cpu71PercentIcon;
        Icon cpu72PercentIcon;
        Icon cpu73PercentIcon;
        Icon cpu74PercentIcon;
        Icon cpu75PercentIcon;
        Icon cpu76PercentIcon;
        Icon cpu77PercentIcon;
        Icon cpu78PercentIcon;
        Icon cpu79PercentIcon;
        Icon cpu80PercentIcon;
        Icon cpu81PercentIcon;
        Icon cpu82PercentIcon;
        Icon cpu83PercentIcon;
        Icon cpu84PercentIcon;
        Icon cpu85PercentIcon;
        Icon cpu86PercentIcon;
        Icon cpu87PercentIcon;
        Icon cpu88PercentIcon;
        Icon cpu89PercentIcon;
        Icon cpu90PercentIcon;
        Icon cpu91PercentIcon;
        Icon cpu92PercentIcon;
        Icon cpu93PercentIcon;
        Icon cpu94PercentIcon;
        Icon cpu95PercentIcon;
        Icon cpu96PercentIcon;
        Icon cpu97PercentIcon;
        Icon cpu98PercentIcon;
        Icon cpu99PercentIcon;
        Icon cpu100PercentIcon;

        #endregion


        public Form1()
        {
            InitializeComponent();
            #region minimize
            //minimize window
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            #endregion


            #region image_obj
            //icon image to obj
            cpuPercentIcon = new Icon("cpuussage.ico");
            #region cpu_percent_obj
            cpu1PercentIcon = new Icon("cpu1Percent.ico");
            cpu2PercentIcon = new Icon("cpu2Percent.ico");
            cpu3PercentIcon = new Icon("cpu3Percent.ico");
            cpu4PercentIcon = new Icon("cpu4Percent.ico");
            cpu5PercentIcon = new Icon("cpu5Percent.ico");
            cpu6PercentIcon = new Icon("cpu6Percent.ico");
            cpu7PercentIcon = new Icon("cpu7Percent.ico");
            cpu8PercentIcon = new Icon("cpu8Percent.ico");
            cpu9PercentIcon = new Icon("cpu9Percent.ico");
            cpu10PercentIcon = new Icon("cpu10Percent.ico");
            cpu11PercentIcon = new Icon("cpu11Percent.ico");
            cpu12PercentIcon = new Icon("cpu12Percent.ico");
            cpu13PercentIcon = new Icon("cpu13Percent.ico");
            cpu14PercentIcon = new Icon("cpu14Percent.ico");
            cpu15PercentIcon = new Icon("cpu15Percent.ico");
            cpu16PercentIcon = new Icon("cpu16Percent.ico");
            cpu17PercentIcon = new Icon("cpu17Percent.ico");
            cpu18PercentIcon = new Icon("cpu18Percent.ico");
            cpu19PercentIcon = new Icon("cpu19Percent.ico");
            cpu20PercentIcon = new Icon("cpu20Percent.ico");
            cpu21PercentIcon = new Icon("cpu21Percent.ico");
            cpu22PercentIcon = new Icon("cpu22Percent.ico");
            cpu23PercentIcon = new Icon("cpu23Percent.ico");
            cpu24PercentIcon = new Icon("cpu24Percent.ico");
            cpu25PercentIcon = new Icon("cpu25Percent.ico");
            cpu26PercentIcon = new Icon("cpu26Percent.ico");
            cpu27PercentIcon = new Icon("cpu27Percent.ico");
            cpu28PercentIcon = new Icon("cpu28Percent.ico");
            cpu29PercentIcon = new Icon("cpu29Percent.ico");
            cpu30PercentIcon = new Icon("cpu30Percent.ico");
            cpu31PercentIcon = new Icon("cpu31Percent.ico");
            cpu32PercentIcon = new Icon("cpu32Percent.ico");
            cpu33PercentIcon = new Icon("cpu33Percent.ico");
            cpu34PercentIcon = new Icon("cpu34Percent.ico");
            cpu35PercentIcon = new Icon("cpu35Percent.ico");
            cpu36PercentIcon = new Icon("cpu36Percent.ico");
            cpu37PercentIcon = new Icon("cpu37Percent.ico");
            cpu38PercentIcon = new Icon("cpu38Percent.ico");
            cpu39PercentIcon = new Icon("cpu39Percent.ico");
            cpu40PercentIcon = new Icon("cpu40Percent.ico");
            cpu41PercentIcon = new Icon("cpu41Percent.ico");
            cpu42PercentIcon = new Icon("cpu42Percent.ico");
            cpu43PercentIcon = new Icon("cpu43Percent.ico");
            cpu44PercentIcon = new Icon("cpu44Percent.ico");
            cpu45PercentIcon = new Icon("cpu45Percent.ico");
            cpu46PercentIcon = new Icon("cpu46Percent.ico");
            cpu47PercentIcon = new Icon("cpu47Percent.ico");
            cpu48PercentIcon = new Icon("cpu48Percent.ico");
            cpu49PercentIcon = new Icon("cpu49Percent.ico");
            cpu50PercentIcon = new Icon("cpu50Percent.ico");
            /*cpu51PercentIcon = new Icon("cpu51Percent.ico");
            cpu52PercentIcon = new Icon("cpu52Percent.ico");
            cpu53PercentIcon = new Icon("cpu53Percent.ico");
            cpu54PercentIcon = new Icon("cpu54Percent.ico");
            cpu55PercentIcon = new Icon("cpu55Percent.ico");
            cpu56PercentIcon = new Icon("cpu56Percent.ico");
            cpu57PercentIcon = new Icon("cpu57Percent.ico");
            cpu58PercentIcon = new Icon("cpu58Percent.ico");
            cpu59PercentIcon = new Icon("cpu59Percent.ico");
            cpu60PercentIcon = new Icon("cpu60Percent.ico");
            cpu61PercentIcon = new Icon("cpu61Percent.ico");
            cpu62PercentIcon = new Icon("cpu62Percent.ico");
            cpu63PercentIcon = new Icon("cpu63Percent.ico");
            cpu64PercentIcon = new Icon("cpu64Percent.ico");
            cpu65PercentIcon = new Icon("cpu65Percent.ico");
            cpu66PercentIcon = new Icon("cpu66Percent.ico");
            cpu67PercentIcon = new Icon("cpu67Percent.ico");
            cpu68PercentIcon = new Icon("cpu68Percent.ico");
            cpu69PercentIcon = new Icon("cpu69Percent.ico");
            cpu70PercentIcon = new Icon("cpu70Percent.ico");
            cpu71PercentIcon = new Icon("cpu71Percent.ico");
            cpu72PercentIcon = new Icon("cpu72Percent.ico");
            cpu73PercentIcon = new Icon("cpu73Percent.ico");
            cpu74PercentIcon = new Icon("cpu74Percent.ico");
            cpu75PercentIcon = new Icon("cpu75Percent.ico");
            cpu76PercentIcon = new Icon("cpu76Percent.ico");
            cpu77PercentIcon = new Icon("cpu77Percent.ico");
            cpu78PercentIcon = new Icon("cpu78Percent.ico");
            cpu79PercentIcon = new Icon("cpu79Percent.ico");
            cpu80PercentIcon = new Icon("cpu80Percent.ico");
            cpu81PercentIcon = new Icon("cpu81Percent.ico");
            cpu82PercentIcon = new Icon("cpu82Percent.ico");
            cpu83PercentIcon = new Icon("cpu83Percent.ico");
            cpu84PercentIcon = new Icon("cpu84Percent.ico");
            cpu85PercentIcon = new Icon("cpu85Percent.ico");
            cpu86PercentIcon = new Icon("cpu86Percent.ico");
            cpu87PercentIcon = new Icon("cpu87Percent.ico");
            cpu88PercentIcon = new Icon("cpu88Percent.ico");
            cpu89PercentIcon = new Icon("cpu89Percent.ico");
            cpu90PercentIcon = new Icon("cpu90Percent.ico");
            cpu91PercentIcon = new Icon("cpu91Percent.ico");
            cpu92PercentIcon = new Icon("cpu92Percent.ico");
            cpu93PercentIcon = new Icon("cpu93Percent.ico");
            cpu94PercentIcon = new Icon("cpu94Percent.ico");
            cpu95PercentIcon = new Icon("cpu95Percent.ico");
            cpu96PercentIcon = new Icon("cpu96Percent.ico");
            cpu97PercentIcon = new Icon("cpu97Percent.ico");
            cpu98PercentIcon = new Icon("cpu98Percent.ico");
            cpu99PercentIcon = new Icon("cpu99Percent.ico");
            cpu100PercentIcon = new Icon("cpu100Percent.ico");*/
            #endregion
            #endregion

            #region notify_icon
            //notify icon
            cpuPercentNotifyIcon = new NotifyIcon();
            cpuPercentNotifyIcon.Icon = cpuPercentIcon;
            cpuPercentNotifyIcon.Visible = true;
            #endregion

            #region context_menu
            //notify menu
            MenuItem quitMenuItem = new MenuItem("Quit");
            MenuItem openMenuItem = new MenuItem("Open");
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(quitMenuItem);
            contextMenu.MenuItems.Add(openMenuItem);

            //sets context menu to icon in nofication bar
            cpuPercentNotifyIcon.ContextMenu = contextMenu;
            #endregion

            #region click_menu
            //notify menu quit click event
            quitMenuItem.Click += quitMenuItem_Click;

            //notify menu open click event
            openMenuItem.Click += openMenuItem_Click;

            //start thread to grab cpu Percentage
            cpuPercentageNotify = new Thread(new ThreadStart(cpuPercentNotifyThread));
            cpuPercentageNotify.Start();
            cpuPercentageWindow = new Thread(new ThreadStart(cpuPercentageWindowThread));
            cpuPercentageWindow.Start();
            ramPercentageWindow = new Thread(new ThreadStart(ranPercentWindowThread));
            ramPercentageWindow.Start();
            hardDriveReadWrite = new Thread(new ThreadStart(hardDriveReadWriteThread));
            hardDriveReadWrite.Start();

        }

        void openMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Maximized;
        }

        void quitMenuItem_Click(object sender, EventArgs e)
        {
            cpuPercentageNotify.Abort();
            cpuPercentageWindow.Abort();
            ramPercentageWindow.Abort();
            hardDriveReadWrite.Abort();
            cpuPercentNotifyIcon.Dispose();
            this.Close();
        }
            #endregion

        #region cpu_precentage_Notify
        //thread to pull cpu percentage
        public void cpuPercentNotifyThread()
        {
            try
            {
                ManagementClass cpuDataClass = new ManagementClass("Win32_PerfFormattedData_PerfOS_Processor");

                //loop where finding cpu percentage
                while (true)
                {
                    ManagementObjectCollection cpuDataClassCollection = cpuDataClass.GetInstances();
                    foreach (ManagementObject obj in cpuDataClassCollection)
                    {
                        if (obj["Name"].ToString() == "_Total")
                        {
                            //test to see value of cpu percentage
                            Debug.WriteLine(Convert.ToUInt64(obj["PercentProcessorTime"]));
                            #region iconset
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 1)
                            {
                                cpuPercentNotifyIcon.Icon = cpu1PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 2)
                            {
                                cpuPercentNotifyIcon.Icon = cpu2PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 3)
                            {
                                cpuPercentNotifyIcon.Icon = cpu3PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 4)
                            {
                                cpuPercentNotifyIcon.Icon = cpu4PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 5)
                            {
                                cpuPercentNotifyIcon.Icon = cpu5PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 6)
                            {
                                cpuPercentNotifyIcon.Icon = cpu6PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 7)
                            {
                                cpuPercentNotifyIcon.Icon = cpu7PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 8)
                            {
                                cpuPercentNotifyIcon.Icon = cpu8PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 9)
                            {
                                cpuPercentNotifyIcon.Icon = cpu9PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 10)
                            {
                                cpuPercentNotifyIcon.Icon = cpu10PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 11)
                            {
                                cpuPercentNotifyIcon.Icon = cpu11PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 12)
                            {
                                cpuPercentNotifyIcon.Icon = cpu12PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 13)
                            {
                                cpuPercentNotifyIcon.Icon = cpu13PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 14)
                            {
                                cpuPercentNotifyIcon.Icon = cpu14PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 15)
                            {
                                cpuPercentNotifyIcon.Icon = cpu15PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 16)
                            {
                                cpuPercentNotifyIcon.Icon = cpu16PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 17)
                            {
                                cpuPercentNotifyIcon.Icon = cpu17PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 18)
                            {
                                cpuPercentNotifyIcon.Icon = cpu18PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 19)
                            {
                                cpuPercentNotifyIcon.Icon = cpu19PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 20)
                            {
                                cpuPercentNotifyIcon.Icon = cpu20PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 21)
                            {
                                cpuPercentNotifyIcon.Icon = cpu21PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 22)
                            {
                                cpuPercentNotifyIcon.Icon = cpu22PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 23)
                            {
                                cpuPercentNotifyIcon.Icon = cpu23PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 24)
                            {
                                cpuPercentNotifyIcon.Icon = cpu24PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 25)
                            {
                                cpuPercentNotifyIcon.Icon = cpu25PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 26)
                            {
                                cpuPercentNotifyIcon.Icon = cpu26PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 27)
                            {
                                cpuPercentNotifyIcon.Icon = cpu27PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 28)
                            {
                                cpuPercentNotifyIcon.Icon = cpu28PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 29)
                            {
                                cpuPercentNotifyIcon.Icon = cpu29PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 30)
                            {
                                cpuPercentNotifyIcon.Icon = cpu30PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 31)
                            {
                                cpuPercentNotifyIcon.Icon = cpu31PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 32)
                            {
                                cpuPercentNotifyIcon.Icon = cpu32PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 33)
                            {
                                cpuPercentNotifyIcon.Icon = cpu33PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 34)
                            {
                                cpuPercentNotifyIcon.Icon = cpu34PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 35)
                            {
                                cpuPercentNotifyIcon.Icon = cpu35PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 36)
                            {
                                cpuPercentNotifyIcon.Icon = cpu36PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 37)
                            {
                                cpuPercentNotifyIcon.Icon = cpu37PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 38)
                            {
                                cpuPercentNotifyIcon.Icon = cpu38PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 39)
                            {
                                cpuPercentNotifyIcon.Icon = cpu39PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 40)
                            {
                                cpuPercentNotifyIcon.Icon = cpu40PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 41)
                            {
                                cpuPercentNotifyIcon.Icon = cpu41PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 42)
                            {
                                cpuPercentNotifyIcon.Icon = cpu42PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 43)
                            {
                                cpuPercentNotifyIcon.Icon = cpu43PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 44)
                            {
                                cpuPercentNotifyIcon.Icon = cpu44PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 45)
                            {
                                cpuPercentNotifyIcon.Icon = cpu45PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 46)
                            {
                                cpuPercentNotifyIcon.Icon = cpu46PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 47)
                            {
                                cpuPercentNotifyIcon.Icon = cpu47PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 48)
                            {
                                cpuPercentNotifyIcon.Icon = cpu48PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 49)
                            {
                                cpuPercentNotifyIcon.Icon = cpu49PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 50)
                            {
                                cpuPercentNotifyIcon.Icon = cpu50PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 51)
                            {
                                cpuPercentNotifyIcon.Icon = cpu51PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 52)
                            {
                                cpuPercentNotifyIcon.Icon = cpu52PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 53)
                            {
                                cpuPercentNotifyIcon.Icon = cpu53PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 54)
                            {
                                cpuPercentNotifyIcon.Icon = cpu54PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 55)
                            {
                                cpuPercentNotifyIcon.Icon = cpu55PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 56)
                            {
                                cpuPercentNotifyIcon.Icon = cpu56PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 57)
                            {
                                cpuPercentNotifyIcon.Icon = cpu57PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 58)
                            {
                                cpuPercentNotifyIcon.Icon = cpu58PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 59)
                            {
                                cpuPercentNotifyIcon.Icon = cpu59PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 60)
                            {
                                cpuPercentNotifyIcon.Icon = cpu60PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 61)
                            {
                                cpuPercentNotifyIcon.Icon = cpu61PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 62)
                            {
                                cpuPercentNotifyIcon.Icon = cpu62PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 63)
                            {
                                cpuPercentNotifyIcon.Icon = cpu63PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 64)
                            {
                                cpuPercentNotifyIcon.Icon = cpu64PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 65)
                            {
                                cpuPercentNotifyIcon.Icon = cpu65PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 66)
                            {
                                cpuPercentNotifyIcon.Icon = cpu66PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 67)
                            {
                                cpuPercentNotifyIcon.Icon = cpu67PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 68)
                            {
                                cpuPercentNotifyIcon.Icon = cpu68PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 69)
                            {
                                cpuPercentNotifyIcon.Icon = cpu69PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 70)
                            {
                                cpuPercentNotifyIcon.Icon = cpu70PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 71)
                            {
                                cpuPercentNotifyIcon.Icon = cpu71PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 72)
                            {
                                cpuPercentNotifyIcon.Icon = cpu72PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 73)
                            {
                                cpuPercentNotifyIcon.Icon = cpu73PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 74)
                            {
                                cpuPercentNotifyIcon.Icon = cpu74PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 75)
                            {
                                cpuPercentNotifyIcon.Icon = cpu75PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 76)
                            {
                                cpuPercentNotifyIcon.Icon = cpu76PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 77)
                            {
                                cpuPercentNotifyIcon.Icon = cpu77PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 78)
                            {
                                cpuPercentNotifyIcon.Icon = cpu68PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 79)
                            {
                                cpuPercentNotifyIcon.Icon = cpu79PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 80)
                            {
                                cpuPercentNotifyIcon.Icon = cpu80PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 81)
                            {
                                cpuPercentNotifyIcon.Icon = cpu81PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 82)
                            {
                                cpuPercentNotifyIcon.Icon = cpu82PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 83)
                            {
                                cpuPercentNotifyIcon.Icon = cpu83PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 84)
                            {
                                cpuPercentNotifyIcon.Icon = cpu84PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 85)
                            {
                                cpuPercentNotifyIcon.Icon = cpu85PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 86)
                            {
                                cpuPercentNotifyIcon.Icon = cpu86PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 87)
                            {
                                cpuPercentNotifyIcon.Icon = cpu87PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 88)
                            {
                                cpuPercentNotifyIcon.Icon = cpu88PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 89)
                            {
                                cpuPercentNotifyIcon.Icon = cpu89PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 90)
                            {
                                cpuPercentNotifyIcon.Icon = cpu90PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 91)
                            {
                                cpuPercentNotifyIcon.Icon = cpu91PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 92)
                            {
                                cpuPercentNotifyIcon.Icon = cpu92PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 93)
                            {
                                cpuPercentNotifyIcon.Icon = cpu93PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 94)
                            {
                                cpuPercentNotifyIcon.Icon = cpu94PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 95)
                            {
                                cpuPercentNotifyIcon.Icon = cpu95PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 96)
                            {
                                cpuPercentNotifyIcon.Icon = cpu96PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 97)
                            {
                                cpuPercentNotifyIcon.Icon = cpu97PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 98)
                            {
                                cpuPercentNotifyIcon.Icon = cpu98PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 99)
                            {
                                cpuPercentNotifyIcon.Icon = cpu99PercentIcon;

                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) == 100)
                            {
                                cpuPercentNotifyIcon.Icon = cpu100PercentIcon;
                                MessageBox.Show("CPU OVERLOAD!!!");
                            }
                            #endregion
                        }
                        else
                        {

                        }
                    }

                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException tbe)
            {
                cpuPercentageNotify.Abort();
                cpuPercentNotifyIcon.Dispose();
            }
        }
        #endregion

        #region cpu_percentage_window
        public void cpuPercentageWindowThread()
        {

            try
            {
                ManagementClass cpuDataClass = new ManagementClass("Win32_PerfFormattedData_PerfOS_Processor");

                while (true)
                {
                    ManagementObjectCollection cpuDataClassCollection = cpuDataClass.GetInstances();
                    foreach (ManagementObject obj in cpuDataClassCollection)
                    {
                        if (obj["Name"].ToString() == "0")
                        {
                            cpu0.Invoke((MethodInvoker)(() => cpu0.Text = Convert.ToString(Convert.ToUInt64(obj["PercentProcessorTime"])) + '%'));
                            //sets color to text when between ranges
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) >= 0 && Convert.ToUInt64(obj["PercentProcessorTime"]) <= 50)//green
                            {
                                cpu0.ForeColor = Color.FromArgb(86, 189, 26);
                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) >= 51 && Convert.ToUInt64(obj["PercentProcessorTime"]) <= 80)//yellow
                            {
                                cpu0.ForeColor = Color.FromArgb(184, 178, 97);
                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) > 80)//red
                            {
                                cpu0.ForeColor = Color.FromArgb(240, 12, 12);
                            }
                        }
                        if (obj["Name"].ToString() == "1")
                        {
                            cpu1.Invoke((MethodInvoker)(() => cpu1.Text = Convert.ToString(Convert.ToUInt64(obj["PercentProcessorTime"])) + '%'));
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) >= 0 && Convert.ToUInt64(obj["PercentProcessorTime"]) <= 50)//green
                            {
                                cpu1.ForeColor = Color.FromArgb(86, 189, 26);
                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) >= 51 && Convert.ToUInt64(obj["PercentProcessorTime"]) <= 80)//yellow
                            {
                                cpu1.ForeColor = Color.FromArgb(184, 178, 97);
                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) > 80)//red
                            {
                                cpu1.ForeColor = Color.FromArgb(240, 12, 12);
                            }
                        }
                        if (obj["Name"].ToString() == "2")
                        {
                            cpu2.Invoke((MethodInvoker)(() => cpu2.Text = Convert.ToString(Convert.ToUInt64(obj["PercentProcessorTime"])) + '%'));
                            //sets color to text when between ranges
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) >= 0 && Convert.ToUInt64(obj["PercentProcessorTime"]) <= 50)//green
                            {
                                cpu2.ForeColor = Color.FromArgb(86, 189, 26);
                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) >= 51 && Convert.ToUInt64(obj["PercentProcessorTime"]) <= 80)//yellow
                            {
                                cpu2.ForeColor = Color.FromArgb(184, 178, 97);
                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) > 80)//red
                            {
                                cpu2.ForeColor = Color.FromArgb(240, 12, 12);
                            }
                        }
                        if (obj["Name"].ToString() == "3")
                        {
                            cpu3.Invoke((MethodInvoker)(() => cpu3.Text = Convert.ToString(Convert.ToUInt64(obj["PercentProcessorTime"])) + '%'));
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) >= 0 && Convert.ToUInt64(obj["PercentProcessorTime"]) <= 50)//green
                            {
                                cpu3.ForeColor = Color.FromArgb(86, 189, 26);
                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) >= 51 && Convert.ToUInt64(obj["PercentProcessorTime"]) <= 80)//yellow
                            {
                                cpu3.ForeColor = Color.FromArgb(184, 178, 97);
                            }
                            if (Convert.ToUInt64(obj["PercentProcessorTime"]) > 80)//red
                            {
                                cpu3.ForeColor = Color.FromArgb(240, 12, 12);
                            }
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException tbe)
            {
                cpuPercentageWindow.Abort();
                cpuPercentNotifyIcon.Dispose();
            }
        }
        #endregion

        #region ram_percentage_window
        private void ranPercentWindowThread()
        {
            try
            {
                ManagementClass ramDataClass = new ManagementClass("Win32_PerfFormattedData_PerfOS_Memory");

                while (true)
                {
                    ManagementObjectCollection ramDataClassCollection = ramDataClass.GetInstances();
                    foreach (ManagementObject obj in ramDataClassCollection)
                    {
                        ram.Invoke((MethodInvoker)(() => ram.Text = Convert.ToString(Convert.ToUInt32(obj["PercentCommittedBytesInUse"])) + '%'));
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException tbe)
            {
                ramPercentageWindow.Abort();
                cpuPercentNotifyIcon.Dispose();
            }
        }
        #endregion

        #region HDD_Read/Write
        private void hardDriveReadWriteThread()
        {
            try
            {
                ManagementClass hddDataClass = new ManagementClass("Win32_PerfFormattedData_PerfDisk_PhysicalDisk");
                while (true)
                {
                    ManagementObjectCollection hddDataClassCollection = hddDataClass.GetInstances();

                    foreach (ManagementObject obj in hddDataClassCollection)
                    {
                        if (obj["Name"].ToString() == "_Total")
                        {
                            if (Convert.ToUInt64(obj["DiskBytesPersec"]) > 0)
                            {
                                HDD_Light.Invoke((MethodInvoker)(() => HDD_Light.BackColor = Color.FromArgb(86, 189, 26)));//green is active
                                HDD_Light.Invoke((MethodInvoker)(() => HDD_Light.Text = "Active"));
                            }
                            else
                            {
                                HDD_Light.Invoke((MethodInvoker)(() => HDD_Light.BackColor = Color.FromArgb(240, 12, 12)));//red inactive
                                HDD_Light.Invoke((MethodInvoker)(() => HDD_Light.Text = "InActive"));
                            }
                        }
                    }
                }
            }catch(ThreadAbortException tbe)
            {
                hardDriveReadWrite.Abort();
                cpuPercentNotifyIcon.Dispose();
            }
        }
        #endregion
    }
}