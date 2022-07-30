using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodScript : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider2D BoxCollider2D;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cut(){
        //transform.position+= Vector3.left * 15 * Time.time;
        Destroy(gameObject);
    }
}
