using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonManager : MonoBehaviour
{
    //ボタンを押された回数を格納する変数
    int buttonScore;

    //プッシュオブジェクトを格納する変数
    public GameObject PushScore;


    public void PushButton()
    {
        countPushButton();
    }

    //ボタンを押された回数を計測する関数
    void countPushButton()
    {
        buttonScore++;

        //押した回数を表示
        PushText.GetCom
    }
}
