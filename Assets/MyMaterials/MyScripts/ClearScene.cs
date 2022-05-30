using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScene : MonoBehaviour
{
    public Material MaruGazou;
    public GameObject ChangeBoardImage;

    private bool ColJudge = false; /*��x����OnCollisionEnter���Ăяo�����߂̃t���O*/
    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("��������" + collision.gameObject.name);
        //���̐����̊ʂ��e�e�ɂ��������Ƃ�
        if (collision.gameObject.name == "bullet(Clone)" && ColJudge == false)
        {
            ColJudge = true;
            Debug.Log("�͂�");

            //Cube�̉摜���ۂɂ���
            ChangeMaruGazou();

            //�����̉���炷
            GetComponent<AudioSource>().Play();
            
            CreateQBorad1.GameScore += 1; //�X�R�A��1�_�v���X
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
