using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CanCreateGameObject
    {
        // A Test behaves as an ordinary method
        [Test]
        public void CanCreateGameObjectSimplePasses()
        {
            // Use the Assert class to test conditions
            GameObject test = new GameObject("GameObject");
            Assert.AreEqual("GameObject", test.name);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CanCreateGameObjectWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
