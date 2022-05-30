using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolController : MonoBehaviour
{
    public GameObject bullet, bulletPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pistolShot() 
    {
        Instantiate(bullet, bulletPosition.transform.position, transform.rotation);
        //å¯â âπçƒê∂
        GetComponent<AudioSource>().Play();
    }
}
