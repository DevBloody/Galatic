using DiscordRpcDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galatic.Properties_UpdatesGame
{
    public partial class GalaticEngineUpdate : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public GalaticEngineUpdate()
        {
            InitializeComponent();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "In Update Settings | By Bloody";
            this.presence.largeImageKey = "new_project_3_";
            this.presence.smallImageKey = "";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v1.0");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("No Updates Available");
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "Updating... | By Bloody";
            this.presence.largeImageKey = "new_project_3_";
            this.presence.smallImageKey = "";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "In Main | By Bloody";
            this.presence.largeImageKey = "new_project_3_";
            this.presence.smallImageKey = "";
            DiscordRpc.UpdatePresence(ref this.presence);
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void GalaticEngineUpdate_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "Checking For Updates... | By Bloody";
            this.presence.largeImageKey = "new_project_3_";
            this.presence.smallImageKey = "";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}
