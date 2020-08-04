using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//scoreの出力(まだ未完成)

public class Output : MonoBehaviour {
    //Text
    private Text output;
    //
    int score;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Score.csの呼び出し
        Score script = GetComponent<Score>();
        score = script.score;
        this.output = this.GetComponent<Text>();
        this.output.text = "成績 : " + score;
    }
}
