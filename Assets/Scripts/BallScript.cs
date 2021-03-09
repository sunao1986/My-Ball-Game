using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        //5以上15以下の値をランダムに生成する
        speed = Random.Range(5f,15f);
    }

    // Update is called once per frame
    void Update()
    {
        //手前に移動するボール
        //Z方向に５進んだり15進んだりするボールが作られる
        transform.position += new Vector3(0f,0f,-1 * speed *  Time.deltaTime);
        //ボールが一定値を超えたらゲームオーバー
        if (transform.position.z < -13.0f)
        {
            // Debug.Log("Game Over");
            // Time.timeScale = 0;
            SceneManager.LoadScene("GameOverScene");
        }

    }

    // OnCollisionEnterこのオブジェクトが何かと衝突したときに、というメソッド
    private void OnCollisionEnter(Collision collision)
    {
        // もしcollisionがPaddleだとして衝突したら？
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Destroy(gameObject);
            collision.gameObject.transform.localScale -= new Vector3(Random.Range(0.2f, 1.0f), 0f, 0f);
            if (collision.gameObject.transform.localScale.x < 1.0f)
            {
                collision.gameObject.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
        }
    }
}
