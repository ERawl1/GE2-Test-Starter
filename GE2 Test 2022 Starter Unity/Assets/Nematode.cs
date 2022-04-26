using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public List<GameObject> nematodeBody = new List<GameObject>();     

    public Material material;

    void Awake()
    {
        GameObject head = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        head.transform.position = gameObject.transform.position;
        head.transform.parent = gameObject.transform;

        

        

        for (int i = 0; i < length; i++)
        {
           GameObject body = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            nematodeBody.Add(body);

            if(nematodeBody.Count < 2)
            {
                body.transform.position = (head.transform.position += Vector3.right * 1f); 
                
            }
            else
            {
                nematodeBody[i].transform.position = (nematodeBody[i - 1].transform.position += Vector3.right * 1f);   
            }

            body.transform.parent = gameObject.transform;
            
        }
       
    }
}
