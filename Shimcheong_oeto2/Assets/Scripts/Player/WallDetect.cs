using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetect : MonoBehaviour
{
    //�÷��̾� ��ũ��Ʈ
    public Controller playerControlScr;

    //�÷��̾��� �̵����� Flag
    [SerializeField]
    public bool moveStop;

    //Player�� Horizontal��
    [SerializeField]
    private float int_HorizontalValue;

    //���� Ż���ϱ����� �������ϴ� Ű�� x�� ��
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

    //���̶� �浹�������
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�浹��");

        //���� �÷��̾�� �浹�������
        if (int_HorizontalValue != direction && collision.CompareTag("Player"))
        {
            moveStop = true;
            playerControlScr.detectWall = moveStop;
        }
    }

    //���̶� �浹���ϰ��
    private void OnTriggerStay2D(Collider2D collision)
    {
        //���� �÷��̾�� �浹�������
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
