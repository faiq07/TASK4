using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class pointsTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void pointsTestSimplePasses()
    {
        
        // Use the Assert class to test conditions
        var Points=new points();
        var FireEncounter=2;
        var expectedPoints=10;
        
        var outPutPoints=Points.pointsCal(FireEncounter);

        Assert.That(outPutPoints,Is.EqualTo(expectedPoints));
    }
    [Test]
    public void pointsTestSimplePasses1()
    {
        
        // Use the Assert class to test conditions
        var Points1=new points1();
        var FireEncounter1=2;
        var expectedPoints1=10;
        
        var outPutPoints1=Points1.pointsCal1(FireEncounter1);

        Assert.That(outPutPoints1,Is.EqualTo(expectedPoints1));
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator pointsTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
