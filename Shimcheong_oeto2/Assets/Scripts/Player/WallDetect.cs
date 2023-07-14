using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetect : MonoBehaviour
{
    //플레이어 스크립트
    public Controller playerControlScr;

    //플레이어의 이동정지 Flag
    [SerializeField]
    public bool moveStop;

    //Player의 Horizontal값
    [SerializeField]
    private float int_HorizontalValue;

    //벽을 탈출하기위해 눌러야하는 키의 x축 값
    public int direction;

    private void Update()
    {
        if (Input.GetButtonDown("Horizontal"))
        {
            int_HorizontalValue = Input.GetAxisRaw("Horizontal");

            if (int_HorizontalValue == direction)
            {
                moveStop = false;
                playerControlScr.detectWall = moveStop;
            }
        }
    }

    //벽이랑 충돌했을경우
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌중");

        //만약 플레이어랑 충돌했을경우
        if (int_HorizontalValue != direction && collision.CompareTag("Player"))
        {
            moveStop = true;
            playerControlScr.detectWall = moveStop;
        }
    }

    //벽이랑 충돌중일경우
    private void OnTriggerStay2D(Collider2D collision)
    {
        //만약 플레이어랑 충돌했을경우
        if (int_HorizontalValue != direction && collision.CompareTag("Player"))
        {
            moveStop = true;
            playerControlScr.detectWall = moveStop;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        moveStop = false;
        playerControlScr.detectWall = moveStop;
    }
}
