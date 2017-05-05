using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHaMPZipUploader
{
    class Program
    {
        static void Main(string[] args)
        {
            string APIURL = "";
            string sClientIdentifier = "";
            string sClientSecret = "";
            string sPassword = "";
            string sUserName = "";

            System.IO.FileInfo fiZip = new System.IO.FileInfo("");
            long nVisitID = 0;

            try
            {
                ZipUploader zip = new ZipUploader(APIURL, sClientIdentifier, sClientSecret, sUserName, sPassword);

                zip.Run(fiZip, nVisitID, ZipUploader.CHaMPFileTypes.TopoData);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
