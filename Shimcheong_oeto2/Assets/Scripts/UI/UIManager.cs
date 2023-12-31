using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //아이템창 인터페이스 오브젝트
    public GameObject gameObject_ItemWindow;
    //지도 오브젝트
    public GameObject gameObject_MapWindow;

    //아이템 창이 실행중인지 확인하는 flag
    public bool isItemWindowLaunch;
    //지도가 실행중인지 확인 하는 flag
    public bool isMapWindowLaunch;

    // Update is called once per frame
    void Update()
    {
        //아이템 창 관련 코드
        #region
        //아이템 창 비활성화 상태에서 X키를 누를 경우
        if (Input.GetKeyDown(KeyCode.X) && !gameObject_ItemWindow.activeSelf && !isMapWindowLaunch)
        {
            //아이템 창 실행
            ItemWindowLaunch();
        }
        
        //아이템 창 활성화 상태에서 X키 or ESC를 누를 경우
        else if((Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Escape)) && gameObject_ItemWindow.activeSelf)
        {
            //아이템 창 종료
            ItemWindowExit();
        }

        //아이템 창이 실행중일 경우
        if(gameObject_ItemWindow.activeSelf)
        {
            isItemWindowLaunch = true;
        }
        
        //아이템 창이 비활성화일 경우
        else if(!gameObject_ItemWindow.activeSelf)
        {
            isItemWindowLaunch = false;
        }
        #endregion

        //맵 관련 고드
        #region
        //지도가 실행중이 아닌데 M키를 눌렀을 경우
        if (Input.GetKeyDown(KeyCode.M) && !gameObject_MapWindow.activeSelf && !isItemWindowLaunch)
        {
            //지도 오브젝트 활성화
            gameObject_MapWindow.SetActive(true);
        }    

        //지도가 실행중인데 M키 or ESC키를 눌렀을경우
        else if((Input.GetKeyDown(KeyCode.M) || Input.GetKeyDown(KeyCode.Escape)) && gameObject_MapWindow.activeSelf)
        {
            //지도 오브젝트 비활성화
            gameObject_MapWindow.SetActive(false);
        }

        //지도가 실행중일 경우
        if(gameObject_MapWindow.activeSelf)
        {
            isMapWindowLaunch = true;
        }
        //지도가 실행중이 아닐경우
        else if(!gameObject_MapWindow.activeSelf)
        {
            isMapWindowLaunch = false;
        }
        #endregion
    }

    //아이템 창 실행
    public void ItemWindowLaunch()
    {
        //아이템 창 오브젝트 활성화
        gameObject_ItemWindow.SetActive(true);
    }

    //아이템 창 종료
    public void ItemWindowExit()
    {
        //아이템 창 오브젝트 비활성화
        gameObject_ItemWindow.SetActive(false);
    }   

    //지도 켜기
    public void MapWindowLaunch()
    {
        gameObject_MapWindow.SetActive(true);
    }

    //지도 끄기
    public void MapWindowExit()
    {
        gameObject_MapWindow.SetActive(false);
    }
}
