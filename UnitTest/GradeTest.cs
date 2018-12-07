using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradesbook;

namespace UnitTest
{
    [TestClass]
    public class GradeTest
    {


        [TestMethod]
        public void ComputesHigestGrade()
        {
            Grade Book = new Grade();
            Book.AddGrade(50);
            Book.AddGrade(75);
            Book.AddGrade(30);

            GradeSataistics result = Book.ComputeStatistics();

            Assert.AreEqual(75, result.highestGrade);
        }

        [TestMethod]
        public void ComputesAvaragestGrade()
        {
            Grade Book = new Grade();
            Book.AddGrade(50);
            Book.AddGrade(75.6f);
            Book.AddGrade(30);

            GradeSataistics result = Book.ComputeStatistics();

            Assert.AreEqual(51.866667, result.AvarageGrade,0.01);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            Grade g1 = new Grade();
            Grade g2 = g1;


            //g1 = new Grade();
            g1.Name = "First My Book";
            Assert.AreEqual(g1, g2);
        }

        [TestMethod]
        public void intVariablesHoldAValue()
        {
            int z1 = 100;
            int z2 = z1;
           // z1 = 4;
            Assert.AreEqual(z1, z2);
        }

        [TestMethod]
        public void StringComparison()
        {
            string n1 = "Kobi";
            string n2 = "kobi";
            bool res = string.Equals(n1, n2, System.StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(res);
        }


        [TestMethod]
        public void ValueTypePassByValue()
        {
            int x = 4;
            IncreaseNum(x);
            Assert.AreEqual(4,x);
        }

        private void IncreaseNum(int no)
        {
            no += 1;
            //return no;
        }

        [TestMethod]
        public void ReferenceTypePassbyValue()
        {
            Grade book = new Grade();
            Grade book2 = book;
            GetName(book);
            Assert.AreEqual("wow", book.Name);
        }
        private void GetName(Grade g1)
        {
       //   Grade g1 = new Grade();
            g1.Name = "wow";
        }
    }


}
