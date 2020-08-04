using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//敵モーション(横移動の付与)

public class Motion_Enemy : MonoBehaviour {
    //移動速度
    public float speed_e;

    // Update is called once per frame
    void Update() {
        transform.Translate(-speed_e * Time.deltaTime, 0, 0);
        Vector3 pos = transform.position;
        if (pos.x <= -10) {
            transform.position = new Vector3(10, pos.y, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        Vector3 pos = transform.position;
        transform.position = new Vector3(10, pos.y, 0);
    }
}
