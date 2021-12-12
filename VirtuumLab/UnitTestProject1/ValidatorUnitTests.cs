using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VL.Validator;
using VL.Validator.Models;

namespace UnitTestProject1
{
    /// <summary>
    /// Class_Method_param1_param2_result
    /// </summary>
    [TestClass]
    public class ValidatorUnitTests
    {
        [TestMethod]
        public void Validator_ValidateProject_Empty_Empty_Failed()
        {
            // arrange
            String name = "";
            String description = "";
            Boolean assertResult = false;

            // act
            Result result = Validator.ValidateProject(name, description);

            // assert
            Assert.AreEqual(assertResult, result.IsSuccess);
        }

        [TestMethod]
        public void Validator_ValidateProject_NotEmpty_NotEmpty_Success()
        {
            // arrange
            String name = "Rollex";
            String description = "Sushi and rolls";
            Boolean assertResult = true;

            // act
            Result result = Validator.ValidateProject(name, description);

            // assert
            Assert.AreEqual(assertResult, result.IsSuccess);
        }

        [TestMethod]
        public void Validator_ValidateEmployee_Empty_Empty_Empty_Failed()
        {
            // arrange
            String firstName = "";
            String lastName = "";
            Object type = null;
            Boolean assertResult = false;

            // act
            Result result = Validator.ValidateEmployee(firstName, lastName, type);

            // assert
            Assert.AreEqual(assertResult, result.IsSuccess);
        }

        [TestMethod]
        public void Validator_ValidateEmployee_NotEmpty_NotEmpty_NotEmpty_Success()
        {
            // arrange
            String firstName = "Vitaly";
            String lastName = "Ivanov";
            Object type = new Object();
            Boolean assertResult = true;

            // act
            Result result = Validator.ValidateEmployee(firstName, lastName, type);

            // assert
            Assert.AreEqual(assertResult, result.IsSuccess);
        }

        [TestMethod]
        public void Validator_ValidateVacation_Empty_Empty_Empty_Failed()
        {
            // arrange
            Guid employeeId = Guid.Empty;
            DateTime? dateStart = null;
            DateTime? dateEnd = null;
            Boolean assertResult = false;

            // act
            Result result = Validator.ValidateVacation(employeeId, dateStart, dateEnd);

            // assert
            Assert.AreEqual(assertResult, result.IsSuccess);
        }

        [TestMethod]
        public void Validator_ValidateVacation_NotEmpty_NotEmpty_NotEmpty_Success()
        {
            // arrange
            Guid employeeId = Guid.NewGuid();
            DateTime dateStart = DateTime.Now;
            DateTime dateEnd = DateTime.Now;
            Boolean assertResult = false;

            // act
            Result result = Validator.ValidateVacation(employeeId, dateStart, dateEnd);

            // assert
            Assert.AreEqual(assertResult, result.IsSuccess);
        }
    }
}
