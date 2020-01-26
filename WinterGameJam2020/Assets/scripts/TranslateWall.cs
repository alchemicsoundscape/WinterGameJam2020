using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateWall : MonoBehaviour
{
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wall.transform.Translate(new Vector3(0,-.005f,0));
        if(wall.transform.localScale.x > 0.1743818f)
        {
            if(wall.activeInHierarchy)
                wall.SetActive(false);
            return;
        }
        wall.transform.localScale = new Vector3(wall.transform.localScale.x+.0003f,wall.transform.localScale.y+.0003f, wall.transform.localScale.z+.0003f);
    }
}
