using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationonPivot : MonoBehaviour
{
    //Attach this script to a GameObject to rotate around the target position.
    public class Example : MonoBehaviour
    {
        //Assign a GameObject in the Inspector to rotate around
        public GameObject Sphere;

        void Update()
           
        {
            transform.RotateAround(Sphere.transform.position, new Vector3(0, 1, 0), 100 * Time.deltaTime);
        }
    }
}
