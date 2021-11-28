using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float delta;
    float generateTime;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.delta = 0.0f;
        this.generateTime = 1.0f;
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta >= generateTime) {
            this.delta = 0.0f;
            this.generateTime = Mathf.Pow((0.5f),(Score.score/10.0f));
            GameObject newArrow = Instantiate(arrowPrefab) as GameObject;
            float playerPosition = this.player.GetComponent<Transform>().position.x;
            float randomX = Random.Range(playerPosition - 1.0f, playerPosition + 1.0f);
            newArrow.transform.position = new Vector3(randomX, 7, 0);
        }
    }
}
