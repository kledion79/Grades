using System;
using Grades;
using NUnit.Framework;

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


    }
}