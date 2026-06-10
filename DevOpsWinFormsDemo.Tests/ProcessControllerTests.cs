using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsWinFormsDemo.Tests
{
    [TestClass]
    public class ProcessControllerTests
    {
        [TestMethod]
        public void Start_WhenNotRunning_ShouldStartProcess()
        {
            // Arrange
            var controller = new ProcessController();

            // Act
            string result = controller.Start();

            // Assert
            Assert.IsTrue(controller.IsRunning);
            Assert.AreEqual("Process started.", result);
        }

        [TestMethod]
        public void Start_WhenAlreadyRunning_ShouldReturnAlreadyRunningMessage()
        {
            // Arrange
            var controller = new ProcessController();
            controller.Start();

            // Act
            string result = controller.Start();

            // Assert
            Assert.IsTrue(controller.IsRunning);
            Assert.AreEqual("Process is already running.", result);
        }

        [TestMethod]
        public void Stop_WhenRunning_ShouldStopProcess()
        {
            // Arrange
            var controller = new ProcessController();
            controller.Start();

            // Act
            string result = controller.Stop();

            // Assert
            Assert.IsFalse(controller.IsRunning);
            Assert.AreEqual("Process stopped.", result);
        }

        [TestMethod]
        public void Stop_WhenNotRunning_ShouldReturnNotRunningMessage()
        {
            // Arrange
            var controller = new ProcessController();

            // Act
            string result = controller.Stop();

            // Assert
            Assert.IsFalse(controller.IsRunning);
            Assert.AreEqual("Process is not running.", result);
        }

        [TestMethod]
        public void Success_Login_Id()
        {
            var controller = new ProcessController();

            bool issuccess = controller.ID("rorze");

            Assert.IsTrue(issuccess);

        }

        [TestMethod]
        public void fail_Login_Id()
        {
            var controller = new ProcessController();

            bool isfail = controller.ID("ror");

            Assert.IsFalse(isfail);
        }

        [TestMethod]
        public void Success_Login_Pw()
        {
            var controller = new ProcessController();

            bool issuccess = controller.PW("123");

            Assert.IsTrue(issuccess);
        }

        [TestMethod]
        public void Success_Login_Full()
        {
            var controller = new ProcessController();

            bool is_success_id = controller.ID("rorze");
            bool is_success_pw = controller.PW("123");

            Assert.IsTrue(is_success_id);
            Assert.IsTrue(is_success_pw);
        }

    }
}
