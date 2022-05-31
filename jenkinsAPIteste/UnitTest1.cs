using NUnit.Framework;

namespace jenkinsAPIteste
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Test1()
    {
      object a = "a";
      object b = "a";

      Assert.AreSame(a, b);
    }
  }
}