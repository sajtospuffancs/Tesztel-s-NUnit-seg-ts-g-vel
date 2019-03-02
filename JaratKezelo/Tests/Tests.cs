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
            Assert.AreEqual(new DateTime(2019, 12, 06, 12, 30, 30), j.MikorIndul("222"));
        }

        [Test]
        public void HibasJaratIndulas()
        {
            j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 30, 30));
            Assert.Throws<ArgumentException>(() =>
            {
                j.MikorIndul("225");
            });
        }


        [Test]
        public void AdatDuplikalasHibaTest()
        {
            j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 30, 30));
            Assert.Throws<ArgumentException>(() =>
               {
                   j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 50, 10));
               }
               );
        }

        [Test]
        public void Kesesnegativ()
        {
            j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 50, 10));
            j.Keses("222", 5);
            Assert.Throws<NegativKesesException>(() =>
            {
                j.Keses("222", -6);
            });
        }

        [Test]
        public void KesesSikeresHozzaadas()
        {
            j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 50, 10));
            j.Keses("222", 5);
            j.Keses("222", 5);
            Assert.AreEqual(10, j.JelenlegiKeses("222"));
        }

        [Test]
        public void JaratokRepuloterrolTest()
        {
            j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 50, 10));
            j.ujJarat("223", "Tajgetosz", "Athén", new DateTime(2019, 12, 07, 13, 50, 10));
            j.ujJarat("225", "Tajgetosz", "Athén", new DateTime(2019, 12, 08, 08, 20, 10));
            List<string> jaratok = j.JaratokRepuloterrol("Tajgetosz");
            Assert.AreEqual(3, jaratok.Count());
        }

        [Test]
        public void JaratokRosszRepterrol()
        {
            j.ujJarat("222", "Tajgetosz", "Athén", new DateTime(2019, 12, 06, 12, 50, 10));
            j.ujJarat("223", "Himalája", "Athén", new DateTime(2019, 12, 07, 13, 50, 10));
            j.ujJarat("225", "Oroszország", "Athén", new DateTime(2019, 12, 08, 08, 20, 10));
            List<string> jaratok = j.JaratokRepuloterrol("Magyarország");
            Assert.AreEqual(0, jaratok.Count());
        }


    }
}
