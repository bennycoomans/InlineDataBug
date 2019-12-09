using InlineDataBug;
using Xunit;

namespace InlineDataBugTest
{
	public class TestableClassTest
	{
		[Theory]
		[InlineData("https://www.asdf.nl/asdf?lt=BR84879&xl=n&dn=1168&bk=00000001460000370127277527478760185")]
		[InlineData("https://www.asdf.nl/asdf?lt=BR84879&xl=n&dn=1168&bc=000o0001460000370127277527478760185")]
		public void DoWorkTest(string param)
		{
			Assert.True(TestableClass.DoWork(param));
		}
	}
}