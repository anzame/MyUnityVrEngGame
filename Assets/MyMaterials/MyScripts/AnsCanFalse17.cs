using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnsCanFalse17 : MonoBehaviour
{
    public Material BatsuGazou;
    public GameObject ChangeBoardImage;
    Vector3 Pos = new Vector3(-0.1f, 1.83f, 20.0f);

    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("あたった" + collision.gameObject.name);
        //この不正解の缶が銃弾にあたったとき
        if (collision.gameObject.name == "bullet(Clone)")
        {
            Debug.Log("はい");

            //Cubeの画像をバツにする
            ChangeBatsuGazou();

            //不正解の音を鳴らす
            GetComponent<AudioSource>().Play();
            Invoke("MakeNextBoard", 2.0f);
        }
    }

    void MakeNextBoard()
    {
        GameObject OldPrehab = GameObject.Find("QuestionBoard18(Clone)");
        GameObject NextPrehab = (GameObject)Resources.Load("QuestionBoard19");

        Destroy(OldPrehab);
        Instantiate(NextPrehab, Pos, Quaternion.identity);
    }

    void ChangeBatsuGazou()
    {
        ChangeBoardImage.GetComponent<Renderer>().material = BatsuGazou;
    }

}
