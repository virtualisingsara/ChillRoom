using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLooker : MonoBehaviour
{
    [SerializeField] private GameObject objectToLookAt;

    // Update is called once per frame
    void Update()
    {
        Vector3 lookAtFloorLevel = new Vector3(objectToLookAt.transform.position.x,
                                               this.transform.position.y, 
                                               objectToLookAt.transform.position.z);

        //Los objetos con este script mirarán automáticamente al objeto indicado (al nivel del suelo)
        transform.LookAt(objectToLookAt.transform, Vector3.up);
    }
}
