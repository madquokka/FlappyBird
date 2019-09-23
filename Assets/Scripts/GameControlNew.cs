using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControlNew : MonoBehaviour
{
    //게임오버 UI
    public GameObject gameOverUI;
    //스코어 텍스트 UI
    public Text scoreText;


    public bool gameOver = false;

    int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //게임오버가 되면
        if(gameOver == true)
        {
            //마우스 클릭하면(화면을 터치하면)
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(0);
            }
        }

        //새의 죽음을 처리하는 함수

    }
    public void BirdDied()
    {
        //게임오버 UI를 표시한다.
        gameOverUI.SetActive(true);

        //게임오버 플래그를 true로 설정한다.
        gameOver = true;

    }

    //스코어를 증가하는 함수
    public void BirdScored()
    {
        score = score + 1;

        //화면 스코어 UI에 표시
        scoreText.text = "Score : " + score.ToString();

    }
}
