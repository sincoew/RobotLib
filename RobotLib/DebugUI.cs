using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotLib
{
    public partial class DebugUI : Form
    {
        private const int WM_LBUTTONDOWM = 0x0201;
        private const int WM_NCLBUTTONDOWM = 0x00A1;
        private const int HTCAPTION = 2;

        public DebugUI()
        {
            InitializeComponent();
        }

        private void DebugUI_Load(object sender, EventArgs e)
        {
            this.LogListbox.DrawMode = DrawMode.OwnerDrawFixed;
            this.LogListbox.DrawItem += OnLogListbox_DrawItem;
        }

        private void OnLogListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (list.Items.Count <= 0)
                return;

            if (LogListbox.Items[e.Index].ToString().Contains("[Error]")) //Set log color
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
            }
            else if (LogListbox.Items[e.Index].ToString().Contains("[Warning]"))
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Orange), e.Bounds);
            }
            else if (LogListbox.Items[e.Index].ToString().Contains("[Normal]"))
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.GreenYellow), e.Bounds);
            }
            else
            {

            }
            e.Graphics.DrawString(list.Items[e.Index].ToString(), this.Font, Brushes.Black, e.Bounds);
        }

        Mutex _Mut = new Mutex();
        List<String> LogBuf = new List<string>();

        private void OnLogChange(String Msg)
        {
            _Mut.WaitOne();

            LogBuf.Add(Msg);
            LogBuf.Add("--------");
            _Mut.ReleaseMutex();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Mut.WaitOne();
            foreach (String Temp in LogBuf)
            {
                String[] SplitStr = Temp.Split("\r\n".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (String SpTemp in SplitStr)
                {
                    LogListbox.Items.Add(SpTemp);
                    LogListbox.SetSelected(LogListbox.Items.Count - 1, true);
                    LogListbox.SetSelected(LogListbox.Items.Count - 1, false);
                    StreamWriter sw = new StreamWriter("Temp.txt", true);
                    sw.WriteLine(Temp);
                    sw.Close();
                }
            }
            LogBuf.Clear();
            _Mut.ReleaseMutex();
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {

        }

    }

}
