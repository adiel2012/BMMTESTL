using System;
using System.Threading;
using System.Windows.Forms;
using BMMTestLabs.Controller;
using BMMTestLabs.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1HASH
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            App app = App.GetInstance();
            MainFrameMDIParent form = app.run();
            app.create_control_repository(@"C:\\Users\\adiel\\Documents\\Visual Studio 2013\\Projects\\BMMTestLabs\\BMMTestLabs\bin\\Debug\\HashRepository.csv");
            app.create_control_result(@"C:\\Users\\adiel\\Documents\\Visual Studio 2013\\Projects\\BMMTestLabs\\BMMTestLabs\bin\\Debug\\HashResults.csv");
            Thread.Sleep(2000);
            form.autoclose();
            bool enabledexport = form.BtnExport.Enabled;
            form.Load += delegate(object sender, EventArgs e)
            {
                form.BtnResultCompare.PerformClick();
                enabledexport = form.BtnExport.Enabled;
            };
            Application.Run(form);
            Assert.IsTrue(enabledexport);

        }

        
    }
}
