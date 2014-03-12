using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtendedList;
using System;
using System.Collections.Generic;

namespace ExtendedList.Test
{
    [TestClass()]
    public class ExtendedListTest
    {

        #region ConstructorTests
        [TestMethod()]
        public void ConstructorEmptyTest()
        {
            // Arange
            var list = new ExtendedList<string>();

            // Act
            int CurrentCapacity = 10;

            // Assert
            Assert.AreEqual(CurrentCapacity, list.Capacity);
        }

        [TestMethod]
        public void ConstructorInitialCapacityTest()
        {
            var list = new ExtendedList<string>(5);
            const int InitialCapacity = 5;
            Assert.AreEqual(InitialCapacity, list.Capacity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorInitialCapacityNegativeTest()
        {
            const int InitialNegativeCapacity = -5;
            var list = new ExtendedList<string>(InitialNegativeCapacity);
        }

        [TestMethod]
        public void ConstructorInitialCapacityZeroTest()
        {
            const int InitialCapacity = 0;
            var list = new ExtendedList<string>(0);
            Assert.AreEqual(InitialCapacity, list.Capacity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorInitialCapacityMaxPlusOneTest()
        {
            int InitialMaxCapacity = int.MaxValue;
            var list = new ExtendedList<string>(InitialMaxCapacity + 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorInitialCapacityMinPluOneTest()
        {
            int InitialNegativeMinCapacity = int.MinValue;
            var list = new ExtendedList<string>(InitialNegativeMinCapacity - 1);
        }

        [TestMethod]
        public void ConstructorListSourceCountTest()
        {
            var list = new List<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            var extendedList = new ExtendedList<string>(list);
            Assert.AreEqual(list.Count, extendedList.Count);
        }

        [TestMethod]
        public void ConstructorListSourceEqualElementTest()
        {
            var list = new List<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            var extendedList = new ExtendedList<string>(list);
            Assert.AreEqual(list.Count, extendedList.Count);
        }
        #endregion

        #region HelpperStubs

        private List<T> LoadList<T>()
        {
            var list = new List<T>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            return list;
        }
        #endregion
    }
}
