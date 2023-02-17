using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galatic.Properties_UpdatesGame;
using Galatic.ConfigurationSettings;
using Galatic.ConfigurationSettings.Language;
using System.Diagnostics;
using DiscordRpcDemo;
namespace Galatic
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Form1()
        {
            InitializeComponent();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "In Main | By Bloody";
            this.presence.largeImageKey = "new_project_3_";
            this.presence.smallImageKey = "";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GalaticEngineUpdate update = new GalaticEngineUpdate();
            update.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1075597879156154438", ref this.handlers, true, null);
            this.presence.details = "Playing GalaticApp";
            this.presence.state = "In Settings | By Bloody";
            this.presence.largeImageKey = "new_project_3_";
            this.presence.smallImageKey = "";
            DiscordRpc.UpdatePresence(ref this.presence);
            this.Hide();
            ConfigSettings s = new ConfigSettings();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://GalaticWeb.hackers23980543.repl.co");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming In 2026!, So Please Wait For More Updates!", "Note");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/nA4CScf4");
        }
    }
}
