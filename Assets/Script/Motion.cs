using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//キャラクターの初期状況、ダメージを受けるとLH(LowHP)とチェンジ

public class Motion : MonoBehaviour {
    //GameObjectの確保
    public GameObject apple;
    //体力
    public int life;
    //スピード
    private int speed;
    public int speed_n, speed_s;
    //座標獲得
    public float x, y;
    // Update is called once per frame
    void Update() {
        //移動
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        //速度チェンジ
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = speed_s;
        } else {
            speed = speed_n;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        //float x, y, z;
        life -= 1;
        if (life <= 2) {
            //Jump
            transform.position = new Vector3(-30, -30, 0);
            //動作を停止
            speed_n = 0;
            speed_s = 0;
        }

        //座標取得
        // apple = GameObject.Find("apple");
        //Vector3 tmp = apple.transform.position;
        //各座標の代入         
        //if ( tmp.x >= -20 && tmp.y >= -20) {
        // x = tmp.x;
        //y = tmp.y;
        //z = tmp.z;
        //}      
        //座標確保
        //Debug.Log(tmp.x);     調整が必須なので一度放置

    }
}

