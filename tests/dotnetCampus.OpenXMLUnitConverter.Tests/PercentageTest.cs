using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest.Extensions.Contracts;

namespace dotnetCampus.OpenXMLUnitConverter.Tests
{
    [TestClass]
    public class PercentageTest
    {
        [ContractTestCase]
        public void ParsePercentageText()
        {
            "������ٷֺŵ���ֵ������ת��Ϊ�ٷֺ�".Test(() =>
            {
                var percentageText = "100%";
                var percentage = new Percentage(percentageText);
                Assert.AreEqual(100000, percentage.IntValue);
            });

            "����ٷֺŴ�С�������ֵ����ת���� OpenXML ��λ������".Test(() =>
            {
                var percentageText = "99.999%";
                var percentage = new Percentage(percentageText);
                Assert.AreEqual(99999, percentage.IntValue);
            });
        }
    }
}
