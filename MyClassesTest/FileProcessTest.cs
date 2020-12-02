using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameExiste()
        {
            fileProcess fp = new fileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\windows\regedit.exe");

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNamenaoExiste()
        {
            fileProcess fp = new fileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\regedit.exe");

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameIsnullOrEmpty_thrownewArgumentNullException()
        {
            fileProcess fp = new fileProcess();

            fp.FileExists("");
        }

        [TestMethod]
        public void FileNameIsnullOrEmpty_thrownewArgumentNullException_UsingTryCatch()
        {
            fileProcess fp = new fileProcess();
            try
            {
                fp.FileExists("");
            }
            catch (ArgumentException)
            {
                // teste bem sucedido 
                return;
            }

            Assert.Fail("falha esperada");
        }

    }
}
