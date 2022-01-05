using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vizsgaremek.Models;

namespace Vizsgaremek.Models.Tests
{
    [TestClass()]
    public class ProgramInfoTests
    {
        [TestMethod()]
        public void ProgramInfoTestVersion()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            Version expected = new Version(0, 0, 4, 0);

            // act
            Version actual = programInfo.Version;

            // assert
            Assert.AreEqual(expected, actual, "Version is not 0.0.4.0");
        }



        [TestMethod()]
        public void ProgramInfoTest_Authors_Title()
        {
            // arrange
            ProgramInfo programinfo = new ProgramInfo();
            string expected = programinfo.Title;

            // act
            string actual = "Vizsgaremek";

            // assert
            Assert.AreEqual(expected, actual, "Nem vizsgaremek van odaírva!");
        }

        [TestMethod()]
        public void ProgramInfoTest_Description_test()
        {
            ProgramInfo programinfo = new ProgramInfo();
            string expected = programinfo.Description;

            // act
            string actual = "Teszteket írom";

            // assert
            Assert.AreEqual(expected, actual, "Nem megfelelő a leírás!");
        }

        [TestMethod()]
        public void ProgramInfoTest_Company()
        {
            ProgramInfo programinfo = new ProgramInfo();
            string expected = programinfo.Company;

            // act
            string actual = "Vasvári";

            // assert
            Assert.AreEqual(expected, actual, "Nem egyezik a cég!");
        }

        [TestMethod()]
        public void ProgramInfoTest_Authors()
        {
            ProgramInfo programinfo = new ProgramInfo();
            string expected = programinfo.Authors;

            // act
            string actual = "Koza Miklós";

            // assert
            Assert.AreEqual(expected, actual, "Nem egyezik a tulajdonos név!");
        }
    }



}