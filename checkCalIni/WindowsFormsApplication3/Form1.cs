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

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        static string section = "ASIC";
        static string key = "OSModuleInstalled";
        static string FailReply = "failed";
        static string defaultFail = "OSPI Muodule doesn't exist, can't run PS100";
        static string defaultGood = "OSPI Muodule Installed correctly set";
        static string defaultWrong = "OSPI Muodule Installed set wrong";
        static string progNotOpen = "MMI not open";
        static string processName = "mmi";
        static string fileName = @"\MachineSetup.ini";
        static int sleepTime = 1000;

        public Form1()
        {
            InitializeComponent();
            Thread t2 = new Thread(new ThreadStart(autoRun));
            t2.IsBackground = true;
            
            t2.Start();
            
        }

        private void autoRun()
        {
            while (true)
            {
                ProcessInfor px = GetPaths.getPathByProcessName(processName);
                delMethod d = new delMethod(UpdateTextBox);

                StringBuilder sb = new StringBuilder();

                if (px.bsucc)
                {
                    string filePath = px.processPath + fileName;
                    sb.Append(px.processPath);
                    string result = IniHelper.Read(section, key, FailReply, filePath);
                    if (result == FailReply)
                    {
                        this.BeginInvoke(d, textBox1, defaultFail, Color.Red);
                    }

                    else if (result == "1")
                    {
                        this.BeginInvoke(d, textBox1, defaultGood, Color.LightGreen);
                    }
                    else
                    {
                        this.BeginInvoke(d, textBox1, defaultWrong, Color.Red);
                    }


                }
                else
                {
                    this.BeginInvoke(d, textBox1, progNotOpen, Color.White);
                }

                sb.Append("\r\n\r\n");
                sb.Append(DateTime.Now.ToString());

                this.BeginInvoke(d, textBox2, sb.ToString(), Color.LightBlue);
                

                Thread.Sleep(sleepTime);
            }

            
        }

        public static void UpdateTextBox (TextBox t, string text, Color c)
        {
            t.Text = text;
            t.BackColor = c;
            t.Update();
        }

        public delegate void delMethod(TextBox t, string s, Color c);
    }
}
