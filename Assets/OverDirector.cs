using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OverDirector : MonoBehaviour
{
    GameObject Second;
    // Start is called before the first frame update
    void Start()
    {
        this.Second = GameObject.Find("Second");
        this.Second.GetComponent<Text>().text = Score.score.ToString("F2") + "s";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) SceneManager.LoadScene("GameScene");
    }
}
