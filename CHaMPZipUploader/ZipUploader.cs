using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHaMPZipUploader
{
    public class ZipUploader
    {
        public string APIURL { get; internal set; }
        public string ClientIdentifier { get; internal set; }
        public string ClientSecret { get; internal set; }
        public string UserName { get; internal set; }
        public string Password { get; internal set; }

        public enum CHaMPFileTypes
        {
            TopoData
        }

        public ZipUploader(string sAPIURL, string sClientIdentifer, string sClientSecret, string sUserName, string sPassword)
        {
            APIURL = sAPIURL;
            ClientIdentifier = sClientIdentifer;
            ClientSecret = sClientSecret;
            UserName = sUserName;
            Password = sPassword;
        }

        public void Run(System.IO.FileInfo fiLocalZip, long visitID, CHaMPFileTypes eType)
        {

        }
    }
}
