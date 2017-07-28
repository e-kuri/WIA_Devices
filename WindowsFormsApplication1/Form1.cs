using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var deviceManager = new WIA.DeviceManager();
            var deviceNumbers = deviceManager.DeviceInfos.Count;

            if(deviceNumbers > 0)
            {
                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    var deviceName = deviceManager.DeviceInfos[i].Properties["Name"].get_Value().ToString();
                    listBox1.Items.Add(deviceName);
                }
            }
            else
            {
                listBox1.Items.Add("No devices");
            }
                

        }
    }
}
