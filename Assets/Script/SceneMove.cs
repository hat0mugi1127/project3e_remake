using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour {
    //Sceneの移動
    public void Move(string Move_left, string Move_right, string Go_Scene) {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            //右のページに移動
            SceneManager.LoadScene(Move_left);
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            //左のページに移動
            SceneManager.LoadScene(Move_right);
        } else if (Input.GetKeyDown(KeyCode.Space)) {
            //そのステージをプレイ
            SceneManager.LoadScene(Go_Scene);
        }
    }
    // Update is called once per frame
    void Update() {
        //ホーム移動
        if (SceneManager.GetActiveScene().name == "Home") {
            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene("Select_egg");
            }
        }
        //ホームに戻る
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene("Home");
        }

        //ゲームキャラクター選択
        if (SceneManager.GetActiveScene().name == "Select_apple") {
            //Scene_appleの場合の移動場所の設定
            Move("Select_egg", "Select_ghost", "Play_apple");
        } else if (SceneManager.GetActiveScene().name == "Select_ghost") {
            //Scene_ghostの場合の移動場所の設定
            Move("Select_apple", "Select_grape", "Play_ghost");
        } else if (SceneManager.GetActiveScene().name == "Select_grape") {
            //Scene_grapeの場合の移動場所の設定
            Move("Select_ghost", "Select_egg", "Play_grape");
        } else if (SceneManager.GetActiveScene().name == "Select_egg") {
            //Scene_eggの場合の移動場所の設定
            Move("Select_grape", "Select_apple", "Play_egg");
        }
    }
}

