using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DateTimeLibrary;

namespace DateTimeLibraryTests
{
    [TestClass]
    public class DateTimeClassTest
    {
        //Вывод ошибки, если дата неверна
        [TestMethod]
        public void PrevDate_EmptyDate_ThrowException()
        {
            //arrange
            DateTime dateTime = DateTime.MinValue;
            //Act
            DateTimeClass obj = new DateTimeClass();
            Action actual = () => obj.PrevDate(dateTime);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        //Вычитание одного дня
        [TestMethod]
        public void PrevDate_PrevdateTime_ReturnTrue()
        {
            //arrange
            DateTime dateTime = new DateTime (2022, 10, 19);
            DateTime result = new DateTime (2022, 10, 18);
            //Act
            DateTimeClass obj = new DateTimeClass();
            DateTime actual = obj.PrevDate(dateTime);
            //Assert
            Assert.AreEqual(actual, result);
        }

        //Вывод ошибки, если дата неверна
        [TestMethod]
        public void NextDate_EmptyDate_ThrowException()
        {
            //arrange
            DateTime dateTime = DateTime.MinValue;
            //Act
            DateTimeClass obj = new DateTimeClass();
            Action actual = () => obj.NextDate(dateTime);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        //Прибавляет один день
        [TestMethod]
        public void NextDate_NextdateTime_ReturnTrue()
        {
            //arrange
            DateTime dateTime = new DateTime(2022, 10, 19);
            DateTime result = new DateTime(2022, 10, 20);
            //Act
            DateTimeClass obj = new DateTimeClass();
            DateTime actual = obj.NextDate(dateTime);
            //Assert
            Assert.AreEqual(actual, result);
        }

        //Вывод ошибки, если дата неверна
        [TestMethod]
        public void DaysUntilEndMonth_EmptyDate_ThrowException()
        {
            //arrange
            DateTime dateTime = DateTime.MinValue;
            //Act
            DateTimeClass obj = new DateTimeClass();
            Action actual = () => obj.DaysUntilEndMonth(dateTime);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        //Определяет сколько дней осталось до конца месяца
        [TestMethod]
        public void DaysUntilEndMonth_DaysUntilEnd_ReturnTrue()
        {
            //arrange
            DateTime dateTime = new DateTime(2022, 10, 19);
            int result = 12;
            //Act
            DateTimeClass obj = new DateTimeClass();
            int actual = obj.DaysUntilEndMonth(dateTime);
            //Assert
            Assert.AreEqual(actual, result);
        }

        //Вывод ошибки, если дата неверна
        [TestMethod]
        public void LeapYearCheck_EmptyDate_ThrowException()
        {
            //arrange
            DateTime dateTime = DateTime.MinValue;
            //Act
            DateTimeClass obj = new DateTimeClass();
            Action actual = () => obj.LeapYearCheck(dateTime);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        //Високосная дата
        [TestMethod]
        public void LeapYearCheck_LeapYear_ReturnTrue()
        {
            //arrange
            DateTime dateTime = new DateTime(2024, 10, 19);
            //Act
            DateTimeClass obj = new DateTimeClass();
            bool actual = obj.LeapYearCheck(dateTime);
            //Assert
            Assert.IsTrue(actual);
        }

        //Вывод ошибки, если дата неверна
        [TestMethod]
        public void FindDate_EmptyDate_ThrowException()
        {
            //arrange
            DateTime dateTime = DateTime.MinValue;
            int i = 5;
            //Act
            DateTimeClass obj = new DateTimeClass();
            Action actual = () => obj.FindDate(dateTime, i);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        //Сравнение дат
        [TestMethod]
        public void FindDate_SumdateTimeandi_ReturnTrue()
        {
            //arrange
            DateTime dateTime = new DateTime(2022, 10, 19);
            int i = 5;
            DateTime result = new DateTime(2022, 10, 24);
            //Act
            DateTimeClass obj = new DateTimeClass();
            DateTime actual = obj.FindDate(dateTime, i);
            //Assert
            Assert.AreEqual(actual, result);
        }

        //Вывод ошибки, если дата неверна
        [TestMethod]
        public void NextDayOfMonth_EmptyDate_ThrowException()
        {
            //arrange
            DateTime dateTime = DateTime.MinValue;
            //Act
            DateTimeClass obj = new DateTimeClass();
            Action actual = () => obj.NextDayOfMonth(dateTime);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        //Вывод false если это последний день месяца, другой день будет true
        [TestMethod]
        public void NextDayOfMonth_31OctItsLastDay_ReturnFalse()
        {
            //arrange
            DateTime dateTime = new DateTime(2022, 10, 31);
            //Act
            DateTimeClass obj = new DateTimeClass();
            bool actual = obj.NextDayOfMonth(dateTime);
            //Assert
            Assert.IsFalse(actual);
        }

        //Вывод ошибки, если дата неверна
        [TestMethod]
        public void FirstDayOdYear_EmptyDate_ThrowException()
        {
            //arrange
            DateTime dateTime = DateTime.MinValue;
            //Act
            DateTimeClass obj = new DateTimeClass();
            Action actual = () => obj.FirstDayOdYear(dateTime);
            //Assert
            Assert.ThrowsException<Exception>(actual);
        }

        //Выводит false т.к. 19 октября не первого января
        [TestMethod]
        public void FirstDayOdYear_19OctItsNotFirstDay_ReturnFalse ()
        {
            //arrange
            DateTime dateTime = new DateTime(2022, 10, 19);
            //Act
            DateTimeClass obj = new DateTimeClass();
            bool actual = obj.FirstDayOdYear(dateTime);
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
