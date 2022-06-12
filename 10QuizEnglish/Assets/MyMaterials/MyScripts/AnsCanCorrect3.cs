using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnsCanCorrect3 : MonoBehaviour
{
    public Material MaruGazou;
    public GameObject ChangeBoardImage;

    private bool ColJudge = false; /*��x����OnCollisionEnter���Ăяo�����߂̃t���O*/
    Vector3 Pos = new Vector3(-0.1f, 1.83f, 20.0f);

    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("��������" + collision.gameObject.name);
        //���̐����̊ʂ��e�e�ɂ��������Ƃ�
        if (collision.gameObject.name == "bullet(Clone)" && ColJudge == false)
        {
            ColJudge = true;
            CreateQBorad1.GameScore += 1; //�X�R�A��1�_�v���X
            Debug.Log(CreateQBorad1.GameScore);

            //Cube�̉摜���ۂɂ���
            ChangeMaruGazou();

            //�����̉���炷
            GetComponent<AudioSource>().Play();

            //��b��Ɏ��̖����Ăяo��
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
