using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTest
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[1]);
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name = name.ToUpper();
            Assert.AreEqual("SCOTT", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncerementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncerementNumber(int number)
        {
            number += 1;
        }

        /*
         * This test fails, because we create new object in GiveBookAName
         * and we can change inside object that pointer point at, but not in new instance
         */

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            book2.Name = "An awesome book";
            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue2()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            book2.Name = "An awesome book";
            GiveBookAName2(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";
        }

        private void GiveBookAName2(GradeBook book)
        {
            //  book = new GradeBook();
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Sally";
            string name2 = "sally";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariableHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void VariablesHoldAReference()
        {
            GradeBook firstGradeBook = new GradeBook();
            GradeBook secondGradeBook = firstGradeBook;
            firstGradeBook = new GradeBook();
            firstGradeBook.Name = "Hellen's grade book";
            Assert.AreNotEqual(firstGradeBook.Name, secondGradeBook.Name);
        }

        private void AddGrades(float[] grades)
        {
            //grades = new float[5];
            grades[1] = 89.1f;
        }
    }
}