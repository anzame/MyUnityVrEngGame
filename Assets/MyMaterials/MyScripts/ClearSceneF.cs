using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearSceneF : MonoBehaviour
{
    public Material BatsuGazou;
    public GameObject ChangeBoardImage;
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
            Invoke("GameClear", 2.0f);
        }
    }
    private void GameClear()
    {
        SceneManager.LoadScene("ClearScene");
    }

    void ChangeBatsuGazou()
    {
        ChangeBoardImage.GetComponent<Renderer>().material = BatsuGazou;
    }
}
