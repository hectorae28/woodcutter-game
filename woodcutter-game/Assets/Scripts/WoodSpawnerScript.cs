using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSpawnerScript : MonoBehaviour
{
    public GameObject Wood;
    public GameObject WoodLeft;
    public GameObject WoodRight;
    private int TypeWood;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < 3; i++)
        {
            GameObject newWood=Instantiate(Wood);
            newWood.transform.position=new Vector3(1,9,2);
        }
        for (var i = 0; i < 12; i++){
            SpawnWood();
        }
    }

    // Update is called once per frame
    public void SpawnWood(){
        TypeWood=Random.Range(0,3);
        if(TypeWood==0){
            GameObject newWood=Instantiate(Wood);
            newWood.transform.position=new Vector3(1,15,2);
        }
        else if(TypeWood==1){
            GameObject newWood=Instantiate(WoodLeft);
            newWood.transform.position=new Vector3(-0.83344388f,15.0f,-0.101565838f);
        }
        else if(TypeWood==2){
            GameObject newWood=Instantiate(WoodRight);
            newWood.transform.position=new Vector3(0.816619039f,15.0f,-2.61848927f);
        }
    }
}
