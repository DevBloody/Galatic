using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRpcDemo;

namespace Galatic.ConfigurationSettings.Language
{
    public partial class LanguageApplier : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public LanguageApplier()
        {
            InitializeComponent();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "Changine App Language | By Bloody";
            this.presence.largeImageKey = "new_project_3_";
            this.presence.smallImageKey = "";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
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

        private void LanguageApplier_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
