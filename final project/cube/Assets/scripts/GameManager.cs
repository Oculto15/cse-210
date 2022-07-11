using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject bird;
    public Transform spawnPoint;
    int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject PlayButton;
    public GameObject player;
    public GameObject GameTittle;
    public GameObject Score;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacles(){
        while(true){
            float waitTime = Random.Range(0.5f , 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);
        }
    }

    IEnumerator SpawnBirds(){
        while(true){
            float waitTime = Random.Range(0.5f , 1f);

            yield return new WaitForSeconds(waitTime);
            Instantiate(bird, spawnPoint.position, Quaternion.identity);
        }
    }



    void ScoreUp(){
        score++;
        scoreText.text = score.ToString();
    }

    public void GameStart(){
        Score.SetActive(true);
        player.SetActive(true);
        PlayButton.SetActive(false);
        GameTittle.SetActive(false);
        StartCoroutine("SpawnBirds");
        StartCoroutine("SpawnObstacles");
        InvokeRepeating("ScoreUp", 2f , 1f);
    }


}
