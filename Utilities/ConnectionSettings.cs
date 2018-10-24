using System;

namespace Utilities
{
    public partial class ConnectionSettings
    {
        public static ConnectionSettings Default { get { return OneBox; } }

        public static ConnectionSettings OneBox = new ConnectionSettings()
        {
            UriString = "",
            UserName = "",
            // Insert the correct password here for the actual test.
            Password = "",

            ActiveDirectoryResource = "",
            ActiveDirectoryTenant = "",
            ActiveDirectoryClientAppId = "",
            
            //Insert here the application secret when authenticate with AAD by the application
            ActiveDirectoryClientAppSecret = "",

            // Change TLS version of HTTP request from the client here
            // Ex: TLSVersion = "1.2"
            // Leave it empty if want to use the default version
            TLSVersion = "",


            //Demo 2
            ApimClientId = "",
            ApinClientSecreet = "",
            ApinOauthTenant = "",
            ApinSubscriptionKey = ""
    };

        public string TLSVersion { get; set; }
        public string UriString { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActiveDirectoryResource { get; set; }
        public String ActiveDirectoryTenant { get; set; }
        public String ActiveDirectoryClientAppId { get; set; }
        public string ActiveDirectoryClientAppSecret { get; set; }
        public string ApimClientId { get; set; }
        public string ApinClientSecreet { get; set; }
        public string ApinOauthTenant { get; set; }
        public string ApinSubscriptionKey { get; set; }
    }
}
