using OpenFusion_Server_Configurator.Definition.Model;
using OpenFusion_Server_Configurator.Definition.Model.Inheritance;
using System;
using System.Windows.Forms;

namespace OpenFusion_Server_Configurator
{
    public partial class Form1 : Form
    {
        private ServerSettings serverSettings;
        public Form1()
        {
            InitializeComponent();
            serverSettings = new ServerSettings();
            LoadEnums();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var opf = new OpenFileDialog();
            opf.Filter = "OpenFusion config|*.ini";
            opf.Title = "Load server configuration file";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                serverSettings.LoadFile(opf.FileName);
                SetFormContent();
            }
        }

        private void SetFormContent()
        {
            // Login Server
            lsIpAddressTxtBox.Text = serverSettings.GetLoginServerIp();
            lsPortTxtBox.Text = serverSettings.GetLoginServerPort().ToString();

            // Game Server
            gsIpAddressTxtBox.Text = serverSettings.GetGameServerIp();
            gsPortTxtBox.Text = serverSettings.GetGameServerPort().ToString();

            // Game Features
            customNameCheckBox.Checked = serverSettings.GetAllowCustomNames();
            mobsEnabledCheckBox.Checked = serverSettings.GetMobEnabled();
            motdTxtBox.Text = serverSettings.GetMotdMessage();

            var accessLevel = ((AccountLevel)serverSettings.GetAccountLevel()).ToString();
            var eventMode = ((EventMode)serverSettings.GetEventMode()).ToString();

            accountLevelComboBox.Text = accessLevel;
            eventModeComboBox.Text = eventMode;
            eventCrateDropChanceTxtBox.Text = serverSettings.GetEventCrateDropChance().ToString();
        }

        private void LoadEnums()
        {
            accountLevelComboBox.Items.Clear();
            eventModeComboBox.Items.Clear();

            // Account Levels
            var accountLevels = Enum.GetValues(typeof(AccountLevel));
            foreach (var accountLevel in accountLevels)
            {
                accountLevelComboBox.Items.Add(accountLevel);
            }

            // Event Modes
            var eventModes = Enum.GetValues(typeof(EventMode));
            foreach (var eventMode in eventModes)
            {
                eventModeComboBox.Items.Add(eventMode);
            }
        }

        private void SaveServerSettings()
        {
            try
            {
                // Login Server
                serverSettings.SetLoginServerIp(lsIpAddressTxtBox.Text);
                serverSettings.SetLoginServerPort(int.Parse(lsPortTxtBox.Text));

                // Game Server
                serverSettings.SetGameServerIp(gsIpAddressTxtBox.Text);
                serverSettings.SetGameServerPort(int.Parse(gsPortTxtBox.Text));

                // Game Features
                serverSettings.SetAllowCustomNames(customNameCheckBox.Checked);
                serverSettings.SetMobEnabled(mobsEnabledCheckBox.Checked);
                serverSettings.SetMotdMessage(motdTxtBox.Text);
                serverSettings.SetAccountLevel(EnumHelper.GetAccessLevelIndex(accountLevelComboBox.Text));
                serverSettings.SetEventMode(EnumHelper.GetEventModeIndex(eventModeComboBox.Text));
                serverSettings.SetEventCrateDropChance(int.Parse(eventCrateDropChanceTxtBox.Text));

                // Save settings to file.
                serverSettings.SaveFile();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Save exception error: {e.Message}", "Failed to save config file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveServerSettings();
        }
    }
}
