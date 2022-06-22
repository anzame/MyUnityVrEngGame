using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LimitTimeUIController17 : MonoBehaviour
{
    public int countdownMinutes = 3;
    public Material BatsuGazou;
    private float countdownSeconds;
    private TextMesh timeText;
    public GameObject ChangeBoardImage;
    Vector3 Pos = new Vector3(-0.1f, 1.83f, 20.0f);
    private bool TOverJudge = false; /*制限時間終了時に一度だけ呼び出すためのフラグ*/

    private void Start()
    {
        timeText = GetComponent<TextMesh>();
        countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");

        if (countdownSeconds <= 0 && TOverJudge == false)
        {
            TOverJudge = true;
            // 0秒になったときの処理
            //Cubeの画像をバツにする
            ChangeBatsuGazou();

            //不正解の音を鳴らす
            GetComponent<AudioSource>().Play();
            Invoke("MakeNextBoard", 2.0f);
        }
    }

    void MakeNextBoard()
    {
        GameObject OldPrehab = GameObject.Find("QuestionBoard17(Clone)");
        GameObject NextPrehab = (GameObject)Resources.Load("QuestionBoard18");

        Destroy(OldPrehab);
        Instantiate(NextPrehab, Pos, Quaternion.identity);
    }

    void ChangeBatsuGazou()
    {
        ChangeBoardImage.GetComponent<Renderer>().material = BatsuGazou;
    }
}
