using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Horizontal
{
    // A Test behaves as an ordinary method
    [Test]
    public void MovementHorizontalSimplePasses()
    {
        //Arange
        var pos = new Vector3(0, 0, 0);
        //Act
        float x = Input.GetAxis("Horizontal");
        //Assert
        pos = new Vector3(1, 0, 0);

    }

}

