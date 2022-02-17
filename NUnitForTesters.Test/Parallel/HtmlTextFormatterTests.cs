using NUnit.Framework;
using NUnitForTesters.Parallel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitForTesters.Test.Parallel
{
    [Parallelizable(ParallelScope.Children)]
    public class HtmlTextFormatterTests
    {
        private HtmlTextFormatter htmlTextFormatter;

        [SetUp]
        public void Setup()
        {
            htmlTextFormatter = new HtmlTextFormatter();
        }

        [Test]
        public void TestBoldStuff()
        {
            String result = htmlTextFormatter.FormatAsBold("Okazja!!!");
            StringAssert.IsMatch(result, "<b>Okazja!!!</b>");
        }

        [Test]
        public void TestItalicStuff()
        {
            String result = htmlTextFormatter.FormatAsItalic("Okazja!!!");
            StringAssert.IsMatch(result, "<i>Okazja!!!</i>");
        }

        [Test]
        public void TestSmallStuff()
        {
            String result = htmlTextFormatter.FormatAsSmall("Okazja!!!");
            StringAssert.IsMatch(result, "<small>Okazja!!!</small>");
        }

        [Test]
        public void TestDeletedStuff()
        {
            String result = htmlTextFormatter.FormatAsDeleted("Okazja!!!");
            StringAssert.IsMatch(result, "<del>Okazja!!!</del>");
        }

        [Test]
        public void TestSubscriptStuff()
        {
            String result = htmlTextFormatter.FormatAsSubscript("Okazja!!!");
            StringAssert.IsMatch(result, "<sub>Okazja!!!</sub>");
        }

        [Test]
        public void TestCustomStuff()
        {
            String result = htmlTextFormatter.FormatAsCustomTag("Okazja!!!", "div");
            StringAssert.IsMatch(result, "<div>Okazja!!!</div>");
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(1500);
        }

    }
}
