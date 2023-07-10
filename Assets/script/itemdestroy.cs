using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdestroy : MonoBehaviour
{
    private GameObject maincamera;


    // Start is called before the first frame update
    void Start()
    {
        this.maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {


        if (this.maincamera.transform.position.z - this.transform.position.z > 0)
        {
            Destroy(this.gameObject);
        }
    }
}
