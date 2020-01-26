using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.IK;
public class BodyPart : MonoBehaviour
{
    public LimbSolver2D target;
    public string inputButton;
    // Start is called before the first frame update
    public bool IsPressed(string inputButton)
    {
        if(Input.GetButton(inputButton)) return true;
        return false;
    }

    public void MovePart()
    {
        target.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
