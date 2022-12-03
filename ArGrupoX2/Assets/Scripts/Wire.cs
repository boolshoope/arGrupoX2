using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public LineRenderer line;
    public Transform cornerPos1;
    public Transform cornerPos2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cornerPos1 != null && cornerPos2 != null)
        {
            line.SetPosition(0, cornerPos1.position);
            line.SetPosition(1, cornerPos2.position);
        }

        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "R1")
        {
            Debug.Log("Colisao com R1");
        }
    }
}
