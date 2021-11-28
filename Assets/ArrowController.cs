using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    float speed;
    GameObject player, gameDirector, hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0f;
        this.player = GameObject.Find("player");
        this.gameDirector = GameObject.Find("GameDirector");
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        speed -= 0.005f;
        this.GetComponent<Transform>().position += new Vector3(0, speed, 0);

        if (this.GetComponent<Transform>().position.y < -5.0f) Destroy(gameObject);

        float distance = (this.GetComponent<Transform>().position - this.player.GetComponent<Transform>().position).magnitude;

        if (distance <= 1.5f){
            this.gameDirector.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);
        }
    }
}
