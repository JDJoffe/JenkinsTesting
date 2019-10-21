using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// test namespaces
using NUnit.Framework;
using UnityEngine.TestTools;
public class SimpleTest
{
    [Test]
    public void NUnitTest()
    {
        Assert.IsTrue(false, "Unity Test Failed");
    }
    [UnityTest]
    public IEnumerator UnityTest()
    {
        yield return new WaitForFixedUpdate();
        Assert.IsTrue(false, "Unity Test Failed");
    }
}