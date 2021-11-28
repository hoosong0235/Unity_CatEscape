using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject dashCoolTime;
    GameObject Second;
    GameObject hpGauge;
    // Start is called before the first frame update
    void Start()
    {
        Score.score = 0.0f;
        this.dashCoolTime = GameObject.Find("DashCoolTime");
        this.hpGauge = GameObject.Find("hpGauge");
        this.Second = GameObject.Find("Second");
    }

    // Update is called once per frame
    void Update()
    {
        Score.score += Time.deltaTime;
        this.Second.GetComponent<Text>().text = Score.score.ToString("F2") + "s";
        this.dashCoolTime.GetComponent<Image>().fillAmount = 1.0f - DashCoolTime.dashCoolTime * 1.0f;
    }

    public void DecreaseHp(){
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        if (this.hpGauge.GetComponent<Image>().fillAmount == 0.0f) SceneManager.LoadScene("OverScene");
    }
}
