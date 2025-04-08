using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void ClickBtn()
    {
        AdManager.ShowVideoAd("8bapdjk180c396e080",
            (bol) => {
                if (bol)
                {
                    LifeMinus.instance.ResetLives(3);
                    ClosePanel();

                    AdManager.clickid = "";
                    AdManager.getClickid();
                    AdManager.apiSend("game_addiction", AdManager.clickid);
                    AdManager.apiSend("lt_roi", AdManager.clickid);


                }
                else
                {
                    StarkSDKSpace.AndroidUIManager.ShowToast("�ۿ�������Ƶ���ܻ�ȡ����Ŷ��");
                }
            },
            (it, str) => {
                Debug.LogError("Error->" + str);
                //AndroidUIManager.ShowToast("�������쳣�������¿���棡");
            });

    }

    public void ClickNO()
    {
        ClosePanel();
        GameObject.FindGameObjectWithTag("GameController").SendMessage("GameOver");
    }

    public void ClosePanel()
    {
        GameObject.FindGameObjectWithTag("GameController").SendMessage("SetRevivePanel", false);
    }

}
