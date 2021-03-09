using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactoryScript : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        //ballインスタンスを位置と回転を指定して生成
        // Instantiate(ball, transform.position, transform.rotation);
        //一定時間繰り返す(0秒後から１秒後まで)
        InvokeRepeating("SpawnBall",0f,1f);
    }

    void SpawnBall()
    {
        //横軸で-5f, 5fの間で移動して発射される
        Instantiate(ball, new Vector3(Random.Range(-5f, 5f),transform.position.y,transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //todo
    }
}
