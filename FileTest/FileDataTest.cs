using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FileData;

namespace FileTest
{
    [TestClass]
    public class FileDataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                string[] testArgument1 = new string[] { "-v", "C:/test.txt" };
                FileDataObject fileDataObject = new FileDataObject();
                FileDataClass.GetFileDetails(testArgument1, ref fileDataObject);
                Assert.IsTrue(fileDataObject.fileVersion != string.Empty);
            }
            catch (Exception ex)
            {
               StringAssert.Contains(ex.Message,"File version is not returned");
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                string[] testArgument1 = new string[] { "--v", "C:/test.txt" };
                FileDataObject fileDataObject = new FileDataObject();
                FileDataClass.GetFileDetails(testArgument1, ref fileDataObject);
                Assert.IsTrue(fileDataObject.fileVersion != string.Empty);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "File version is not returned");
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                string[] testArgument1 = new string[] { "/v", "C:/test.txt" };
                FileDataObject fileDataObject = new FileDataObject();
                FileDataClass.GetFileDetails(testArgument1, ref fileDataObject);
                Assert.IsTrue(fileDataObject.fileVersion != string.Empty);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "File version is not returned");
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            try
            {
                string[] testArgument1 = new string[] { "--version", "C:/test.txt" };
                FileDataObject fileDataObject = new FileDataObject();
                FileDataClass.GetFileDetails(testArgument1, ref fileDataObject);
                Assert.IsTrue(fileDataObject.fileVersion != string.Empty);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "File version is not returned");
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            try
            {
                string[] testArgument1 = new string[] { "-s", "C:/test.txt" };
                FileDataObject fileDataObject = new FileDataObject();
                FileDataClass.GetFileDetails(testArgument1, ref fileDataObject);
                Assert.IsTrue(fileDataObject.fileSize != 0);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "File version is not returned");
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            try
            {
                string[] testArgument1 = new string[] { "--s", "C:/test.txt" };
                FileDataObject fileDataObject = new FileDataObject();
                FileDataClass.GetFileDetails(testArgument1, ref fileDataObject);
                Assert.IsTrue(fileDataObject.fileSize != 0);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "File version is not returned");
            }
        }

        [TestMethod]
        public void TestMethod7()
        {
            try
            {
                string[] testArgument1 = new string[] { "/s", "C:/test.txt" };
                FileDataObject fileDataObject = new FileDataObject();
                FileDataClass.GetFileDetails(testArgument1, ref fileDataObject);
                Assert.IsTrue(fileDataObject.fileSize != 0);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "File version is not returned");
            }
        }

        [TestMethod]
        public void TestMethod8()
        {
            try
            {
                string[] testArgument1 = new string[] { "--size", "C:/test.txt" };
                FileDataObject fileDataObject = new FileDataObject();
                FileDataClass.GetFileDetails(testArgument1, ref fileDataObject);
                Assert.IsTrue(fileDataObject.fileSize != 0);
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "File version is not returned");
            }
        }
        
    }
}
