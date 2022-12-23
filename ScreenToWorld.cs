using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToWorld : MonoBehaviour
{
    public GameObject prefeb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                Instantiate(prefeb, hit.point, Quaternion.identity);
            }

        }
    }
}
