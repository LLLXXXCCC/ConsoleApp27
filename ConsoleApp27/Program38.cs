using System;
using System.Security.Cryptography;

class TestClass38
{ 
    public void A()
    {
    }

    public string B(string str)
    {
        return str;
    }

    public void TestMethod(byte[] key, byte[] someOtherBytesForIV)
    {
        string someHardCodedBase64String = "sssdsdsdsdsdsds" +
                                          "sdasdsadasddsda" +
                                          "sdasdsadasddsda";
        A();
        B(someHardCodedBase64String);
        SymmetricAlgorithm rijn = SymmetricAlgorithm.Create();
        rijn.CreateEncryptor(key, someOtherBytesForIV);
        rijn.Dispose();
    }
}