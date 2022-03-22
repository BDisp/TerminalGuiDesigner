using NUnit.Framework;
using System.IO;
using System.Linq;
using Terminal.Gui;
using TerminalGuiDesigner;
using TerminalGuiDesigner.Operations;
using TerminalGuiDesigner.ToCode;

namespace tests;

public class DimTests
{
    [Test]
    public void TestIsAbsolute()
    {
        Assert.IsTrue(Dim.Sized(50).IsAbsolute());
        Assert.IsFalse(Dim.Sized(50).IsPercent());
        Assert.IsFalse(Dim.Sized(50).IsFill());

        Assert.IsTrue(Dim.Sized(50).IsAbsolute(out int size));
        Assert.AreEqual(50,size);

        Assert.IsTrue(Dim.Sized(50).GetDimType(out var type, out var val, out var offset));
        Assert.AreEqual(DimType.Absolute,type);
        Assert.AreEqual(50,val);
        Assert.AreEqual(0,offset);
    }


    [Test]
    public void TestIsAbsolute_FromInt()
    {
        Dim d = 50;
        Assert.IsTrue(d.IsAbsolute());
        Assert.IsFalse(d.IsPercent());
        Assert.IsFalse(d.IsFill());

        Assert.IsTrue(d.IsAbsolute(out int size));
        Assert.AreEqual(50,size);

        Assert.IsTrue(d.GetDimType(out var type, out var val, out var offset));
        Assert.AreEqual(DimType.Absolute,type);
        Assert.AreEqual(50,val);
        Assert.AreEqual(0,offset);
    }


    [Test]
    public void TestIsPercent()
    {
        Assert.IsFalse(Dim.Percent(24).IsAbsolute());
        Assert.IsTrue(Dim.Percent(24).IsPercent());
        Assert.IsFalse(Dim.Percent(24).IsFill());

        Assert.IsTrue(Dim.Percent(24).IsPercent(out var size));
        Assert.AreEqual(24f,size);

        Assert.IsTrue(Dim.Percent(24).GetDimType(out var type, out var val, out var offset));
        Assert.AreEqual(DimType.Percent,type);
        Assert.AreEqual(24,val);
        Assert.AreEqual(0,offset);
    }


    [Test]
    public void TestIsFill()
    {
        Assert.IsFalse(Dim.Fill(2).IsAbsolute());
        Assert.IsFalse(Dim.Fill(2).IsPercent());
        Assert.IsTrue(Dim.Fill(2).IsFill());

        Assert.IsTrue(Dim.Fill(5).IsFill(out var margin));
        Assert.AreEqual(5,margin);

        Assert.IsTrue(Dim.Fill(5).GetDimType(out var type, out var val, out var offset));
        Assert.AreEqual(DimType.Fill,type);
        Assert.AreEqual(5,val);
        Assert.AreEqual(0,offset);
    }

    [Test]
    public void TestGetDimType_WithOffset()
    {
        var d = Dim.Percent(50) + 2;
        Assert.True(d.GetDimType(out DimType type,out float value,out int offset),$"Could not figure out DimType for '{d}'");
        Assert.AreEqual(DimType.Percent,type);
        Assert.AreEqual(50,value);
        Assert.AreEqual(2,offset);

        d = Dim.Percent(50) - 2;
        Assert.True(d.GetDimType(out type,out value,out offset),$"Could not figure out DimType for '{d}'");
        Assert.AreEqual(DimType.Percent,type);
        Assert.AreEqual(50,value);
        Assert.AreEqual(-2,offset);

        d = Dim.Fill(5) + 2;
        Assert.True(d.GetDimType(out type,out value,out offset),$"Could not figure out DimType for '{d}'");
        Assert.AreEqual(DimType.Fill,type);
        Assert.AreEqual(5,value);
        Assert.AreEqual(2,offset);

        d = Dim.Fill(5) - 2;
        Assert.True(d.GetDimType(out type,out value,out offset),$"Could not figure out DimType for '{d}'");
        Assert.AreEqual(DimType.Fill,type);
        Assert.AreEqual(5,value);
        Assert.AreEqual(-2,offset);
    }



    [Test]
    public void TestGetCode_WithNoOffset()
    {
        var d = Dim.Percent(50);
        Assert.AreEqual("Dim.Percent(50)",d.GetCode());

        d = Dim.Percent(50);
        Assert.AreEqual("Dim.Percent(50)",d.GetCode());

        d = Dim.Fill(5);
        Assert.AreEqual("Dim.Fill(5)",d.GetCode());

        d = Dim.Fill(5);
        Assert.AreEqual("Dim.Fill(5)",d.GetCode());
    }

    [Test]
    public void TestGetCode_WithOffset()
    {
        var d = Dim.Percent(50) + 2;
        Assert.AreEqual("Dim.Percent(50) + 2",d.GetCode());

        d = Dim.Percent(50) - 2;
        Assert.AreEqual("Dim.Percent(50) - 2",d.GetCode());

        d = Dim.Fill(5) + 2;
        Assert.AreEqual("Dim.Fill(5) + 2",d.GetCode());

        d = Dim.Fill(5) - 2;
        Assert.AreEqual("Dim.Fill(5) - 2",d.GetCode());
    }
}