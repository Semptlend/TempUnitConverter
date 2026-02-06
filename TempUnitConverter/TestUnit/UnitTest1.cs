namespace TestUnit;
using System;
using TempUnitConverter;
using Xunit;
public class UnitTest1
{
    Converter converter = new Converter();
    [Fact]
    public void CToKTestShouldReturnDouble()
    {
        Assert.Equal(283.15, converter.CToK(10));
    }
    [Fact]
    public void CToFTestShouldReturnFifty()
    {
        Assert.Equal(50, converter.CToF(10));
    }
    [Fact]
    public void FToCTestShouldReturnTen()
    {
        Assert.Equal(10, converter.FToC(50));
    }
    [Fact]
    public void FToKTestShouldReturnDouble()
    {
        Assert.Equal(283.15, converter.FToK(50));
    }
    [Fact]
    public void KToCtestTestShouldReturnTen()
    {
        Assert.Equal(10, converter.KToC(283.15));
    }
    [Fact]
    public void KToFtestTestShouldReturnFifty()
    {
        Assert.Equal(50, Math.Round(converter.KToF(283.15)));
    }
}
