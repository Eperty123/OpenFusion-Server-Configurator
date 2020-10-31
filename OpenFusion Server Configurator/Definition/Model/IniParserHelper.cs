using IniParser;
using IniParser.Model;

namespace OpenFusion_Server_Configurator.Definition.Model
{
    public static class IniParserHelper
    {
        public static T GetValue<T>(this FileIniDataParser parser, string key, string value)
        {
            return parser.GetValue<T>(key, value);
        }

        public static void SetValue<T>(this IniData iniData, string section, string key, T value)
        {
            iniData[section][key] = value.ToString();
        }

        public static void SetCommentString(this FileIniDataParser parser, string commentString)
        {
            parser.Parser.Configuration.CommentString = commentString;
        }

        public static void SetAssignmentString(this FileIniDataParser parser, string assignmentString)
        {
            parser.Parser.Configuration.AssigmentSpacer = assignmentString;
        }
    }
}
