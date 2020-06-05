using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace client
{
    public struct socnames
    {
        public Socket socket;
        public string username;
        private List<string> Friends;

        public List<string> friends
        {
            get
            {
                if (this.Friends == null)
                {
                    this.Friends = new List<string>();
                }

                return this.Friends;
            }
        }
    }

    public partial class Form1 : Form
    {

        bool terminating = false;
        bool connected = false;
        socnames clientSocket;
        
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            
            clientSocket.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.username = Button_Name.Text;
      
            string IP = textBox_ip.Text;

           
            int portNum;
            if(Int32.TryParse(textBox_port.Text, out portNum))
            {
                try
                {
                    clientSocket.socket.Connect(IP, portNum);
                    string username = Button_Name.Text;

                    if (username != "" && username.Length <= 128)
                    {
                        Byte[] buffer = new Byte[128];
                        buffer = Encoding.Default.GetBytes(username);
                        clientSocket.socket.Send(buffer);

                        
                    }
                    button_connect.Enabled = false;
                    textBox_message.Enabled = true;
                    button_send.Enabled = true;
                    btn_Add.Enabled = true;
                    btn_Current.Enabled = true;
                    txt_Add.Enabled = true;
                    connected = true;
                    comboinvites.Enabled = true;
                    Combo_Removal.Enabled = true;
                    btn_Remove.Enabled = true;
                    btn_SendFriends.Enabled = true;
                    logs.AppendText("Connected to the server!\n");

                    Thread receiveThread = new Thread(Receive);
                    receiveThread.Start();
                }
                catch
                {
                    button_connect.Enabled = true;
                    logs.AppendText("Could not connect to the server!\n");
                }
            }
            else
            {
                button_connect.Enabled = true;
                logs.AppendText("Check the port\n");
            }

        }

        private void Receive()
        {
            while(connected)
            {   
                try
                {
                    Byte[] buffer = new Byte[256];
                    clientSocket.socket.Receive(buffer);

                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                    if (incomingMessage == "You are not in database, disconnecting" || incomingMessage == "You are already connected")
                    {
                        connected = false;
                        button_connect.Enabled = true;
                        button_send.Enabled = false;
                        textBox_message.Enabled = false;
                    }
                    else if (incomingMessage.Contains("%"))
                    {
                     string line;
                     StringReader strReader = new StringReader(incomingMessage);
                     while (true)
                     {
                         line = strReader.ReadLine();
                         if (line != null)
                         {
                             if (line.Contains(clientSocket.username))
                             { 
                                 string[] tmp = line.Split('%');
                                 if (tmp[0] == clientSocket.username)
                                 {

                                     if (!Combo_Removal.Items.Contains(tmp[1]))
                                     {
                                         Combo_Removal.Items.Add(tmp[1]);
                                     }
                                         if (!clientSocket.friends.Contains(tmp[1]))
                                     {
                                         clientSocket.friends.Add(tmp[1]);
                                      
                                         logs.AppendText("You become friend with " + tmp[1] + "\n");
                                     }
                                     
                                 }
                                 else
                                 {
                                     if (!Combo_Removal.Items.Contains(tmp[0]))
                                     {
                                         Combo_Removal.Items.Add(tmp[0]);
                                     }
                                     if (!clientSocket.friends.Contains(tmp[0]))
                                     {

                                         clientSocket.friends.Add(tmp[0]);
                                        
                                         logs.AppendText("You become friend with " + tmp[0] + "\n");
                                     }

                                 }
                             }

                         }
                         else
                         {
                             break;
                         }
                     }
                    
                    }
                    else if (incomingMessage.Contains("**"))
                    {
                        MessageBox.Show(incomingMessage);
                     
                    }
                    else if (incomingMessage.Contains("To my friends"))
                    {
                        if (incomingMessage.Contains("Getit"))
                        {
                            if (incomingMessage.Contains(clientSocket.username))
                            {
                                string printmessage = incomingMessage.Replace(" To my friends", "");
                                printmessage = printmessage.Replace("System.Windows.Forms.TextBox, Text: ", "");
                                StringReader strReader = new StringReader(printmessage);
                                string line;
                                while (true)
                                {
                                    line = strReader.ReadLine();
                                    if (line != null)
                                    {
                                        if (line.Contains("Getit"))
                                        {

                                        }
                                        else
                                        {
                                            if (!message_rich.Text.Contains(line))
                                            {
                                                if (!line.Contains(clientSocket.username))
                                                {
                                                    logs.AppendText(line + "\n");
                                                    message_rich.AppendText("To: " + clientSocket.username + " -- " + line + "\n");
                                                }
                                                }
                                            else
                                            {
                                                int index = message_rich.Text.IndexOf(line);
                                                index -= 5;
                                                if (clientSocket.username.Contains(message_rich.Text.Substring(index, 3)))
                                                {
                                                    if (!line.Contains(clientSocket.username))
                                                    {
                                                    logs.AppendText(line + "\n");
                                                    message_rich.AppendText("To: " + clientSocket.username + " -- " + line + "\n");
                                                }
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }


                                }

                            }
                        }
                    }
                    else if (incomingMessage.Contains("$"))
                    {
                        string line;
                        StringReader strReader = new StringReader(incomingMessage);
                        while (true)
                        {
                            line = strReader.ReadLine();
                            if (line != null)
                            {
                                if (line.Contains(clientSocket.username))
                                {
                                    string[] tmp = line.Split('$');
                                    if (tmp[0] == clientSocket.username)
                                    {

                                    }
                                    else
                                    {
                                        if (!clientSocket.friends.Contains(tmp[0]))
                                        {
                                            clientSocket.friends.Add(tmp[0]);
                                            logs.AppendText("You rejected from " + tmp[0] + "\n");
                                        }

                                    }
                                }

                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                    else if (incomingMessage.Contains("-->"))
                    {
                        if (incomingMessage.Length > 3)
                        {
                            string line;
                            StringReader strReader = new StringReader(incomingMessage);
                            comboinvites.Items.Clear();

                            while (true)
                            {
                                line = strReader.ReadLine();
                                if (line != null)
                                {
                                    int lastName = line.LastIndexOf(">") + 1;
                                    int lastIndex = line.Length - lastName;
                                    if (line.Substring(lastName, lastIndex) == Button_Name.Text)
                                    {
                                        comboinvites.Items.Add(line.Substring(0, lastName - 3));


                                    }
                                }
                                else
                                {
                                    break;
                                }


                            }
                        }




                    }
                    else
                    {
                        logs.AppendText(incomingMessage + "\n");
                    }
                    }
                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("Disconnected from server\n");
                        button_connect.Enabled = true;
                        textBox_message.Enabled = false;
                        button_send.Enabled = false;
                    }

                    clientSocket.socket.Close();
                    connected = false;
                    button_connect.Enabled = true;
                    button_send.Enabled = false;
                    textBox_message.Enabled = false;
                }

            }
        }


        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;
            message = Button_Name.Text + ": " + message;
            if (message != "" && message.Length <= 128)
            {
                Byte[] buffer = new Byte[128];
                buffer = Encoding.Default.GetBytes(message);
                clientSocket.socket.Send(buffer);
                logs.AppendText("Message sent to other clients\n");
                textBox_message.Text = "";
            }
            else {

                logs.AppendText("Your message is too long, please try shorter message!\n");
                textBox_message.Text = "";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            Combo_Removal.Items.Clear();
            button_connect.Enabled = true;
            clientSocket.socket.Close();
            connected = false;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string message = txt_Add.Text;
            message = message + btn_Add.Text;
            if (message != "" && message.Length <= 128)
            {
                Byte[] buffer = new Byte[128];
                buffer = Encoding.Default.GetBytes(message);
                clientSocket.socket.Send(buffer);
                txt_Add.Text = "";            
            }
            else
            {

                logs.AppendText("Your request is too long, please try shorter request!\n");
                textBox_message.Text = "";
            }



        }

        private void btn_Current_Click(object sender, EventArgs e)
        {
            Byte[] buffer = new Byte[128];
            buffer = Encoding.Default.GetBytes("Request");
            clientSocket.socket.Send(buffer);

        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            string friend;
            friend = comboinvites.SelectedItem.ToString();
            Byte[] buffer = new Byte[128];
            buffer = Encoding.Default.GetBytes(friend + "++");
            clientSocket.socket.Send(buffer);
            comboinvites.Items.Remove(comboinvites.SelectedItem);           
            comboinvites.Text = "";
            
        }

        private void btn_Reject_Click(object sender, EventArgs e)
        {
            string friend;
            friend = comboinvites.SelectedItem.ToString();
            Byte[] buffer = new Byte[128];
            buffer = Encoding.Default.GetBytes(friend +"--");
            clientSocket.socket.Send(buffer);
            comboinvites.Items.Remove(comboinvites.SelectedItem);          
            comboinvites.Text = "";
            
            logs.AppendText("You rejected to " + friend +"\n");
        }

        private void comboinvites_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btn_SendFriends_Click(object sender, EventArgs e)
        {
            Byte[] buffer = new Byte[128];
            buffer = Encoding.Default.GetBytes(clientSocket.username + " To my friends: " + textBox_message);
            clientSocket.socket.Send(buffer);
            textBox_message.Text = "";
            logs.AppendText("Message sent to Friends\n");
            
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string friend;
            friend = Combo_Removal.SelectedItem.ToString();
            Byte[] buffer = new Byte[128];
            buffer = Encoding.Default.GetBytes(friend + "~");
            clientSocket.socket.Send(buffer);
            Combo_Removal.Items.Remove(Combo_Removal.SelectedItem);
            Combo_Removal.Text = "";
            logs.AppendText("You removed your friendship with " + friend + "\n");
        }

        private void message_rich_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
