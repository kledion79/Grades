using System;
using Grades;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace GradeBookTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }
        [Test]
        public void ComputeLowestGrade ()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [Test]

        public void CheckIsNotNull()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            GradeStatistics result = book.ComputeStatistics();
            Assert.IsNotNull(result.AverageGrade);

        }

        [Test]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [Test]
        public void GradeBookVariableHolder()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1 = new GradeBook();
            g1.Name = "Scott's great book";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }

        [Test]
        public void TypeTest()
        {
            string name1 = "Scott";
            string name2 = "scott";
            bool result = string.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestValues()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            GiveBookAName(book2);
            Assert.AreEqual("A grand Book", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A grand Book";
        }

        [Test]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number = number + 1;
        }

        [Test]
        public void VerifyTrim()
        {
            string book = " my book ";
            book = book.Trim();
            Assert.AreEqual(book, "my book");
        }

        [Test]
        public void AddDaysTime()
        {
            DateTime date = new DateTime(2018, 10, 18);
            date = date.AddDays(1);
            Assert.AreEqual(19, date.Day);

        }
        
        [Test]
        public void UpperCaseString()
        {
           string name = "kley";
           name = name.ToUpper();
           Assert.AreEqual("KLEY", name);
        }

        [Test]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];
            AddGrades(grades);
            Assert.AreEqual(89.1f, grades[0]);
        }

        private void AddGrades(float[] grades)
        {
            grades[0] = 89.1f;
        }
    }
} 