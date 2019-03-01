using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace JaratKezelo.Tests
{
    [TestFixture]
    class Tests
    {
        JaratKezelo j;

        [SetUp]
        public void Setup()
        {
            j = new JaratKezelo();
        }

        [Test]
        public void MikorIndulTest()
        {
            j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019,12,06,12,30,30));
            var sajt = j.MikorIndul("222");
            Assert.AreEqual(new DateTime(2019, 12, 06, 12, 30, 30), sajt);
        }

        [Test]
        public void RosszBemenet()
        {
            j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 30, 30));
            Assert.Throws<ArgumentException>(() =>
               {
                   j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 50, 10));
               }
               );
        }


    }
}
