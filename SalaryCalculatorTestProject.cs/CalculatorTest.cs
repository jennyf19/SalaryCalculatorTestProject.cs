using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace SalaryCalculatorTestProject.cs
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(50);

            // Assert
            Assert.AreEqual(104000, annualSalary);
        }

        [TestMethod]
        public void AnnualSalaryZeroTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(0);

            // Assert
            Assert.AreEqual(0, annualSalary);
        }

        [TestMethod]
        public void AnnualSalaryNegativeTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal annualSalary = sc.GetAnnualSalary(-12);

            // Assert
            Assert.AreEqual(0, annualSalary);
        }

        [TestMethod]
        public void HourlyWageTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            // Assert
            Assert.AreEqual(25, hourlyWage);
        }

        [TestMethod]
        public void HourlyWageZeroTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(0);

            // Assert
            Assert.AreEqual(0, hourlyWage);
        }

        [TestMethod]
        public void HourlyWageNegativeTest()
        {
            // Arrange
            SalaryCalculator sc = new SalaryCalculator();

            // Act
            decimal hourlyWage = sc.GetHourlyWage(-1);

            // Assert
            Assert.AreEqual(0, hourlyWage);
        }
    }
}
