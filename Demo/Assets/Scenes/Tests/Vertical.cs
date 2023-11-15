using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Vertical
{
    [Test]
    public void MovementVerticalSimplePasses()
    {
        //Arange
        var pos = new Vector3(0, 0, 0);
        //Act
        float x = Input.GetAxis("Vertical");
        //Assert
        pos = new Vector3(0, 1, 0);

    }
}
