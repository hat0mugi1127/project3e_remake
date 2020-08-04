using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    //Textオブジェクト
    private Text score_text;
    //変数確保
    float time, x;
    public int score;
    int life,life_LH;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //時間経過
        time += Time.deltaTime;
        //倍率
        x =(int)(time / 50 + 1);
        //score管理(100s毎に獲得ポイント倍率up)
        score = (int)(time * x) ;
        //オブジェクトからTextコンポーネントを取得
        this.score_text = this.GetComponent<Text>();
        //テキストの表示
        this.score_text.text = "Score : " + score;
        
	}
}
