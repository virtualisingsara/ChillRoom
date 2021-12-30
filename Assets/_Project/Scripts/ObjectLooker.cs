using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectLooker : MonoBehaviour
{
    [SerializeField] private GameObject objectToLookAt;


    // Update is called once per frame
    void Update()
    {
        this.transform.DODynamicLookAt(objectToLookAt.transform.position, 1, AxisConstraint.Y, Vector3.up);
    }
}
