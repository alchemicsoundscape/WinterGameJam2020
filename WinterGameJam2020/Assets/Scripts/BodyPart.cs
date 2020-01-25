using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    public Sprite image;
    public string inputButton;
    // Start is called before the first frame update
    public bool IsPressed(string inputButton)
    {
        if(Input.GetButton(inputButton)) return true;
        return false;
    }

    public void MovePart(Vector3 position)
    {
        Vector2 distance = Camera.main.ScreenToWorldPoint(position) - transform.position;
        
        float sign = (Camera.main.ScreenToWorldPoint(position).y < transform.position.y)? -1.0f : 1.0f;
        // Debug.Log(Vector2.Angle(gameObject.transform.position, Camera.main.ScreenToWorldPoint(position)));
        // Debug.Log(Camera.main.ScreenToWorldPoint(position));
        // Debug.Log("bodyPart position: " + gameObject.transform.position);
        var finalRotation = Vector2.Angle(Vector2.right, distance) * sign;
        switch(gameObject.name)
        {
            case "RArm":
                finalRotation += 180;
                break;
            case "RLeg":
                finalRotation += 90;
                break;
            case "LLeg":
                finalRotation += 90;
                break;
        }
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, finalRotation);
        // Debug.Log(Vector2.Distance(Camera.main.ScreenToWorldPoint(position), gameObject.transform.position));
        // Debug.Log("moving " + this.name);
    }
}
