using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldToScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject obj;
    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.WorldToScreenPoint(obj.transform.position);
    }
}
