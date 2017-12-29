using System;
namespace MissionPlanner
{
    partial class MainV2
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
            Console.WriteLine("mainv2_Dispose");
            if (PluginThreadrunner != null)
                PluginThreadrunner.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV2));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.CTX_mainmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFlightData = new System.Windows.Forms.ToolStripButton();
            this.MenuFlightPlanner = new System.Windows.Forms.ToolStripButton();
            this.MenuEngineering = new System.Windows.Forms.ToolStripButton();
            this.MenuInitConfig = new System.Windows.Forms.ToolStripButton();
            this.MenuConfigTune = new System.Windows.Forms.ToolStripButton();
            this.MenuSimulation = new System.Windows.Forms.ToolStripButton();
            this.MenuTerminal = new System.Windows.Forms.ToolStripButton();
            this.MenuHelp = new System.Windows.Forms.ToolStripButton();
            this.MenuDonate = new System.Windows.Forms.ToolStripButton();
            this.MenuConnect = new System.Windows.Forms.ToolStripButton();
            this.menu_tablogbrowse = new System.Windows.Forms.ToolStripButton();
            this.toolStripConnectionControl = new MissionPlanner.Controls.ToolStripConnectionControl();
            this.MenuArduPilot = new System.Windows.Forms.ToolStripButton();
            this.menu = new MissionPlanner.Controls.MyButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.other_Stabilize = new System.Windows.Forms.ToolStripButton();
            this.other_Acro = new System.Windows.Forms.ToolStripButton();
            this.other_AltHold = new System.Windows.Forms.ToolStripButton();
            this.other_Guided = new System.Windows.Forms.ToolStripButton();
            this.other_Circle = new System.Windows.Forms.ToolStripButton();
            this.other_Land = new System.Windows.Forms.ToolStripButton();
            this.other_Drift = new System.Windows.Forms.ToolStripButton();
            this.other_Sport = new System.Windows.Forms.ToolStripButton();
            this.other_Flip = new System.Windows.Forms.ToolStripButton();
            this.other_AutoTune = new System.Windows.Forms.ToolStripButton();
            this.other_PosHold = new System.Windows.Forms.ToolStripButton();
            this.other_Brake = new System.Windows.Forms.ToolStripButton();
            this.other_Throw = new System.Windows.Forms.ToolStripButton();
            this.other_Avoid_ADSB = new System.Windows.Forms.ToolStripButton();
            this.other_Guided_NoGPS = new System.Windows.Forms.ToolStripButton();
            this.other_Smart_RTL = new System.Windows.Forms.ToolStripButton();
            this.BUT_RETURN_TO_LAUNCH = new System.Windows.Forms.ToolStripButton();
            this.BUT_PREFLIGHT_CALIBRATION = new System.Windows.Forms.ToolStripButton();
            this.BUT_MISSION_START = new System.Windows.Forms.ToolStripButton();
            this.BUT_PREFLIGHT_REBOOT_SHUTDOWN = new System.Windows.Forms.ToolStripButton();
            this.BUT_Trigger_Camera_NOW = new System.Windows.Forms.ToolStripButton();
            this.LB_BUT_DFMavlink = new System.Windows.Forms.ToolStripButton();
            this.LB_BUT_dflogtokml = new System.Windows.Forms.ToolStripButton();
            this.LB_BUT_logbrowse = new System.Windows.Forms.ToolStripButton();
            this.LB_BUT_bintolog = new System.Windows.Forms.ToolStripButton();
            this.LB_BUT_loganalysis = new System.Windows.Forms.ToolStripButton();
            this.LB_BUT_matlab = new System.Windows.Forms.ToolStripButton();
            this.menu_CMB_setwp = new System.Windows.Forms.ToolStripComboBox();
            this.menu_BUT_setwp = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_ARM = new System.Windows.Forms.ToolStripButton();
            this.Menu_quickauto = new System.Windows.Forms.ToolStripButton();
            this.Menu_quickmanual = new System.Windows.Forms.ToolStripButton();
            this.menu_quickrtl = new System.Windows.Forms.ToolStripButton();
            this.menu_othermode = new System.Windows.Forms.ToolStripButton();
            this.BUT_LOITER_UNLIM = new System.Windows.Forms.ToolStripButton();
            this.menu_Set_waypoint = new System.Windows.Forms.ToolStripButton();
            this.menu_BUTactiondo = new System.Windows.Forms.ToolStripButton();
            this.menu_BUT_clear_track = new System.Windows.Forms.ToolStripButton();
            this.menu_BUT_resumemis = new System.Windows.Forms.ToolStripButton();
            this.menu_BUT_abortland = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.nishuosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.CTX_mainmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackgroundImage = global::MissionPlanner.Properties.Resources.bgdark;
            this.MainMenu.ContextMenuStrip = this.CTX_mainmenu;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFlightData,
            this.MenuFlightPlanner,
            this.MenuEngineering,
            this.MenuInitConfig,
            this.MenuConfigTune,
            this.MenuSimulation,
            this.MenuTerminal,
            this.MenuHelp,
            this.MenuDonate,
            this.MenuConnect,
            this.menu_tablogbrowse,
            this.toolStripConnectionControl,
            this.MenuArduPilot});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShowItemToolTips = true;
            this.MainMenu.Stretch = false;
            this.MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainMenu_ItemClicked);
            this.MainMenu.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // CTX_mainmenu
            // 
            this.CTX_mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoHideToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.readonlyToolStripMenuItem,
            this.connectionOptionsToolStripMenuItem,
            this.connectionListToolStripMenuItem});
            this.CTX_mainmenu.Name = "CTX_mainmenu";
            resources.ApplyResources(this.CTX_mainmenu, "CTX_mainmenu");
            // 
            // autoHideToolStripMenuItem
            // 
            this.autoHideToolStripMenuItem.CheckOnClick = true;
            this.autoHideToolStripMenuItem.Name = "autoHideToolStripMenuItem";
            resources.ApplyResources(this.autoHideToolStripMenuItem, "autoHideToolStripMenuItem");
            this.autoHideToolStripMenuItem.Click += new System.EventHandler(this.autoHideToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.CheckOnClick = true;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // readonlyToolStripMenuItem
            // 
            this.readonlyToolStripMenuItem.CheckOnClick = true;
            this.readonlyToolStripMenuItem.Name = "readonlyToolStripMenuItem";
            resources.ApplyResources(this.readonlyToolStripMenuItem, "readonlyToolStripMenuItem");
            this.readonlyToolStripMenuItem.Click += new System.EventHandler(this.readonlyToolStripMenuItem_Click);
            // 
            // connectionOptionsToolStripMenuItem
            // 
            this.connectionOptionsToolStripMenuItem.Name = "connectionOptionsToolStripMenuItem";
            resources.ApplyResources(this.connectionOptionsToolStripMenuItem, "connectionOptionsToolStripMenuItem");
            this.connectionOptionsToolStripMenuItem.Click += new System.EventHandler(this.connectionOptionsToolStripMenuItem_Click);
            // 
            // connectionListToolStripMenuItem
            // 
            this.connectionListToolStripMenuItem.Name = "connectionListToolStripMenuItem";
            resources.ApplyResources(this.connectionListToolStripMenuItem, "connectionListToolStripMenuItem");
            this.connectionListToolStripMenuItem.Click += new System.EventHandler(this.connectionListToolStripMenuItem_Click);
            // 
            // MenuFlightData
            // 
            resources.ApplyResources(this.MenuFlightData, "MenuFlightData");
            this.MenuFlightData.ForeColor = System.Drawing.Color.White;
            this.MenuFlightData.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightData.Name = "MenuFlightData";
            this.MenuFlightData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuFlightData.Click += new System.EventHandler(this.MenuFlightData_Click);
            // 
            // MenuFlightPlanner
            // 
            resources.ApplyResources(this.MenuFlightPlanner, "MenuFlightPlanner");
            this.MenuFlightPlanner.ForeColor = System.Drawing.Color.White;
            this.MenuFlightPlanner.Margin = new System.Windows.Forms.Padding(0);
            this.MenuFlightPlanner.Name = "MenuFlightPlanner";
            this.MenuFlightPlanner.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuFlightPlanner.Click += new System.EventHandler(this.MenuFlightPlanner_Click);
            // 
            // MenuEngineering
            // 
            resources.ApplyResources(this.MenuEngineering, "MenuEngineering");
            this.MenuEngineering.ForeColor = System.Drawing.Color.White;
            this.MenuEngineering.Image = global::MissionPlanner.Properties.Resources.donate;
            this.MenuEngineering.Margin = new System.Windows.Forms.Padding(0);
            this.MenuEngineering.Name = "MenuEngineering";
            this.MenuEngineering.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuEngineering.Click += new System.EventHandler(this.MenuEngineering_Click);
            // 
            // MenuInitConfig
            // 
            resources.ApplyResources(this.MenuInitConfig, "MenuInitConfig");
            this.MenuInitConfig.ForeColor = System.Drawing.Color.White;
            this.MenuInitConfig.Margin = new System.Windows.Forms.Padding(0);
            this.MenuInitConfig.Name = "MenuInitConfig";
            this.MenuInitConfig.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuInitConfig.Click += new System.EventHandler(this.MenuSetup_Click);
            // 
            // MenuConfigTune
            // 
            resources.ApplyResources(this.MenuConfigTune, "MenuConfigTune");
            this.MenuConfigTune.ForeColor = System.Drawing.Color.White;
            this.MenuConfigTune.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConfigTune.Name = "MenuConfigTune";
            this.MenuConfigTune.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuConfigTune.Click += new System.EventHandler(this.MenuTuning_Click);
            // 
            // MenuSimulation
            // 
            resources.ApplyResources(this.MenuSimulation, "MenuSimulation");
            this.MenuSimulation.ForeColor = System.Drawing.Color.White;
            this.MenuSimulation.Margin = new System.Windows.Forms.Padding(0);
            this.MenuSimulation.Name = "MenuSimulation";
            this.MenuSimulation.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuSimulation.Click += new System.EventHandler(this.MenuSimulation_Click);
            // 
            // MenuTerminal
            // 
            resources.ApplyResources(this.MenuTerminal, "MenuTerminal");
            this.MenuTerminal.ForeColor = System.Drawing.Color.White;
            this.MenuTerminal.Margin = new System.Windows.Forms.Padding(0);
            this.MenuTerminal.Name = "MenuTerminal";
            this.MenuTerminal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuTerminal.Click += new System.EventHandler(this.MenuTerminal_Click);
            // 
            // MenuHelp
            // 
            resources.ApplyResources(this.MenuHelp, "MenuHelp");
            this.MenuHelp.ForeColor = System.Drawing.Color.White;
            this.MenuHelp.Margin = new System.Windows.Forms.Padding(0);
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuHelp.Click += new System.EventHandler(this.MenuHelp_Click);
            // 
            // MenuDonate
            // 
            resources.ApplyResources(this.MenuDonate, "MenuDonate");
            this.MenuDonate.ForeColor = System.Drawing.Color.White;
            this.MenuDonate.Image = global::MissionPlanner.Properties.Resources.donate;
            this.MenuDonate.Margin = new System.Windows.Forms.Padding(0);
            this.MenuDonate.Name = "MenuDonate";
            this.MenuDonate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuDonate.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MenuConnect
            // 
            this.MenuConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.MenuConnect, "MenuConnect");
            this.MenuConnect.ForeColor = System.Drawing.Color.White;
            this.MenuConnect.Margin = new System.Windows.Forms.Padding(0);
            this.MenuConnect.Name = "MenuConnect";
            this.MenuConnect.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuConnect.Click += new System.EventHandler(this.MenuConnect_Click);
            // 
            // menu_tablogbrowse
            // 
            resources.ApplyResources(this.menu_tablogbrowse, "menu_tablogbrowse");
            this.menu_tablogbrowse.ForeColor = System.Drawing.Color.White;
            this.menu_tablogbrowse.Margin = new System.Windows.Forms.Padding(0);
            this.menu_tablogbrowse.Name = "menu_tablogbrowse";
            this.menu_tablogbrowse.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_tablogbrowse.Click += new System.EventHandler(this.menu_tablogbrowse_Click);
            // 
            // toolStripConnectionControl
            // 
            this.toolStripConnectionControl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripConnectionControl.BackgroundImage = global::MissionPlanner.Properties.Resources.bgdark;
            this.toolStripConnectionControl.ForeColor = System.Drawing.Color.Black;
            this.toolStripConnectionControl.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripConnectionControl.Name = "toolStripConnectionControl";
            resources.ApplyResources(this.toolStripConnectionControl, "toolStripConnectionControl");
            this.toolStripConnectionControl.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // MenuArduPilot
            // 
            this.MenuArduPilot.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuArduPilot.BackColor = System.Drawing.Color.Transparent;
            this.MenuArduPilot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.MenuArduPilot, "MenuArduPilot");
            this.MenuArduPilot.ForeColor = System.Drawing.Color.White;
            this.MenuArduPilot.Image = global::MissionPlanner.Properties.Resources._0d92fed790a3a70170e61a86db103f399a595c70;
            this.MenuArduPilot.Margin = new System.Windows.Forms.Padding(0);
            this.MenuArduPilot.Name = "MenuArduPilot";
            this.MenuArduPilot.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.MainMenu);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.MouseLeave += new System.EventHandler(this.MainMenu_MouseLeave);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackgroundImage = global::MissionPlanner.Properties.Resources.bgdark;
            this.menuStrip2.ContextMenuStrip = this.CTX_mainmenu;
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.other_Stabilize,
            this.other_Acro,
            this.other_AltHold,
            this.other_Guided,
            this.other_Circle,
            this.other_Land,
            this.other_Drift,
            this.other_Sport,
            this.other_Flip,
            this.other_AutoTune,
            this.other_PosHold,
            this.other_Brake,
            this.other_Throw,
            this.other_Avoid_ADSB,
            this.other_Guided_NoGPS,
            this.other_Smart_RTL,
            this.BUT_RETURN_TO_LAUNCH,
            this.BUT_PREFLIGHT_CALIBRATION,
            this.BUT_MISSION_START,
            this.BUT_PREFLIGHT_REBOOT_SHUTDOWN,
            this.BUT_Trigger_Camera_NOW,
            this.LB_BUT_DFMavlink,
            this.LB_BUT_dflogtokml,
            this.LB_BUT_logbrowse,
            this.LB_BUT_bintolog,
            this.LB_BUT_loganalysis,
            this.LB_BUT_matlab,
            this.menu_CMB_setwp,
            this.menu_BUT_setwp});
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Stretch = false;
            // 
            // other_Stabilize
            // 
            resources.ApplyResources(this.other_Stabilize, "other_Stabilize");
            this.other_Stabilize.ForeColor = System.Drawing.Color.White;
            this.other_Stabilize.Margin = new System.Windows.Forms.Padding(0);
            this.other_Stabilize.Name = "other_Stabilize";
            this.other_Stabilize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Acro
            // 
            resources.ApplyResources(this.other_Acro, "other_Acro");
            this.other_Acro.ForeColor = System.Drawing.Color.White;
            this.other_Acro.Margin = new System.Windows.Forms.Padding(0);
            this.other_Acro.Name = "other_Acro";
            this.other_Acro.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_AltHold
            // 
            resources.ApplyResources(this.other_AltHold, "other_AltHold");
            this.other_AltHold.ForeColor = System.Drawing.Color.White;
            this.other_AltHold.Margin = new System.Windows.Forms.Padding(0);
            this.other_AltHold.Name = "other_AltHold";
            this.other_AltHold.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Guided
            // 
            resources.ApplyResources(this.other_Guided, "other_Guided");
            this.other_Guided.ForeColor = System.Drawing.Color.White;
            this.other_Guided.Margin = new System.Windows.Forms.Padding(0);
            this.other_Guided.Name = "other_Guided";
            this.other_Guided.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Circle
            // 
            resources.ApplyResources(this.other_Circle, "other_Circle");
            this.other_Circle.ForeColor = System.Drawing.Color.White;
            this.other_Circle.Margin = new System.Windows.Forms.Padding(0);
            this.other_Circle.Name = "other_Circle";
            this.other_Circle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Land
            // 
            resources.ApplyResources(this.other_Land, "other_Land");
            this.other_Land.ForeColor = System.Drawing.Color.White;
            this.other_Land.Margin = new System.Windows.Forms.Padding(0);
            this.other_Land.Name = "other_Land";
            this.other_Land.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Drift
            // 
            resources.ApplyResources(this.other_Drift, "other_Drift");
            this.other_Drift.ForeColor = System.Drawing.Color.White;
            this.other_Drift.Margin = new System.Windows.Forms.Padding(0);
            this.other_Drift.Name = "other_Drift";
            this.other_Drift.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Sport
            // 
            resources.ApplyResources(this.other_Sport, "other_Sport");
            this.other_Sport.ForeColor = System.Drawing.Color.White;
            this.other_Sport.Margin = new System.Windows.Forms.Padding(0);
            this.other_Sport.Name = "other_Sport";
            this.other_Sport.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Flip
            // 
            resources.ApplyResources(this.other_Flip, "other_Flip");
            this.other_Flip.ForeColor = System.Drawing.Color.White;
            this.other_Flip.Margin = new System.Windows.Forms.Padding(0);
            this.other_Flip.Name = "other_Flip";
            this.other_Flip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_AutoTune
            // 
            resources.ApplyResources(this.other_AutoTune, "other_AutoTune");
            this.other_AutoTune.ForeColor = System.Drawing.Color.White;
            this.other_AutoTune.Margin = new System.Windows.Forms.Padding(0);
            this.other_AutoTune.Name = "other_AutoTune";
            this.other_AutoTune.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_PosHold
            // 
            resources.ApplyResources(this.other_PosHold, "other_PosHold");
            this.other_PosHold.ForeColor = System.Drawing.Color.White;
            this.other_PosHold.Margin = new System.Windows.Forms.Padding(0);
            this.other_PosHold.Name = "other_PosHold";
            this.other_PosHold.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Brake
            // 
            resources.ApplyResources(this.other_Brake, "other_Brake");
            this.other_Brake.ForeColor = System.Drawing.Color.White;
            this.other_Brake.Margin = new System.Windows.Forms.Padding(0);
            this.other_Brake.Name = "other_Brake";
            this.other_Brake.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Throw
            // 
            resources.ApplyResources(this.other_Throw, "other_Throw");
            this.other_Throw.ForeColor = System.Drawing.Color.White;
            this.other_Throw.Margin = new System.Windows.Forms.Padding(0);
            this.other_Throw.Name = "other_Throw";
            this.other_Throw.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Avoid_ADSB
            // 
            resources.ApplyResources(this.other_Avoid_ADSB, "other_Avoid_ADSB");
            this.other_Avoid_ADSB.ForeColor = System.Drawing.Color.White;
            this.other_Avoid_ADSB.Margin = new System.Windows.Forms.Padding(0);
            this.other_Avoid_ADSB.Name = "other_Avoid_ADSB";
            this.other_Avoid_ADSB.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Guided_NoGPS
            // 
            resources.ApplyResources(this.other_Guided_NoGPS, "other_Guided_NoGPS");
            this.other_Guided_NoGPS.ForeColor = System.Drawing.Color.White;
            this.other_Guided_NoGPS.Margin = new System.Windows.Forms.Padding(0);
            this.other_Guided_NoGPS.Name = "other_Guided_NoGPS";
            this.other_Guided_NoGPS.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // other_Smart_RTL
            // 
            resources.ApplyResources(this.other_Smart_RTL, "other_Smart_RTL");
            this.other_Smart_RTL.ForeColor = System.Drawing.Color.White;
            this.other_Smart_RTL.Margin = new System.Windows.Forms.Padding(0);
            this.other_Smart_RTL.Name = "other_Smart_RTL";
            this.other_Smart_RTL.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // BUT_RETURN_TO_LAUNCH
            // 
            resources.ApplyResources(this.BUT_RETURN_TO_LAUNCH, "BUT_RETURN_TO_LAUNCH");
            this.BUT_RETURN_TO_LAUNCH.ForeColor = System.Drawing.Color.White;
            this.BUT_RETURN_TO_LAUNCH.Margin = new System.Windows.Forms.Padding(0);
            this.BUT_RETURN_TO_LAUNCH.Name = "BUT_RETURN_TO_LAUNCH";
            this.BUT_RETURN_TO_LAUNCH.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // BUT_PREFLIGHT_CALIBRATION
            // 
            resources.ApplyResources(this.BUT_PREFLIGHT_CALIBRATION, "BUT_PREFLIGHT_CALIBRATION");
            this.BUT_PREFLIGHT_CALIBRATION.ForeColor = System.Drawing.Color.White;
            this.BUT_PREFLIGHT_CALIBRATION.Margin = new System.Windows.Forms.Padding(0);
            this.BUT_PREFLIGHT_CALIBRATION.Name = "BUT_PREFLIGHT_CALIBRATION";
            this.BUT_PREFLIGHT_CALIBRATION.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // BUT_MISSION_START
            // 
            resources.ApplyResources(this.BUT_MISSION_START, "BUT_MISSION_START");
            this.BUT_MISSION_START.ForeColor = System.Drawing.Color.White;
            this.BUT_MISSION_START.Margin = new System.Windows.Forms.Padding(0);
            this.BUT_MISSION_START.Name = "BUT_MISSION_START";
            this.BUT_MISSION_START.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // BUT_PREFLIGHT_REBOOT_SHUTDOWN
            // 
            resources.ApplyResources(this.BUT_PREFLIGHT_REBOOT_SHUTDOWN, "BUT_PREFLIGHT_REBOOT_SHUTDOWN");
            this.BUT_PREFLIGHT_REBOOT_SHUTDOWN.ForeColor = System.Drawing.Color.White;
            this.BUT_PREFLIGHT_REBOOT_SHUTDOWN.Margin = new System.Windows.Forms.Padding(0);
            this.BUT_PREFLIGHT_REBOOT_SHUTDOWN.Name = "BUT_PREFLIGHT_REBOOT_SHUTDOWN";
            this.BUT_PREFLIGHT_REBOOT_SHUTDOWN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // BUT_Trigger_Camera_NOW
            // 
            resources.ApplyResources(this.BUT_Trigger_Camera_NOW, "BUT_Trigger_Camera_NOW");
            this.BUT_Trigger_Camera_NOW.ForeColor = System.Drawing.Color.White;
            this.BUT_Trigger_Camera_NOW.Margin = new System.Windows.Forms.Padding(0);
            this.BUT_Trigger_Camera_NOW.Name = "BUT_Trigger_Camera_NOW";
            this.BUT_Trigger_Camera_NOW.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // LB_BUT_DFMavlink
            // 
            resources.ApplyResources(this.LB_BUT_DFMavlink, "LB_BUT_DFMavlink");
            this.LB_BUT_DFMavlink.ForeColor = System.Drawing.Color.White;
            this.LB_BUT_DFMavlink.Margin = new System.Windows.Forms.Padding(0);
            this.LB_BUT_DFMavlink.Name = "LB_BUT_DFMavlink";
            this.LB_BUT_DFMavlink.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_BUT_DFMavlink.Click += new System.EventHandler(this.LB_BUT_DFMavlink_Click);
            // 
            // LB_BUT_dflogtokml
            // 
            resources.ApplyResources(this.LB_BUT_dflogtokml, "LB_BUT_dflogtokml");
            this.LB_BUT_dflogtokml.ForeColor = System.Drawing.Color.White;
            this.LB_BUT_dflogtokml.Margin = new System.Windows.Forms.Padding(0);
            this.LB_BUT_dflogtokml.Name = "LB_BUT_dflogtokml";
            this.LB_BUT_dflogtokml.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_BUT_dflogtokml.Click += new System.EventHandler(this.LB_BUT_dflogtokml_Click);
            // 
            // LB_BUT_logbrowse
            // 
            resources.ApplyResources(this.LB_BUT_logbrowse, "LB_BUT_logbrowse");
            this.LB_BUT_logbrowse.ForeColor = System.Drawing.Color.White;
            this.LB_BUT_logbrowse.Margin = new System.Windows.Forms.Padding(0);
            this.LB_BUT_logbrowse.Name = "LB_BUT_logbrowse";
            this.LB_BUT_logbrowse.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_BUT_logbrowse.Click += new System.EventHandler(this.LB_BUT_logbrowse_Click);
            // 
            // LB_BUT_bintolog
            // 
            resources.ApplyResources(this.LB_BUT_bintolog, "LB_BUT_bintolog");
            this.LB_BUT_bintolog.ForeColor = System.Drawing.Color.White;
            this.LB_BUT_bintolog.Margin = new System.Windows.Forms.Padding(0);
            this.LB_BUT_bintolog.Name = "LB_BUT_bintolog";
            this.LB_BUT_bintolog.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_BUT_bintolog.Click += new System.EventHandler(this.LB_BUT_bintolog_Click);
            // 
            // LB_BUT_loganalysis
            // 
            resources.ApplyResources(this.LB_BUT_loganalysis, "LB_BUT_loganalysis");
            this.LB_BUT_loganalysis.ForeColor = System.Drawing.Color.White;
            this.LB_BUT_loganalysis.Margin = new System.Windows.Forms.Padding(0);
            this.LB_BUT_loganalysis.Name = "LB_BUT_loganalysis";
            this.LB_BUT_loganalysis.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_BUT_loganalysis.Click += new System.EventHandler(this.LB_BUT_loganalysis_Click);
            // 
            // LB_BUT_matlab
            // 
            resources.ApplyResources(this.LB_BUT_matlab, "LB_BUT_matlab");
            this.LB_BUT_matlab.ForeColor = System.Drawing.Color.White;
            this.LB_BUT_matlab.Margin = new System.Windows.Forms.Padding(0);
            this.LB_BUT_matlab.Name = "LB_BUT_matlab";
            this.LB_BUT_matlab.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.LB_BUT_matlab.Click += new System.EventHandler(this.LB_BUT_matlab_Click);
            // 
            // menu_CMB_setwp
            // 
            this.menu_CMB_setwp.Name = "menu_CMB_setwp";
            resources.ApplyResources(this.menu_CMB_setwp, "menu_CMB_setwp");
            this.menu_CMB_setwp.Click += new System.EventHandler(this.menu_CMB_setwp_Click);
            // 
            // menu_BUT_setwp
            // 
            resources.ApplyResources(this.menu_BUT_setwp, "menu_BUT_setwp");
            this.menu_BUT_setwp.ForeColor = System.Drawing.Color.White;
            this.menu_BUT_setwp.Margin = new System.Windows.Forms.Padding(0);
            this.menu_BUT_setwp.Name = "menu_BUT_setwp";
            this.menu_BUT_setwp.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_BUT_setwp.Click += new System.EventHandler(this.menu_BUT_setwp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::MissionPlanner.Properties.Resources.bgdark;
            this.menuStrip1.ContextMenuStrip = this.CTX_mainmenu;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ARM,
            this.Menu_quickauto,
            this.Menu_quickmanual,
            this.menu_quickrtl,
            this.menu_othermode,
            this.BUT_LOITER_UNLIM,
            this.menu_Set_waypoint,
            this.menu_BUTactiondo,
            this.menu_BUT_clear_track,
            this.menu_BUT_resumemis,
            this.menu_BUT_abortland});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Stretch = false;
            // 
            // menu_ARM
            // 
            resources.ApplyResources(this.menu_ARM, "menu_ARM");
            this.menu_ARM.ForeColor = System.Drawing.Color.White;
            this.menu_ARM.Margin = new System.Windows.Forms.Padding(0);
            this.menu_ARM.Name = "menu_ARM";
            this.menu_ARM.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_ARM.Click += new System.EventHandler(this.menu_ARM_Click);
            // 
            // Menu_quickauto
            // 
            resources.ApplyResources(this.Menu_quickauto, "Menu_quickauto");
            this.Menu_quickauto.ForeColor = System.Drawing.Color.White;
            this.Menu_quickauto.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_quickauto.Name = "Menu_quickauto";
            this.Menu_quickauto.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Menu_quickauto.Click += new System.EventHandler(this.Menu_quickauto_Click);
            // 
            // Menu_quickmanual
            // 
            resources.ApplyResources(this.Menu_quickmanual, "Menu_quickmanual");
            this.Menu_quickmanual.ForeColor = System.Drawing.Color.White;
            this.Menu_quickmanual.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_quickmanual.Name = "Menu_quickmanual";
            this.Menu_quickmanual.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Menu_quickmanual.Click += new System.EventHandler(this.Menu_quickmanual_Click);
            // 
            // menu_quickrtl
            // 
            resources.ApplyResources(this.menu_quickrtl, "menu_quickrtl");
            this.menu_quickrtl.ForeColor = System.Drawing.Color.White;
            this.menu_quickrtl.Margin = new System.Windows.Forms.Padding(0);
            this.menu_quickrtl.Name = "menu_quickrtl";
            this.menu_quickrtl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_quickrtl.Click += new System.EventHandler(this.menu_quickrtl_Click);
            // 
            // menu_othermode
            // 
            resources.ApplyResources(this.menu_othermode, "menu_othermode");
            this.menu_othermode.ForeColor = System.Drawing.Color.White;
            this.menu_othermode.Margin = new System.Windows.Forms.Padding(0);
            this.menu_othermode.Name = "menu_othermode";
            this.menu_othermode.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_othermode.Click += new System.EventHandler(this.menu_othermode_Click_1);
            // 
            // BUT_LOITER_UNLIM
            // 
            resources.ApplyResources(this.BUT_LOITER_UNLIM, "BUT_LOITER_UNLIM");
            this.BUT_LOITER_UNLIM.ForeColor = System.Drawing.Color.White;
            this.BUT_LOITER_UNLIM.Margin = new System.Windows.Forms.Padding(0);
            this.BUT_LOITER_UNLIM.Name = "BUT_LOITER_UNLIM";
            this.BUT_LOITER_UNLIM.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            // 
            // menu_Set_waypoint
            // 
            resources.ApplyResources(this.menu_Set_waypoint, "menu_Set_waypoint");
            this.menu_Set_waypoint.ForeColor = System.Drawing.Color.White;
            this.menu_Set_waypoint.Margin = new System.Windows.Forms.Padding(0);
            this.menu_Set_waypoint.Name = "menu_Set_waypoint";
            this.menu_Set_waypoint.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_Set_waypoint.Click += new System.EventHandler(this.menu_Set_waypoint_Click);
            // 
            // menu_BUTactiondo
            // 
            resources.ApplyResources(this.menu_BUTactiondo, "menu_BUTactiondo");
            this.menu_BUTactiondo.ForeColor = System.Drawing.Color.White;
            this.menu_BUTactiondo.Margin = new System.Windows.Forms.Padding(0);
            this.menu_BUTactiondo.Name = "menu_BUTactiondo";
            this.menu_BUTactiondo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_BUTactiondo.Click += new System.EventHandler(this.menu_BUTactiondo_Click);
            // 
            // menu_BUT_clear_track
            // 
            resources.ApplyResources(this.menu_BUT_clear_track, "menu_BUT_clear_track");
            this.menu_BUT_clear_track.ForeColor = System.Drawing.Color.White;
            this.menu_BUT_clear_track.Margin = new System.Windows.Forms.Padding(0);
            this.menu_BUT_clear_track.Name = "menu_BUT_clear_track";
            this.menu_BUT_clear_track.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_BUT_clear_track.Click += new System.EventHandler(this.menu_BUT_clear_track_Click);
            // 
            // menu_BUT_resumemis
            // 
            resources.ApplyResources(this.menu_BUT_resumemis, "menu_BUT_resumemis");
            this.menu_BUT_resumemis.ForeColor = System.Drawing.Color.White;
            this.menu_BUT_resumemis.Margin = new System.Windows.Forms.Padding(0);
            this.menu_BUT_resumemis.Name = "menu_BUT_resumemis";
            this.menu_BUT_resumemis.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_BUT_resumemis.Click += new System.EventHandler(this.menu_BUT_resumemis_Click);
            // 
            // menu_BUT_abortland
            // 
            resources.ApplyResources(this.menu_BUT_abortland, "menu_BUT_abortland");
            this.menu_BUT_abortland.ForeColor = System.Drawing.Color.White;
            this.menu_BUT_abortland.Margin = new System.Windows.Forms.Padding(0);
            this.menu_BUT_abortland.Name = "menu_BUT_abortland";
            this.menu_BUT_abortland.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menu_BUT_abortland.Click += new System.EventHandler(this.menu_BUT_abortland_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            resources.ApplyResources(this.toolStripTextBox1, "toolStripTextBox1");
            // 
            // nishuosToolStripMenuItem
            // 
            this.nishuosToolStripMenuItem.Name = "nishuosToolStripMenuItem";
            resources.ApplyResources(this.nishuosToolStripMenuItem, "nishuosToolStripMenuItem");
            // 
            // MainV2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainV2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainV2_KeyDown);
            this.Resize += new System.EventHandler(this.MainV2_Resize);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.CTX_mainmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ToolStripButton MenuFlightData;
        public System.Windows.Forms.ToolStripButton MenuFlightPlanner;
        public System.Windows.Forms.ToolStripButton MenuInitConfig;
        public System.Windows.Forms.ToolStripButton MenuSimulation;
        public System.Windows.Forms.ToolStripButton MenuConfigTune;
        public System.Windows.Forms.ToolStripButton MenuTerminal;
        public System.Windows.Forms.ToolStripButton MenuConnect;

        private System.Windows.Forms.ToolStripButton MenuHelp;
        private Controls.ToolStripConnectionControl toolStripConnectionControl;
        private Controls.MyButton menu;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip CTX_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem autoHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton MenuDonate;
        public System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readonlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton MenuArduPilot;
        private System.Windows.Forms.ToolStripMenuItem connectionListToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton MenuEngineering;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripButton Menu_quickauto;
        public System.Windows.Forms.ToolStripButton Menu_quickmanual;
        public System.Windows.Forms.ToolStripButton menu_quickrtl;
        public System.Windows.Forms.ToolStripButton menu_ARM;
        private System.Windows.Forms.ToolStripMenuItem nishuosToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripButton other_Stabilize;
        public System.Windows.Forms.ToolStripButton other_Acro;
        public System.Windows.Forms.ToolStripButton other_AltHold;
        public System.Windows.Forms.ToolStripButton other_Guided;
        public System.Windows.Forms.ToolStripButton other_Circle;
        public System.Windows.Forms.ToolStripButton other_Land;
        public System.Windows.Forms.ToolStripButton other_Drift;
        public System.Windows.Forms.ToolStripButton other_Sport;
        public System.Windows.Forms.ToolStripButton other_Flip;
        public System.Windows.Forms.ToolStripButton other_AutoTune;
        public System.Windows.Forms.ToolStripButton other_PosHold;
        public System.Windows.Forms.ToolStripButton other_Brake;
        public System.Windows.Forms.ToolStripButton other_Throw;
        public System.Windows.Forms.ToolStripButton other_Avoid_ADSB;
        public System.Windows.Forms.ToolStripButton other_Guided_NoGPS;
        public System.Windows.Forms.ToolStripButton other_Smart_RTL;
        public System.Windows.Forms.ToolStripButton menu_othermode;
        public System.Windows.Forms.ToolStripButton menu_BUTactiondo;
        public System.Windows.Forms.ToolStripButton BUT_Trigger_Camera_NOW;
        public System.Windows.Forms.ToolStripButton BUT_RETURN_TO_LAUNCH;
        public System.Windows.Forms.ToolStripButton BUT_PREFLIGHT_CALIBRATION;
        public System.Windows.Forms.ToolStripButton BUT_MISSION_START;
        public System.Windows.Forms.ToolStripButton BUT_PREFLIGHT_REBOOT_SHUTDOWN;
        public System.Windows.Forms.ToolStripButton menu_BUT_clear_track;
        public System.Windows.Forms.ToolStripButton menu_BUT_resumemis;
        public System.Windows.Forms.ToolStripButton menu_BUT_abortland;
        public System.Windows.Forms.ToolStripButton menu_tablogbrowse;
        public System.Windows.Forms.ToolStripButton LB_BUT_DFMavlink;
        public System.Windows.Forms.ToolStripButton LB_BUT_dflogtokml;
        public System.Windows.Forms.ToolStripButton LB_BUT_logbrowse;
        public System.Windows.Forms.ToolStripButton LB_BUT_bintolog;
        public System.Windows.Forms.ToolStripButton LB_BUT_loganalysis;
        public System.Windows.Forms.ToolStripButton LB_BUT_matlab;
        private System.Windows.Forms.ToolStripComboBox menu_CMB_setwp;
        public System.Windows.Forms.ToolStripButton menu_Set_waypoint;
        public System.Windows.Forms.ToolStripButton menu_BUT_setwp;
        public System.Windows.Forms.ToolStripButton BUT_LOITER_UNLIM;
    }
}