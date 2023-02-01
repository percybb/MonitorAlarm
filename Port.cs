using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
namespace MonitorAlarm
{
    public partial class Port : Form
    {
  
       
        public Port()
        {
            InitializeComponent();
        }

        private void Port_Load(object sender, EventArgs e)
        {
            String[]  listPort = SerialPort.GetPortNames();
            Array.Sort(listPort);
            cboList.Items.AddRange(listPort);
            StreamReader sr = new StreamReader("C:/Users/51915/Desktop/Teccart/5eme session/objet conecte/MonitorAlarm/MonitorAlarm/fichier/port.txt");
            string line;
            if((line=sr.ReadLine())!=null)
            {
                lblPort.Text = "Port stocké " + line;                
            }
            sr.Close();



        }

        private void btnChoix_Click(object sender, EventArgs e)       
        {
            if (cboList.SelectedIndex != -1)
            {
                serialPort1.PortName = cboList.SelectedItem.ToString();
                if(serialPort1.IsOpen)
                {
                   MessageBox.Show("Le port est ocupe!");
                }
                else
                {
                    MessageBox.Show("Le port est livre!");
                    //serialPort1.Open();
                    StreamWriter sw = new StreamWriter("C:/Users/51915/Desktop/Teccart/5eme session/objet conecte/MonitorAlarm/MonitorAlarm/fichier/port.txt",false);
                    sw.WriteLine(cboList.SelectedItem.ToString());
                    sw.Close();
                }

            }
            else
            {
                MessageBox.Show("Vous devez choissir un port");
            }            

        }

        private void lblPort_Click(object sender, EventArgs e)
        {

        }
    }
}
