using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Camera cam;
    private NavMeshAgent nav;

    private Vector3 destinationPos;

    [SerializeField]
    private GameObject hpCanvas;
    private Vector3 hpCanvasPosGap;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        hpCanvasPosGap = transform.position - hpCanvas.transform.position;
    }

    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            RaycastHit hit;

            if(Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Debug.Log(hit.point);
                destinationPos = hit.point;
            }
        }

        nav.SetDestination(destinationPos);

        hpCanvas.transform.position = transform.position - hpCanvasPosGap;
    }
}