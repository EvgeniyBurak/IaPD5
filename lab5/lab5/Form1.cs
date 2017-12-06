using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private readonly List<Device> devices;

        private int _item;

        public Form1()
        {
            InitializeComponent();
            devices = DeviceManager.GetDevices();
            foreach (var _device in devices)
            {
                ListOfDevices.Items.Add(_device.Name);
            }
            TurnOn.Click += TurnOnClicked;
            TurnOff.Click += TurnOffClicked;
            ListOfDevices.Click += ItemSelected;
        }

        private void ShowInformation(Device device)
        {
        

            textBox1.Text = device.ClassGuid;
            textBox2.Text = device.HardwareId;
            textBox3.Text = device.Manufacturer;
            textBox4.Text = device.Provider;
            textBox5.Text = device.Description;
            textBox6.Text = device.DevicePath;
            textBox7.Text = device.SysPath;
            if (device.Status == true)
            {
                label13.Text = "Turn On";
                label15.Text = "";
            }
            else
            {
                label15.Text = "Turn Off";
                label13.Text = "";
            }
           
            TurnOn.Enabled = !device.Status;
            TurnOff.Enabled = device.Status;
        }

        private void ItemSelected(object sender, EventArgs e)
        {
            ShowInformation(devices[ListOfDevices.SelectedItems[0].Index]);
            _item = ListOfDevices.SelectedItems[0].Index;
        }

        private void TurnOnClicked(object sender, EventArgs e)
        {
            try
            {
                devices[_item].ChangeConnection("Enable");
                devices[_item].Status = !devices[_item].Status;
                ShowInformation(devices[ListOfDevices.SelectedItems[0].Index]);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Устройство не может быть включено.");
            }
        }

        private void TurnOffClicked(object sender, EventArgs e)
        {
            try
            {
                devices[_item].ChangeConnection("Disable");
                devices[_item].Status = !devices[_item].Status;
                ShowInformation(devices[ListOfDevices.SelectedItems[0].Index]);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Устройство не может быть отключено.");
            }
        }

       
    }
}
