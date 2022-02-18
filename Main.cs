using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class 华为儿童手表工具箱 : MetroForm
    {
        public 华为儿童手表工具箱()
        {
           InitializeComponent();
        }
        bool state = true;
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (state) 
            {
                this.Theme = MetroThemeStyle.Dark;
                this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.adwql_wue07_001;
                this.Refresh();
            }
            else
            {
                this.Theme = MetroThemeStyle.Light;
                this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.akk18_8xw7j_001;
                this.Refresh();
            }
            state = !state;
        }

        private void 华为儿童手表工具箱_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Soft soft = new Soft();
            soft.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            stats.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Devices devices = new Devices();
            devices.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
