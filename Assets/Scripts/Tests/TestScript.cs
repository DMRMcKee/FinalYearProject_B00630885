using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestScript
    {
        // Test Movement Controls
        [Test]
        public void TestMovement()
        {


            //Arrange
            float m_speed = 20.0f;
            Vector3 move = new Vector3(0, 0, 0);


            //Act
            if (Input.GetKey(KeyCode.W) && !((Input.GetKey(KeyCode.Q)) || (Input.GetKey(KeyCode.E)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.D))))
                move = new Vector3(0, 0, 1) * Time.deltaTime * m_speed;

            //Assert
            

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
