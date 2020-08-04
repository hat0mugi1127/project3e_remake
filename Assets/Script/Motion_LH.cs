using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//______LowHP

public class Motion_LH : MonoBehaviour {
    //カウンター
    int c = 0;
    //ライフ
    public int life = 2;
    //speedの入手
    public int speed_n, speed_s;
    int speed;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //移動
        if (c == 1) {
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
        }
        //速度チェンジ
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = speed_s;
        } else {
            speed = speed_n;
        }
        //ライフ0の時
        if (life <= 0) {
            SceneManager.LoadScene("Gameover");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        //apple_HighHPと入れ替え
        if (c == 0) {
            transform.position = new Vector3(0, 0, 0);
            c = 1;
        } else {
            life -= 1;
        }
    }
}