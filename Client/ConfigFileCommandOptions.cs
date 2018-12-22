using CommandLine;

namespace Copier.Client
{
    [Verb("watchWithConfig",HelpText = "If you want to pass a config file that has options, then use this verb to initiate watching and copying operation.")]
    public class ConfigFileCommandOptions
    {
        [Option('c', "configFilePath", Default = "config.txt", HelpText = "The path of the configuration file which can be used instead of passing all the options manually thru the command line.")]
        public string ConfigFilePath { get; set; }
        
    }
}