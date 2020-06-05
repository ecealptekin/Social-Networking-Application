namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.Button_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Add = new System.Windows.Forms.TextBox();
            this.btn_Current = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboinvites = new System.Windows.Forms.ComboBox();
            this.btn_Reject = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.Combo_Removal = new System.Windows.Forms.ComboBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_SendFriends = new System.Windows.Forms.Button();
            this.message_rich = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(89, 62);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(116, 22);
            this.textBox_ip.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(89, 97);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(116, 22);
            this.textBox_port.TabIndex = 3;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(16, 142);
            this.button_connect.Margin = new System.Windows.Forms.Padding(2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(93, 28);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(466, 231);
            this.logs.Margin = new System.Windows.Forms.Padding(2);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(326, 320);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Enabled = false;
            this.textBox_message.Location = new System.Drawing.Point(368, 24);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(129, 22);
            this.textBox_message.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message:";
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(514, 19);
            this.button_send.Margin = new System.Windows.Forms.Padding(2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(87, 32);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // Button_Name
            // 
            this.Button_Name.Location = new System.Drawing.Point(89, 24);
            this.Button_Name.Name = "Button_Name";
            this.Button_Name.Size = new System.Drawing.Size(116, 22);
            this.Button_Name.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username:";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(128, 142);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(90, 28);
            this.btn_Disconnect.TabIndex = 11;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Enabled = false;
            this.btn_Add.Location = new System.Drawing.Point(514, 74);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 31);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add Friend";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Add
            // 
            this.txt_Add.Enabled = false;
            this.txt_Add.Location = new System.Drawing.Point(368, 78);
            this.txt_Add.Name = "txt_Add";
            this.txt_Add.Size = new System.Drawing.Size(126, 22);
            this.txt_Add.TabIndex = 13;
            // 
            // btn_Current
            // 
            this.btn_Current.Enabled = false;
            this.btn_Current.Location = new System.Drawing.Point(512, 121);
            this.btn_Current.Name = "btn_Current";
            this.btn_Current.Size = new System.Drawing.Size(89, 31);
            this.btn_Current.TabIndex = 14;
            this.btn_Current.Text = "Friends";
            this.btn_Current.UseVisualStyleBackColor = true;
            this.btn_Current.Click += new System.EventHandler(this.btn_Current_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Current Incoming Invites";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Logs";
            // 
            // comboinvites
            // 
            this.comboinvites.Enabled = false;
            this.comboinvites.FormattingEnabled = true;
            this.comboinvites.Location = new System.Drawing.Point(75, 251);
            this.comboinvites.Name = "comboinvites";
            this.comboinvites.Size = new System.Drawing.Size(121, 24);
            this.comboinvites.TabIndex = 18;
            this.comboinvites.SelectedIndexChanged += new System.EventHandler(this.comboinvites_SelectedIndexChanged);
            // 
            // btn_Reject
            // 
            this.btn_Reject.Location = new System.Drawing.Point(283, 251);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.Size = new System.Drawing.Size(75, 23);
            this.btn_Reject.TabIndex = 19;
            this.btn_Reject.Text = "Reject";
            this.btn_Reject.UseVisualStyleBackColor = true;
            this.btn_Reject.Click += new System.EventHandler(this.btn_Reject_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(202, 251);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(75, 23);
            this.btn_Accept.TabIndex = 20;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // Combo_Removal
            // 
            this.Combo_Removal.Enabled = false;
            this.Combo_Removal.FormattingEnabled = true;
            this.Combo_Removal.Location = new System.Drawing.Point(75, 353);
            this.Combo_Removal.Name = "Combo_Removal";
            this.Combo_Removal.Size = new System.Drawing.Size(121, 24);
            this.Combo_Removal.TabIndex = 21;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Enabled = false;
            this.btn_Remove.Location = new System.Drawing.Point(202, 353);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 22;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Remove Friend";
            // 
            // btn_SendFriends
            // 
            this.btn_SendFriends.Enabled = false;
            this.btn_SendFriends.Location = new System.Drawing.Point(606, 20);
            this.btn_SendFriends.Name = "btn_SendFriends";
            this.btn_SendFriends.Size = new System.Drawing.Size(135, 30);
            this.btn_SendFriends.TabIndex = 24;
            this.btn_SendFriends.Text = "Send To Friends";
            this.btn_SendFriends.UseVisualStyleBackColor = true;
            this.btn_SendFriends.Click += new System.EventHandler(this.btn_SendFriends_Click);
            // 
            // message_rich
            // 
            this.message_rich.Location = new System.Drawing.Point(840, 231);
            this.message_rich.Name = "message_rich";
            this.message_rich.Size = new System.Drawing.Size(220, 319);
            this.message_rich.TabIndex = 25;
            this.message_rich.Text = "";
            this.message_rich.TextChanged += new System.EventHandler(this.message_rich_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(902, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Message Logs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 562);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.message_rich);
            this.Controls.Add(this.btn_SendFriends);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.Combo_Removal);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.btn_Reject);
            this.Controls.Add(this.comboinvites);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Current);
            this.Controls.Add(this.txt_Add);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button_Name);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox Button_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Add;
        private System.Windows.Forms.Button btn_Current;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboinvites;
        private System.Windows.Forms.Button btn_Reject;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.ComboBox Combo_Removal;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_SendFriends;
        private System.Windows.Forms.RichTextBox message_rich;
        private System.Windows.Forms.Label label8;
    }
}

