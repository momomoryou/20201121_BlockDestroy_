using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeapOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Find("Master").GetComponent<GameMaster>().GameOver("また挑戦しよう"); //<=====文字列を引数へ
    }
}
