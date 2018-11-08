using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace CPUBrust
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        static int count = 0;
        Thread t1, t2, t3, t4;
        static int sp1, sp2, sp3, sp4;
        static ThreadPriority pr1, p2, p3, p4;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PPriority.SelectedIndex = 0;
            TPriority1.SelectedIndex = 2;
            TActivity1.SelectedIndex = 1;
            TPriority2.SelectedIndex = 2;
            TActivity2.SelectedIndex = 1;
            TPriority3.SelectedIndex = 2;
            TActivity3.SelectedIndex = 1;
            TPriority4.SelectedIndex = 2;
            TActivity4.SelectedIndex = 1;
        }
        private void TActivity1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TActivity1.Text)
            {
                case "Low": sp1 = 1000; break;
                case "Medium": sp1 = 100; break;
                case "Busy": sp1 = 10; break;
            }
        }

        private void TPriority1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (TPriority1.Text)
                {
                    case "Lowest": t1.Priority = ThreadPriority.Lowest; break;
                    case "Below Normal": t1.Priority = ThreadPriority.BelowNormal; break;
                    case "Normal": t1.Priority = ThreadPriority.Normal; break;
                    case "Above Normal": t1.Priority = ThreadPriority.AboveNormal; break;
                    case "Highest": t1.Priority = ThreadPriority.Highest; break;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void cb_Activity1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Activity1.Checked == true)
            {
                t1 = new Thread(ham_thread1);
                t1.IsBackground = true;
                t1.Start();
            }
            else
            {
                t1.Abort();
            }
        }

        void ham_thread1()
        {
            while (true)
            {
                count++;
                if (count == 10) count = 0;
                Thread.Sleep(sp1);
            }
        }

        private void cb_Activity2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Activity1.Checked == true)
            {
                t1 = new Thread(ham_thread2);
                t1.IsBackground = true;
                t1.Start();
            }
            else
            {
                t1.Abort();
            }
        }

        void ham_thread2()
        {
            while (true)
            {
                count++;
                if (count == 10) count = 0;
                Thread.Sleep(sp1);
            }
        }

        private void cb_Activity3_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Activity1.Checked == true)
            {
                t1 = new Thread(ham_thread3);
                t1.IsBackground = true;
                t1.Start();
            }
            else
            {
                t1.Abort();
            }
        }

        void ham_thread3()
        {
            while (true)
            {
                count++;
                if (count == 10) count = 0;
                Thread.Sleep(sp1);
            }
        }

        private void cb_Activity4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Activity1.Checked == true)
            {
                t1 = new Thread(ham_thread4);
                t1.IsBackground = true;
                t1.Start();
            }
            else
            {
                t1.Abort();
            }
        }

        void ham_thread4()
        {
            while (true)
            {
                count++;
                if (count == 10) count = 0;
                Thread.Sleep(sp1);
            }
        }

        private void TActivity2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TActivity2.Text)
            {
                case "Low": sp1 = 1000; break;
                case "Medium": sp1 = 100; break;
                case "Busy": sp1 = 10; break;
            }
        }

        private void TPriority2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (TPriority2.Text)
                {
                    case "Lowest": t1.Priority = ThreadPriority.Lowest; break;
                    case "Below Normal": t1.Priority = ThreadPriority.BelowNormal; break;
                    case "Normal": t1.Priority = ThreadPriority.Normal; break;
                    case "Above Normal": t1.Priority = ThreadPriority.AboveNormal; break;
                    case "Highest": t1.Priority = ThreadPriority.Highest; break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void TActivity3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TActivity3.Text)
            {
                case "Low": sp1 = 1000; break;
                case "Medium": sp1 = 100; break;
                case "Busy": sp1 = 10; break;
            }
        }

        private void TPriority3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (TPriority3.Text)
                {
                    case "Lowest": t1.Priority = ThreadPriority.Lowest; break;
                    case "Below Normal": t1.Priority = ThreadPriority.BelowNormal; break;
                    case "Normal": t1.Priority = ThreadPriority.Normal; break;
                    case "Above Normal": t1.Priority = ThreadPriority.AboveNormal; break;
                    case "Highest": t1.Priority = ThreadPriority.Highest; break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void TActivity4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TActivity4.Text)
            {
                case "Low": sp1 = 1000; break;
                case "Medium": sp1 = 100; break;
                case "Busy": sp1 = 10; break;
            }
        }

        private void TPriority4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (TPriority4.Text)
                {
                    case "Lowest": t1.Priority = ThreadPriority.Lowest; break;
                    case "Below Normal": t1.Priority = ThreadPriority.BelowNormal; break;
                    case "Normal": t1.Priority = ThreadPriority.Normal; break;
                    case "Above Normal": t1.Priority = ThreadPriority.AboveNormal; break;
                    case "Highest": t1.Priority = ThreadPriority.Highest; break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_Count.Text = count.ToString();
        }

        private void cb_shared_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_shared.Checked)
            {
                count = 0;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void PPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PPriority.SelectedIndex == 1)
                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            else Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;
        }
    }
}
