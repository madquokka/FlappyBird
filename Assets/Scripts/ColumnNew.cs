using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnNew : MonoBehaviour
{
    //게임컨트롤 오브젝트
    public GameControlNew gameControl;

    //Rigdbody 컴포넌트
    Rigidbody2D rb2D;


    // Start is called before the first frame update
    void Start()
    {
        //게임컨트롤을 찾아서 넣어준다.
        gameControl = FindObjectOfType<GameControlNew>();

        //Rigdbody 컴포넌트를 가져와서 세팅한다.
        rb2D = GetComponent<Rigidbody2D>();

        //Rigdbody 컴포넌트의 속도 세팅한다.
        rb2D.velocity = new Vector2(-2, 0);
    }

    // Update is called once per frame 
    void Update()
    {
        //게임오버가 되면 배경스크롤링 멈춤
      if(gameControl.gameOver == true)
        {
            //속도를 0으로준다.
            rb2D.velocity = Vector2.zero;
        }
    }

    //트리거에 무엇인가 들어오면 발동되는 함수
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Bird일때만 동작
        if (collision.GetComponent<Bird>() !=null)
        {
            //게임 컨트롤의 스코어 함수를 호출한다.
            gameControl.BirdScored();
        }
    }
}
