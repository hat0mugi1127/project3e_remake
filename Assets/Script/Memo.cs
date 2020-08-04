//これはメモ帳
//e---enemy(敵・基本的なモーション)
//d---Diagonally(斜め)
//f---fake(ダメージの無い敵)
//LH---LowHp(ダメージが一定限を越した時の値)
//appleは、方向変換付き
//eggがeasy
// 20/03/02に弾幕、キャラクターの移動のプログラム完成
// 20/07/15に調整、かつ、説明の追加
// 20/08/05 UnityからGitHubにコミット、プッシュの練習
// 操作キャラの移動方法に関するscriptがifを使いすぎなので、できるだけシンプルにしたい
// qiitaより、
// void Update() {
    // var a = Input.GetAxis("Horizontal");//左右
    // var b = Input.GetAxis("Vertical");//上下
    // var force = new Vector3(a, 0f, b);//(x, y, z)平面方向がx,z上空方向がy
    // GetComponent<Rigidbody>().AddForce(force * 2000);
    // if (Input.GetMouseButton(0) == true) {
        // this.transform.Rotate(0, 5, 0);
    // }
// }
//このような文もある