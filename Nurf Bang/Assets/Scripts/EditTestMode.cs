using UnityEngine;
using NUnit.Framework;

public class EditTestMode {
    [Test]
    public void Euler()
    {
        Quaternion randomRotation = Random.rotation;
        // To euler
        Vector3 inEuler = randomRotation.eulerAngles;
        // And back
        //ultimatly rotations in unity are going to be stored as such
        Quaternion inQuaternion = Quaternion.Euler(inEuler);
    }
}
