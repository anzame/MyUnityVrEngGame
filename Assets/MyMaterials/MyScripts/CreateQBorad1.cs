using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateQBorad1 : MonoBehaviour
{
    public GameObject QuesBoardPrehab;
    public static int GameScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 Pos = new Vector3(-0.1f, 1.83f, 20.0f);
        Instantiate(QuesBoardPrehab, Pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
