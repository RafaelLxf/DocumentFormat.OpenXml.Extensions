using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest.Extensions.Contracts;

namespace dotnetCampus.OpenXmlUnitConverter.Tests
{
    [TestClass]
    public class PixelPointTest
    {
        [ContractTestCase]
        public void Convert()
        {
            "���� Emu ��ʾ�ĵ㣬����ת��Ϊ���ر�ʾ�ĵ�".Test(() =>
            {
                var emuPoint = new EmuPoint(new Emu(952500), new Emu(952500));
                var pixelPoint = emuPoint.ToPixelPoint();
                Assert.AreEqual(100, pixelPoint.X.Value);
                Assert.AreEqual(100, pixelPoint.Y.Value);

                Assert.AreEqual(emuPoint, pixelPoint.ToEmuPoint());
            });
        }
    }
}