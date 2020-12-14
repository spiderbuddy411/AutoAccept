using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using LCUAPI.API.Models;
using System.Net;
using RestSharp;
using LCUAPI.API;
using Newtonsoft.Json;
using ClassicDarkTheme.Dark;
using System.Diagnostics;

/*
 LCUTool coded by Lufzys https://github.com/Lufzys
 */

namespace LCUTool // https://lcu.vivide.re // Need RestSharp & Newtonsoft.Json & Costura.Fody
{
    public partial class MainForm : Form
    {
        SummonerObject.Summoner summoner = new SummonerObject.Summoner();
        Matchmaking.ReadyCheck readyCheck = new Matchmaking.ReadyCheck();
        LolStore.Wallet wallet = new LolStore.Wallet();
        ChampionSummary champSummary = new ChampionSummary();
        SummonerProfile summonerProfile = new SummonerProfile();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Dark.LoadFont();
            Process[] p = Process.GetProcessesByName("LeagueClientUx");
            if (p.Length != 0)
            {
                string showUx = LCU.GetRequest(RestSharp.Method.POST, "/riotclient/ux-show");


                string output = LCU.GetRequest(RestSharp.Method.GET, "/lol-summoner/v1/current-summoner", RestSharp.DataFormat.Json);
                Console.WriteLine(output);
                summoner = JsonConvert.DeserializeObject<SummonerObject.Summoner>(output);
                pbAvatar.ImageLocation = "http://ddragon.leagueoflegends.com/cdn/10.24.1/img/profileicon/" + summoner.ProfileIconId + ".png";
                lblName.Text = summoner.DisplayName;
                pbLevelProgress.Value = summoner.PercentCompleteForNextLevel;
                lblLevel.Text = summoner.SummonerLevel + " (" + summoner.XpUntilNextLevel + "/" + summoner.XpSinceLastLevel + ")";

                string walletJson = LCU.GetRequest(RestSharp.Method.GET, "/lol-store/v1/wallet");
                wallet = JsonConvert.DeserializeObject<LolStore.Wallet>(walletJson);
                lblRP.Text = wallet.RP.ToString();
                lblBlueEssence.Text = wallet.BlueEssence.ToString();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private static bool AutoAccept = false;
        private static bool AutoSkinBoost = false;
        private static bool autoSkinDo = false;
        string phase = string.Empty;

        private void LCUTimer_Tick(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("LeagueClientUx");
            if(p.Length != 0)
            {
                try
                {
                    string JsonReadyCheck = LCU.GetRequest(RestSharp.Method.GET, "/lol-matchmaking/v1/ready-check");
                    readyCheck = JsonConvert.DeserializeObject<Matchmaking.ReadyCheck>(JsonReadyCheck);
                    if (readyCheck.State == "InProgress" && AutoAccept)
                    {
                        LCU.GetRequest(RestSharp.Method.POST, "/lol-matchmaking/v1/ready-check/accept");
                        //API.LCU.GetRequest(RestSharp.Method.POST, "/lol-matchmaking/v1/ready-check/decline");
                    }

                    string gameflowPhase = LCU.GetRequest(RestSharp.Method.GET, "/lol-gameflow/v1/gameflow-phase");
                    if (phase != gameflowPhase)
                    {
                        phase = gameflowPhase;
                        Console.WriteLine(gameflowPhase);

                        if (phase.Contains("ChampSelect") && AutoSkinBoost && !autoSkinDo)
                        {
                            Sleep(1000);
                            autoSkinDo = true;
                            var skinboost = LCUAPI.API.LCU.GetRequest(Method.POST, "lol-champ-select/v1/team-boost/purchase");
                            Console.WriteLine(skinboost);
                            TeamBoost myDeserializedClass = JsonConvert.DeserializeObject<TeamBoost>(skinboost);
                        }
                        else if (!phase.Contains("ChampSelect"))
                        {
                            autoSkinDo = false;
                        }
                    }
                } catch { }
            }
        }

        private void AutoUpdate_Tick(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("LeagueClientUx");
            if(p.Length != 0)
            {
                string output = LCU.GetRequest(RestSharp.Method.GET, "/lol-summoner/v1/current-summoner", RestSharp.DataFormat.Json);
                Console.WriteLine(output);
                summoner = JsonConvert.DeserializeObject<SummonerObject.Summoner>(output);
                pbAvatar.ImageLocation = "http://ddragon.leagueoflegends.com/cdn/10.24.1/img/profileicon/" + summoner.ProfileIconId + ".png";
                lblName.Text = summoner.DisplayName;
                pbLevelProgress.Value = summoner.PercentCompleteForNextLevel;
                lblLevel.Text = summoner.SummonerLevel + " (" + summoner.XpUntilNextLevel + "/" + summoner.XpSinceLastLevel + ")";

                string walletJson = LCU.GetRequest(RestSharp.Method.GET, "/lol-store/v1/wallet");
                wallet = JsonConvert.DeserializeObject<LolStore.Wallet>(walletJson);
                lblRP.Text = wallet.RP.ToString();
                lblBlueEssence.Text = wallet.BlueEssence.ToString();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public static async void Sleep(double msec)
        {
            for (var since = DateTime.Now; (DateTime.Now - since).TotalMilliseconds < msec;)
                await Task.Delay(TimeSpan.FromTicks(10));
        }

        private void cbAutoAccept_CheckedChanged(object sender, EventArgs e)
        {
            AutoAccept = cbAutoAccept.Checked;
        }

        private void cbAutoAramSkinBoost_CheckedChanged(object sender, EventArgs e)
        {
            AutoSkinBoost = cbAutoAramSkinBoost.Checked;
        }

        private void btnAramSkinBoost_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("LeagueClientUx");
            if(p.Length != 0)
            {
                var skinboost = LCUAPI.API.LCU.GetRequest(Method.POST, "lol-champ-select/v1/team-boost/purchase");
                Console.WriteLine(skinboost);
                TeamBoost myDeserializedClass = JsonConvert.DeserializeObject<TeamBoost>(skinboost);
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void ChangeProfileIcon_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("LeagueClientUx");
            if(p.Length != 0)
            {
                string profileIcon = LCU.GetRequest(RestSharp.Method.PUT, "/lol-summoner/v1/current-summoner/icon", RestSharp.DataFormat.Json, new { profileIconId = tbProfileIcon.TextStr });
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.Location);
           if(e.Location.Y < 25)
            {
                if (e.Button == MouseButtons.Left)
                {
                    plMain.Cursor = Cursors.Hand;
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                    plMain.Cursor = Cursors.Default;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
