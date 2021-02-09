using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bici : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] partes = new GameObject[12];
        for(int i = 0;i < partes.Length;i++){
            partes[i] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
         //   partes[i].transform.position = new Vector3(1.5f*i,1.5f*i,1.5f*i);
        }
        Quaternion horizontal = Quaternion.Euler(90f,0,0);
        Quaternion horizontal2 = Quaternion.Euler(0,0,90f);
        Quaternion horizontal3 = Quaternion.Euler(0,0,-90f);

        partes[0].transform.rotation = Quaternion.Slerp(partes[0].transform.rotation, horizontal, 1);
        partes[1].transform.rotation = Quaternion.Slerp(partes[1].transform.rotation, horizontal, 1);
        partes[0].transform.position += new Vector3(3f,0f,0f);
        partes[1].transform.position -= new Vector3(3f,0f,0f);
        partes[0].transform.localScale = new Vector3(3f, 0.05f, 3f);
        partes[1].transform.localScale = new Vector3(3f, 0.05f, 3f);
        partes[0].GetComponent<Renderer>().material.color = new Color(0,0,0); 
        partes[1].GetComponent<Renderer>().material.color = new Color(0,0,0);


        partes[2].transform.rotation = Quaternion.Slerp(partes[2].transform.rotation, horizontal, 1);
        partes[3].transform.rotation = Quaternion.Slerp(partes[3].transform.rotation, horizontal, 1);
        partes[2].transform.position += new Vector3(3f,0f,0f);
        partes[3].transform.position -= new Vector3(3f,0f,0f);
        partes[2].transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        partes[3].transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        partes[2].GetComponent<Renderer>().material.color = new Color(1f,1f,1f); 
        partes[3].GetComponent<Renderer>().material.color = new Color(1f,1f,1f); 

        partes[4].transform.position -= new Vector3(3f,-1.5f,0f);
        partes[4].transform.localScale = new Vector3(0.3f,1.5f,0.3f);
        partes[4].GetComponent<Renderer>().material.color = new Color(1f,0,0); 

        partes[5].transform.rotation = Quaternion.Slerp(partes[5].transform.rotation, horizontal, 1);
        partes[5].transform.position -= new Vector3(3f, -3f, 0f);
        partes[5].transform.localScale = new Vector3(0.3f,1f,0.3f);
        partes[5].GetComponent<Renderer>().material.color = new Color(0,0,0);        

        partes[6].transform.rotation = Quaternion.Slerp(partes[6].transform.rotation, horizontal2, 1);
        partes[6].transform.position -= new Vector3(1f, -2f, 0f);
        partes[6].transform.localScale = new Vector3(0.3f,2f,0.3f);
        partes[6].GetComponent<Renderer>().material.color = new Color(1f,0,0); 


        partes[7].transform.position -= new Vector3(-1f,-1.25f,0f);
        partes[7].transform.localScale = new Vector3(0.3f,1.5f,0.3f);
        partes[7].GetComponent<Renderer>().material.color = new Color(1f,0,0); 
        
        partes[8].transform.rotation = Quaternion.Slerp(partes[8].transform.rotation, horizontal2, 0.65f);
        partes[8].transform.localScale = new Vector3(0.3f,2.4f,0.3f);
        partes[8].transform.position -= new Vector3(1f,-0.9f,0);
        partes[8].GetComponent<Renderer>().material.color = new Color(1f,0,0); 

        partes[9].transform.rotation = Quaternion.Slerp(partes[9].transform.rotation, horizontal3,0.9f);
        partes[9].transform.localScale = new Vector3(0.3f,1f,0.3f);
        partes[9].transform.position -= new Vector3(-2f,0.2f,0);
        partes[9].GetComponent<Renderer>().material.color = new Color(1f,0,0); 

        partes[10].transform.rotation = Quaternion.Slerp(partes[10].transform.rotation, horizontal2,0.45f);
        partes[10].transform.localScale = new Vector3(0.3f,1.5f,0.3f);
        partes[10].transform.position -= new Vector3(-2f, -0.8f,0);
        partes[10].GetComponent<Renderer>().material.color = new Color(1f,0,0); 

        partes[11].transform.localScale = new Vector3(1f,0.1f,1f);
        partes[11].transform.position -= new Vector3(-1f,-2.8f,0);
        partes[11].GetComponent<Renderer>().material.color = new Color(0,0,0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
