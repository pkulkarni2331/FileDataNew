using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public class FileDataObject
    {
        public string fileVersion { get; set; }

        public int fileSize { get; set; }
    }
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileDataObject fileDataObject = new FileDataObject() { fileSize = 0, fileVersion = string.Empty };
            FileDataClass.GetFileDetails(args, ref fileDataObject);
            if (fileDataObject.fileVersion != string.Empty)
            {
                Console.WriteLine(fileDataObject.fileVersion);
            }
            else
            {
                Console.WriteLine(fileDataObject.fileSize);
            }
            Console.ReadLine();
        }
    }
    public static class FileDataClass
    {
        public static void GetFileDetails(string[] fileArguments, ref FileDataObject fdo)
        {
            try
            {
                FileDetails fileDetails = new FileDetails();
                switch (fileArguments[0])
                {
                    case "-v":
                    case "--v":
                    case "/v":
                    case "--version":
                        fdo.fileVersion = fileDetails.Version(fileArguments[1]);
                        break;
                    case "-s":
                    case "--s":
                    case "/s":
                    case "--size":
                        fdo.fileSize = fileDetails.Size(fileArguments[1]);
                        break;
                    default: break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
