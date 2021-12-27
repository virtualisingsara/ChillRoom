using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Para que el objeto que contenga este Script automáticamente cree un LineRenderer
[RequireComponent(typeof(LineRenderer))]

public class RaycastCaster : MonoBehaviour
{
    [SerializeField] private float maxDistance = 10f;
    //Para ver el Raycast en la ventana Game (crear Line Renderer en el objeto con el Script)
    private LineRenderer lineRenderer;

    private void Awake()
    {
        //Para ver el Raycast en la ventana Game
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(origin: this.transform.position, direction: transform.forward, out hit, maxDistance: maxDistance))
        {
            Debug.Log("I have interacted with " + hit.transform.name);
            //Para ver el Raycast en el editor, ya que sino es invisible:
            Debug.DrawRay(this.transform.position, transform.forward * maxDistance, Color.red);
            DrawLineRenderer(hit);
        } else
        {
            Debug.DrawRay(this.transform.position, transform.forward * maxDistance, Color.gray);
        }
    }

    //Para ver el Raycast en la ventana Game
    private void DrawLineRenderer(RaycastHit hit)
    {
        if (lineRenderer)
        {
            lineRenderer.SetPosition(0, this.transform.position);
            lineRenderer.SetPosition(1, hit.point);
        }
    }

}
