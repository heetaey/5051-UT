using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {

        }
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange
            var myTest = new ReportViewModel();

            // Act
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.IsNotNull(result);
        }
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {

        }
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {

        }
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {

        }
    }
}
