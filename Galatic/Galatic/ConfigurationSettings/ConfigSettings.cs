using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galatic.ConfigurationSettings.Language;
using DiscordRpcDemo;
namespace Galatic.ConfigurationSettings
{
    public partial class ConfigSettings : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public ConfigSettings()
        {
            InitializeComponent();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "In Settings | By Bloody";
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
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "In Language Settings | By Bloody";
            this.presence.largeImageKey = "new_project_3_";
            this.presence.smallImageKey = "";
            DiscordRpc.UpdatePresence(ref this.presence);
            this.Hide();
            LanguageApplier a = new LanguageApplier();
            a.Show();
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

        private void ConfigSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
