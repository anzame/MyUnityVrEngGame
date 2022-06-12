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
        Debug.Log("��������" + collision.gameObject.name);
        //���̕s�����̊ʂ��e�e�ɂ��������Ƃ�
        if (collision.gameObject.name == "bullet(Clone)")
        {
            Debug.Log("�͂�");

            //Cube�̉摜���o�c�ɂ���
            ChangeBatsuGazou();

            //�s�����̉���炷
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
