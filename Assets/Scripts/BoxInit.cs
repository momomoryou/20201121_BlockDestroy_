using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour
{

    public GameObject boxObjPrefab;
    public GameObject boxesObj;

    public int BoxNum = 8;
    public int BoxNum2 = 5;

    void Awake()
    {
        GameObject masterObj = GameObject.Find("Master");
        for (int i = 0; i < BoxNum; i++)
        {
            for (int j = 0; j < BoxNum2; j++)
            {
                GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
                g.transform.position = new Vector3((2f + (1f * j)), 0.4f, (-4.2f + (1.2f * i)));
                g.GetComponent<Destroyer>().masterObj = masterObj;
            }
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}