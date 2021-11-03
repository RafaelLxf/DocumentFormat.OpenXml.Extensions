using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest.Extensions.Contracts;

namespace dotnetCampus.OpenXmlUnitConverter.Tests
{
    [TestClass]
    public class PixelSizeTest
    {
        [ContractTestCase]
        public void Convert()
        {
            "���� EMU ��ʾ�ĳߴ磬����ת��Ϊ���ر�ʾ�ĳߴ磬����תֵ��ͬ".Test(() =>
            {
                var emuSize = new EmuSize(new Emu(952500), new Emu(95250));
                var pixelSize = emuSize.ToPixelSize();

                Assert.AreEqual(100, pixelSize.Width.Value);
                Assert.AreEqual(10, pixelSize.Height.Value);

                Assert.AreEqual(emuSize, pixelSize.ToEmuSize());
            });
        }
    }
}