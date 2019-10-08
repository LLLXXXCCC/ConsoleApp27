using System;
using System.Security.Cryptography;

class TestClass
{
    public void A()
    {
    }

    public void B()
    {
    }

    public void TestMethod(byte[] key, byte[] someOtherBytesForIV)
    {
        string someHardCodedBase64String = "sssdsdsdsdsdsds" +
                                          "sdasdsadasddsda" +
                                          "sdasdsadasddsda";
        A();
        B();
        SymmetricAlgorithm rijn = SymmetricAlgorithm.Create();
        rijn.CreateEncryptor(key, someOtherBytesForIV);
        rijn.Dispose();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}