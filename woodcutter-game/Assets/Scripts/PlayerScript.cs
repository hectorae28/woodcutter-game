using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public WoodSpawnerScript spawnWoodScript;
    public WoodGrounded woodGrounded;
    public GameManagerScript GameManager;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=new Vector3(-1.84000003f,-3.47000003f,2.69000006f);
        transform.localScale = new Vector3(1.0f,1.0f,1.0f);
    }

    void Update()
    {
        if(Input.touchCount>0&&Time.timeScale!=0){
            Touch touch=Input.GetTouch(0);
            switch (touch.phase){
                case TouchPhase.Began:
                    spawnWoodScript.SpawnWood();
                    if(touch.position.x>Screen.width/2){
                        transform.position=new Vector3(1.82299995f,-3.47000003f,2.69000006f);
                        transform.localScale = new Vector3(-1.0f,1.0f,1.0f);
                    }
                    else if(touch.position.x<Screen.width/2){
                        transform.position=new Vector3(-1.84000003f,-3.47000003f,2.69000006f);
                        transform.localScale = new Vector3(1.0f,1.0f,1.0f);
                    }
                    break;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        GameManager.GameOver();
    }
}
