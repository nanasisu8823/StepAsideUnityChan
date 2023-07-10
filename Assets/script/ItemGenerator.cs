using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject carPrefab;

    public GameObject coinPrefab;

    public GameObject conePrefab;

    private int startPos = 80;

    private int goalPos = 360;
    private float posRange = 3.4f;

    private float posz;
    private GameObject unitychan;
    void Start()
    {


        this.unitychan = GameObject .Find("unitychan");
        




    }

    // Update is called once per frame
    void Update()
    {
        if (unitychan.transform.position.z>posz)
        {
            posz += 15;
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
               
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychan.transform.position.z+40);

                   
                }
            }
            else
            {
                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);

                    int offsetZ = Random.Range(-5, 6);

                    if (1 <= item && item <= 6)
                    {
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychan.transform.position.z + 40 + offsetZ);

                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychan.transform.position.z + 40 + offsetZ);

                    }

                }


            }

        }


    }
}
