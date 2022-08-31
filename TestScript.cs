using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Vector3 RotateAmount;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Function");
    }

    // This was used for optimized display of the cube during my first tutorial: Debug.Log("Update Function");
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount);
    }

}
