namespace AlgebraMathApp
{
    partial class AlgebraUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgebraUI));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.menuBar = new System.Windows.Forms.ToolStrip();
            this.menuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.smenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.smenuOptionsAppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.smenuHelpCalcHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.smenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFormulaBox = new System.Windows.Forms.ToolStripTextBox();
            this.PrimaryTabs = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.stabGen = new System.Windows.Forms.TabControl();
            this.stabGenGeometry = new System.Windows.Forms.TabPage();
            this.stabGenPhysics = new System.Windows.Forms.TabPage();
            this.tabFuncs = new System.Windows.Forms.TabPage();
            this.tabGraphing = new System.Windows.Forms.TabPage();
            this.tabMore = new System.Windows.Forms.TabPage();
            this.tpanelMainUI = new System.Windows.Forms.TableLayoutPanel();
            this.textInformationPanel = new System.Windows.Forms.Label();
            this.stabFuncs = new System.Windows.Forms.TabControl();
            this.stabFuncsLinear = new System.Windows.Forms.TabPage();
            this.stabFuncsQuadratic = new System.Windows.Forms.TabPage();
            this.textWelcome = new System.Windows.Forms.Label();
            this.textWelcomeDetails = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.PrimaryTabs.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.stabGen.SuspendLayout();
            this.tabFuncs.SuspendLayout();
            this.tpanelMainUI.SuspendLayout();
            this.stabFuncs.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            resources.ApplyResources(this.statusBar, "statusBar");
            this.statusBar.Name = "statusBar";
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.menuBar, "menuBar");
            this.menuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuOptions,
            this.menuHelp,
            this.searchFormulaBox});
            this.menuBar.Name = "menuBar";
            this.menuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // menuFile
            // 
            this.menuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuFileExit});
            this.menuFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.menuFile, "menuFile");
            this.menuFile.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.menuFile.Name = "menuFile";
            this.menuFile.DropDownClosed += new System.EventHandler(this.TopMenuClosed);
            this.menuFile.DropDownOpened += new System.EventHandler(this.TopMenuOpened);
            // 
            // smenuFileExit
            // 
            this.smenuFileExit.Name = "smenuFileExit";
            resources.ApplyResources(this.smenuFileExit, "smenuFileExit");
            // 
            // menuOptions
            // 
            this.menuOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuOptionsAppSettings});
            this.menuOptions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.menuOptions, "menuOptions");
            this.menuOptions.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.DropDownClosed += new System.EventHandler(this.TopMenuClosed);
            this.menuOptions.DropDownOpened += new System.EventHandler(this.TopMenuOpened);
            this.menuOptions.Click += new System.EventHandler(this.menuOptions_Click);
            // 
            // smenuOptionsAppSettings
            // 
            this.smenuOptionsAppSettings.Name = "smenuOptionsAppSettings";
            resources.ApplyResources(this.smenuOptionsAppSettings, "smenuOptionsAppSettings");
            // 
            // menuHelp
            // 
            this.menuHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smenuHelpCalcHelp,
            this.smenuHelpAbout});
            this.menuHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.menuHelp, "menuHelp");
            this.menuHelp.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.DropDownClosed += new System.EventHandler(this.TopMenuOpened);
            this.menuHelp.DropDownOpened += new System.EventHandler(this.TopMenuOpened);
            // 
            // smenuHelpCalcHelp
            // 
            this.smenuHelpCalcHelp.Name = "smenuHelpCalcHelp";
            resources.ApplyResources(this.smenuHelpCalcHelp, "smenuHelpCalcHelp");
            // 
            // smenuHelpAbout
            // 
            this.smenuHelpAbout.Name = "smenuHelpAbout";
            resources.ApplyResources(this.smenuHelpAbout, "smenuHelpAbout");
            // 
            // searchFormulaBox
            // 
            this.searchFormulaBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.searchFormulaBox, "searchFormulaBox");
            this.searchFormulaBox.Margin = new System.Windows.Forms.Padding(1, 10, 10, 10);
            this.searchFormulaBox.Name = "searchFormulaBox";
            // 
            // PrimaryTabs
            // 
            resources.ApplyResources(this.PrimaryTabs, "PrimaryTabs");
            this.PrimaryTabs.Controls.Add(this.tabHome);
            this.PrimaryTabs.Controls.Add(this.tabGeneral);
            this.PrimaryTabs.Controls.Add(this.tabFuncs);
            this.PrimaryTabs.Controls.Add(this.tabGraphing);
            this.PrimaryTabs.Controls.Add(this.tabMore);
            this.PrimaryTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.PrimaryTabs.HotTrack = true;
            this.PrimaryTabs.Name = "PrimaryTabs";
            this.tpanelMainUI.SetRowSpan(this.PrimaryTabs, 2);
            this.PrimaryTabs.SelectedIndex = 0;
            this.PrimaryTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.Controls.Add(this.textWelcomeDetails);
            this.tabHome.Controls.Add(this.textWelcome);
            resources.ApplyResources(this.tabHome, "tabHome");
            this.tabHome.Name = "tabHome";
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.White;
            this.tabGeneral.Controls.Add(this.stabGen);
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.Name = "tabGeneral";
            // 
            // stabGen
            // 
            this.stabGen.Controls.Add(this.stabGenGeometry);
            this.stabGen.Controls.Add(this.stabGenPhysics);
            resources.ApplyResources(this.stabGen, "stabGen");
            this.stabGen.HotTrack = true;
            this.stabGen.Name = "stabGen";
            this.stabGen.SelectedIndex = 0;
            // 
            // stabGenGeometry
            // 
            resources.ApplyResources(this.stabGenGeometry, "stabGenGeometry");
            this.stabGenGeometry.Name = "stabGenGeometry";
            this.stabGenGeometry.UseVisualStyleBackColor = true;
            // 
            // stabGenPhysics
            // 
            resources.ApplyResources(this.stabGenPhysics, "stabGenPhysics");
            this.stabGenPhysics.Name = "stabGenPhysics";
            this.stabGenPhysics.UseVisualStyleBackColor = true;
            // 
            // tabFuncs
            // 
            this.tabFuncs.BackColor = System.Drawing.Color.White;
            this.tabFuncs.Controls.Add(this.stabFuncs);
            resources.ApplyResources(this.tabFuncs, "tabFuncs");
            this.tabFuncs.Name = "tabFuncs";
            // 
            // tabGraphing
            // 
            this.tabGraphing.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabGraphing, "tabGraphing");
            this.tabGraphing.Name = "tabGraphing";
            // 
            // tabMore
            // 
            this.tabMore.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tabMore, "tabMore");
            this.tabMore.Name = "tabMore";
            // 
            // tpanelMainUI
            // 
            resources.ApplyResources(this.tpanelMainUI, "tpanelMainUI");
            this.tpanelMainUI.Controls.Add(this.PrimaryTabs, 0, 0);
            this.tpanelMainUI.Controls.Add(this.textInformationPanel, 1, 0);
            this.tpanelMainUI.Name = "tpanelMainUI";
            this.tpanelMainUI.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textInformationPanel
            // 
            resources.ApplyResources(this.textInformationPanel, "textInformationPanel");
            this.textInformationPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textInformationPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textInformationPanel.Name = "textInformationPanel";
            this.textInformationPanel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // stabFuncs
            // 
            this.stabFuncs.Controls.Add(this.stabFuncsLinear);
            this.stabFuncs.Controls.Add(this.stabFuncsQuadratic);
            resources.ApplyResources(this.stabFuncs, "stabFuncs");
            this.stabFuncs.HotTrack = true;
            this.stabFuncs.Name = "stabFuncs";
            this.stabFuncs.SelectedIndex = 0;
            // 
            // stabFuncsLinear
            // 
            resources.ApplyResources(this.stabFuncsLinear, "stabFuncsLinear");
            this.stabFuncsLinear.Name = "stabFuncsLinear";
            this.stabFuncsLinear.UseVisualStyleBackColor = true;
            // 
            // stabFuncsQuadratic
            // 
            resources.ApplyResources(this.stabFuncsQuadratic, "stabFuncsQuadratic");
            this.stabFuncsQuadratic.Name = "stabFuncsQuadratic";
            this.stabFuncsQuadratic.UseVisualStyleBackColor = true;
            // 
            // textWelcome
            // 
            resources.ApplyResources(this.textWelcome, "textWelcome");
            this.textWelcome.Name = "textWelcome";
            // 
            // textWelcomeDetails
            // 
            resources.ApplyResources(this.textWelcomeDetails, "textWelcomeDetails");
            this.textWelcomeDetails.Name = "textWelcomeDetails";
            // 
            // AlgebraUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tpanelMainUI);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.statusBar);
            this.Name = "AlgebraUI";
            this.ShowIcon = false;
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.PrimaryTabs.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.stabGen.ResumeLayout(false);
            this.tabFuncs.ResumeLayout(false);
            this.tpanelMainUI.ResumeLayout(false);
            this.tpanelMainUI.PerformLayout();
            this.stabFuncs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStrip menuBar;
        private System.Windows.Forms.ToolStripDropDownButton menuFile;
        private System.Windows.Forms.ToolStripMenuItem smenuFileExit;
        private System.Windows.Forms.ToolStripDropDownButton menuOptions;
        private System.Windows.Forms.ToolStripMenuItem smenuOptionsAppSettings;
        private System.Windows.Forms.ToolStripDropDownButton menuHelp;
        private System.Windows.Forms.ToolStripMenuItem smenuHelpCalcHelp;
        private System.Windows.Forms.ToolStripMenuItem smenuHelpAbout;
        private System.Windows.Forms.ToolStripTextBox searchFormulaBox;
        private System.Windows.Forms.TabControl PrimaryTabs;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabFuncs;
        private System.Windows.Forms.TabPage tabGraphing;
        private System.Windows.Forms.TabPage tabMore;
        private System.Windows.Forms.TableLayoutPanel tpanelMainUI;
        private System.Windows.Forms.Label textInformationPanel;
        private System.Windows.Forms.TabControl stabGen;
        private System.Windows.Forms.TabPage stabGenGeometry;
        private System.Windows.Forms.TabPage stabGenPhysics;
        private System.Windows.Forms.TabControl stabFuncs;
        private System.Windows.Forms.TabPage stabFuncsLinear;
        private System.Windows.Forms.TabPage stabFuncsQuadratic;
        private System.Windows.Forms.Label textWelcomeDetails;
        private System.Windows.Forms.Label textWelcome;
    }
}

