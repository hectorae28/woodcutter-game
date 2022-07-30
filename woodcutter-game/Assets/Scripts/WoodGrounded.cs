using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodGrounded : MonoBehaviour
{
    public bool Woodbool;
    /* private void OnTriggerEnter2D(Collider2D collision) {
        WoodObject=collision;
        Debug.Log(WoodObject);
    } */
    void Update()
    {
        if(Input.touchCount>0){
            Touch touch=Input.GetTouch(0);
            switch (touch.phase){
                case TouchPhase.Began:
                    Woodbool=true;
                    break;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D other) {
        WoodScript wood = other.GetComponent<WoodScript>();
        if(wood!=null&&Woodbool){
            Destroy(other);
            wood.Cut();
            ScoreScript.score++;
            Woodbool=false;
        }
    }
}
