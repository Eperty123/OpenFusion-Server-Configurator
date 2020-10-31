namespace OpenFusion_Server_Configurator.Definition.Model.Inheritance
{
    public class ServerSettings : Settings
    {
        #region Login Server
        private int loginServerPort = 8001;
        private string loginServerIp = "127.0.0.1";
        #endregion

        #region Shard Server (Game Server)
        private int gameServerPort = 8002;
        private string gameServerIp = "127.0.0.1";
        #endregion

        #region Game Features
        private bool allowCustomNames;
        private bool mobEnabled;
        private string motdMessage = "Welcome to OpenFusion!";
        private int accountLevel = 1;
        private int eventMode = 0;
        private int eventCrateDropChance = 10;
        #endregion

        #region Constructors
        public ServerSettings()
        {

        }

        public ServerSettings(string file)
        {
            LoadFile(file);
        }
        #endregion

        #region Methods

        protected override void initialize()
        {
            base.initialize();
            iniParser.SetCommentString("#");
            iniParser.SetAssignmentString("");
        }


        public override void ReadSettingsFile()
        {
            // Login Server
            loginServerPort = GetValue<int>("login", "port");
            allowCustomNames = GetValue<bool>("login", "acceptallcustomnames");

            // Game Server
            gameServerIp = GetValue<string>("shard", "ip");
            gameServerPort = GetValue<int>("shard", "port");

            // Game Features
            mobEnabled = GetValue<bool>("shard", "simulatemobs");
            motdMessage = GetValue<string>("shard", "motd");
            accountLevel = GetValue<int>("shard", "accountlevel");
            eventMode = GetValue<int>("shard", "eventmode");
            eventCrateDropChance = GetValue<int>("shard", "eventcratechance");
        }

        public override void SaveSettingsFile()
        {
            // Login Server
            SetValue("login", "port", loginServerPort);
            SetValue("login", "acceptallcustomnames", allowCustomNames);

            // Game Server
            SetValue("shard", "ip", gameServerIp);
            SetValue("shard", "port", gameServerPort);

            // Game Features
            SetValue("shard", "simulatemobs", mobEnabled);
            SetValue("shard", "motd", motdMessage);
            SetValue("shard", "accountlevel", accountLevel);
            SetValue("shard", "eventmode", eventMode);
            SetValue("shard", "eventcratechance", eventCrateDropChance);
        }
        #endregion

        #region Accessors
        public string GetLoginServerIp()
        {
            return loginServerIp;
        }

        public int GetLoginServerPort()
        {
            return loginServerPort;
        }

        public string GetGameServerIp()
        {
            return gameServerIp;
        }

        public int GetGameServerPort()
        {
            return gameServerPort;
        }

        public bool GetAllowCustomNames()
        {
            return allowCustomNames;
        }

        public bool GetMobEnabled()
        {
            return mobEnabled;
        }

        public string GetMotdMessage()
        {
            return motdMessage;
        }

        public int GetAccountLevel()
        {
            return accountLevel;
        }

        public int GetEventMode()
        {
            return eventMode;
        }

        public int GetEventCrateDropChance()
        {
            return eventCrateDropChance;
        }

        public void SetLoginServerIp(string ip)
        {
            loginServerIp = ip;
        }

        public void SetLoginServerPort(int port)
        {
            loginServerPort = port;
        }

        public void SetAllowCustomNames(bool allowed)
        {
            allowCustomNames = allowed;
        }

        public void SetGameServerIp(string ip)
        {
            gameServerIp = ip;
        }

        public void SetGameServerPort(int port)
        {
            gameServerPort = port;
        }

        public void SetMobEnabled(bool enabled)
        {
            mobEnabled = enabled;
        }

        public void SetMotdMessage(string motd)
        {
            motdMessage = motd;
        }

        public void SetAccountLevel(int accessLevel)
        {
            accountLevel = accessLevel;
        }

        public void SetEventMode(int eventMode)
        {
            this.eventMode = eventMode;
        }

        public void SetEventCrateDropChance(int chance)
        {
            eventCrateDropChance = chance;
        }
        #endregion
    }
}
