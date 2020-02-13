using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public static float offsetX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdScript.instance != null)
        {
            if (BirdScript.instance.isAlive)
                MoveTheCamera();
                
        }
        
    }

    void MoveTheCamera()
    {
        Vector3 tmp = transform.position;
        tmp.x = BirdScript.instance.GetPositionX() + offsetX;
        transform.position = tmp;
    }
}
