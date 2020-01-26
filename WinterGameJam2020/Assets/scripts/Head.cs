using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : BodyPart
{

    public void MovePart()
    {
        if(Input.GetButton("Head"))
        {
            Debug.Log("detected");
            Vector2 distance = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            
            float sign = (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < transform.position.y)? -1.0f : 1.0f;
        
            var finalRotation = Vector2.Angle(Vector2.right, distance) * sign;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, finalRotation);
        }
    }
}
