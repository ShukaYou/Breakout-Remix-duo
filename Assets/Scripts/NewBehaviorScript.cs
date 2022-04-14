using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviorScript : MonoBehaviour
{
    public int RotationSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            //docs.unity3d.com/2018.1/Documentation/ScriptReference/Transform.Rotate.html  
            transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed * 20);
        
    }
}
