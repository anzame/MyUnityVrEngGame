using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScene : MonoBehaviour
{
    public Material MaruGazou;
    public GameObject ChangeBoardImage;

    private bool ColJudge = false; /*一度だけOnCollisionEnterを呼び出すためのフラグ*/
    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("あたった" + collision.gameObject.name);
        //この正解の缶が銃弾にあたったとき
        if (collision.gameObject.name == "bullet(Clone)" && ColJudge == false)
        {
            ColJudge = true;
            Debug.Log("はい");

            //Cubeの画像を丸にする
            ChangeMaruGazou();

            //正解の音を鳴らす
            GetComponent<AudioSource>().Play();
            
            CreateQBorad1.GameScore += 1; //スコアを1点プラス
            Invoke("GameClear", 2.0f);
        }
    }
    private void GameClear()
    {
        SceneManager.LoadScene("ClearScene");
    }
    
    void ChangeMaruGazou()
    {
        ChangeBoardImage.GetComponent<Renderer>().material = MaruGazou;
    }
}
