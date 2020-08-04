using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion_D : MonoBehaviour {
    //移動速度
    public float speed_e, speed_d;

    // Update is called once per frame
    void Update() {
        Vector3 pos = transform.position;
        transform.Translate(-speed_e * Time.deltaTime, -speed_d * Time.deltaTime, 0);
        if(pos.y <= -5) {
            transform.position = new Vector3(pos.x, 6, 0);
        }        
        if (pos.x <= -10) {
            transform.position = new Vector3(10, pos.y, 0);
        }
    }
}
