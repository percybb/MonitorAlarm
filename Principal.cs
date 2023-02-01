using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorAlarm
{
    public partial class Principal : Form
    {

        Label[] fene = new Label[5];
        Label[] port = new Label[9];
        Label[] dm = new Label[2];
        Label[] di = new Label[3];
        public Principal()
        {
            InitializeComponent();
        }

        private void portSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Port port = new Port();
            port.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            fene[0] = F1;
            fene[1] = F2;
            fene[2] = F3;
            fene[3] = F4;
            fene[4] = F5;
           


            port[0] = P1;
            port[1] = P2;
            port[2] = P3;
            port[3] = P4;
            port[4] = P5;
            port[5] = P6;
            port[6] = P7;
            port[7] = P8;
            port[8] = P9;

            dm[0] = DM1;
            dm[1] = DM2;

            di[0] = DI1;
            di[1] = DI2;
            di[2] = DI3;



            CheckForIllegalCrossThreadCalls = false;
            StreamReader sr = new StreamReader("C:/Users/51915/Desktop/Teccart/5eme session/objet conecte/MonitorAlarm/MonitorAlarm/fichier/port.txt");
            string line;
            if ((line = sr.ReadLine()) != null)
            {
                try
                {

                    serialPort1.PortName = line;
                    serialPort1.BaudRate = 9800;
                    serialPort1.ReceivedBytesThreshold = 11;
                    if (serialPort1.IsOpen)
                    {
                        statusPort.Text = "Port non connecte ";
                    }
                    else
                    {
                        serialPort1.Open();
                        statusPort.Text = "Port " + line;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    statusPort.Text = "Port non ouvert";
                }
            }
            sr.Close();


        }

 

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

        //    ListViewItem list = new ListViewItem(textBox1.Text);
        //    list.SubItems.Add(textBox2.Text);
        //    list.BackColor = Color.Red;
        //    listView1.Items.Add(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (serialPort1.IsOpen)
            {
                listView1.Items.Clear();
                byte[] msg2 = new byte[3];
                msg2[0] = 11;
                msg2[1] = 0;
                msg2[2] = 0;               

                foreach(Label i in fene)
                {
                    i.BackColor = Color.Green;
                }
                foreach (Label i in port)
                {
                    i.BackColor = Color.Green;
                }
                foreach (Label i in dm)
                {
                    i.BackColor = Color.Green;
                }
                foreach (Label i in di)
                {
                    i.BackColor = Color.Green;
                }

                serialPort1.Write(msg2, 0, 3);
                //String type = cad.Substring(0, 1);
                //String nombre = cad.Substring(1, 1);
                //String status = cad.Substring(2, 1);


            }
        }

        private void statusPort_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:/Users/51915/Desktop/Teccart/5eme session/objet conecte/MonitorAlarm/MonitorAlarm/fichier/port.txt");
       
            string line;
            if ((line = sr.ReadLine()) != null)
            {
                try
                {
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.PortName = line;
                        serialPort1.BaudRate = 9800;
                        serialPort1.Open();
                        statusPort.Text = "Port " + line;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    statusPort.Text = "Port non ouvert";
                }
            }
            sr.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

           // String cad = serialPort1.ReadLine();

            byte[] msg1 = new byte[11];
            byte[] dat = new byte[8];
            serialPort1.Read(msg1, 0, 11);

            //String type = cad.Substring(0, 1);
            //String nombre = cad.Substring(1, 1);
            //String status = cad.Substring(2, 1);

            byte type =  msg1[0];
            byte nombre = msg1[1];
            byte status = msg1[2];

            dat[0] = msg1[3];
            dat[1] = msg1[4];
            dat[2] = msg1[5];
            dat[3] = msg1[6];
            dat[4] = msg1[7];
            dat[5] = msg1[8];
            dat[6] = msg1[9];
            dat[7] = msg1[10];


            DateTime myDateTime = DateTime.FromBinary(BitConverter.ToInt64(dat, 0));

            //DateTime date = DateTime.Now;

            ListViewItem list = new ListViewItem(myDateTime.ToString());

            String typeMsg = "";
            if (type == 0)
            {
                typeMsg = "Fenetre ";
                fene[Convert.ToInt32(nombre)].BackColor = ((status == 0) ? Color.Green : Color.Red);
            }
            else if (type == 1)
            {
                typeMsg = "Porte ";
                port[Convert.ToInt32(nombre)].BackColor = ((status == 0) ? Color.Green : Color.Red);
            }
            else if (type == 2)
            {
                typeMsg = "Mouvement ";
                dm[Convert.ToInt32(nombre)].BackColor = ((status == 0) ? Color.Green : Color.Red);
            }
            else if (type == 3)
            {
                typeMsg = "Incendie ";
                di[Convert.ToInt32(nombre)].BackColor = ((status == 0) ? Color.Green : Color.Red);
            }
            else if(type==10)
            {
                statusCon.Text = "Connecte";
            }

            if(type!=10)
            { 
                String msg = typeMsg + (nombre+1) + ((status == 0) ? " est ferme" : " es ouvert");
                list.SubItems.Add(msg);
                if (status == 0)
                {
                    list.BackColor = Color.Green;
                }
                else
                {
                    list.BackColor = Color.Red;
                }
                list.ForeColor = Color.White;
                listView1.Items.Add(list);
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
