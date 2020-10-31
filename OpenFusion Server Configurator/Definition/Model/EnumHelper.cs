using System;

namespace OpenFusion_Server_Configurator.Definition.Model
{
    public static class EnumHelper
    {
        public static int GetAccessLevelIndex(string access)
        {
            return (int)Enum.Parse(typeof(AccountLevel), access);
        }

        public static int GetEventModeIndex(string eventMode)
        {
            return (int)Enum.Parse(typeof(EventMode), eventMode);
        }
    }
}
