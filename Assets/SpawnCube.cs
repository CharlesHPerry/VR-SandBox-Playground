using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnCube : MonoBehaviour
{
    public GameObject sampleObject;
    public void AddObject()
    {
        GameObject ObjectClone = Instantiate(sampleObject, new Vector3(2, 5, 0), Quaternion.identity);
    }
}
