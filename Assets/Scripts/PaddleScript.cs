using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    // private float speed;
    public float speed;
    // Start is called before the first frame update
    //最初に１回だけ起動する初期化コード
    void Start()
    {
        // speed = 5f;
    }

    // Update is called once per frame
    //描画されるごとに呼び出されるコード
    void Update()
    {
        //paddle位置を変更
        //transform.positionでpaddle位置を取得
        //Vector3で三方向の指定
        //Input.GetAxisで矢印キーの操作
        //* Time.deltaTimeは端末のスペックによって負荷を変えるコード
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f, 0f);
        // Debug.Log(transform.position.x);

    }
}
