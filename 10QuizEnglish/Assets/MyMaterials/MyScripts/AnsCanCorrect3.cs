using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnsCanCorrect3 : MonoBehaviour
{
    public Material MaruGazou;
    public GameObject ChangeBoardImage;

    private bool ColJudge = false; /*一度だけOnCollisionEnterを呼び出すためのフラグ*/
    Vector3 Pos = new Vector3(-0.1f, 1.83f, 20.0f);

    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("あたった" + collision.gameObject.name);
        //この正解の缶が銃弾にあたったとき
        if (collision.gameObject.name == "bullet(Clone)" && ColJudge == false)
        {
            ColJudge = true;
            CreateQBorad1.GameScore += 1; //スコアを1点プラス
            Debug.Log(CreateQBorad1.GameScore);

            //Cubeの画像を丸にする
            ChangeMaruGazou();

            //正解の音を鳴らす
            GetComponent<AudioSource>().Play();

            //二秒後に次の問題を呼び出す
            Invoke("MakeNextBoard", 2.0f);
        }
    }

    void MakeNextBoard()
    {
        GameObject OldPrehab = GameObject.Find("QuestionBoard4(Clone)");
        GameObject NextPrehab = (GameObject)Resources.Load("QuestionBoard5");

        Destroy(OldPrehab);
        Instantiate(NextPrehab, Pos, Quaternion.identity);
    }

    void ChangeMaruGazou()
    {
        ChangeBoardImage.GetComponent<Renderer>().material = MaruGazou;
    }

}
