using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//敵モーション(fake(嘘)enemyのスクリプト)

public class Motion_f : MonoBehaviour {
    //移動速度
    public float speed_e;
    int c = 0;

    // Update is called once per frame
    void Update() {
        if (c == 0) {
            transform.Translate(-speed_e * Time.deltaTime, 0, 0);
        }
        Vector3 pos = transform.position;
        if (pos.x <= 0) {
            transform.position = new Vector3(20, pos.y, 0);
            c = 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        Vector3 pos = transform.position;
        transform.position = new Vector3(20, pos.y, 0);
    }
}
