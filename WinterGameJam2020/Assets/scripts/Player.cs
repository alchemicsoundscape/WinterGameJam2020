using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Torso torso;
    public Head head;
    public Arm armOne;
    public Arm armTwo;

    public Leg legOne;
    public Leg legTwo;
    List<BodyPart> bodyParts;

    // Start is called before the first frame update
    void Start()
    {
        bodyParts = new List<BodyPart>();
        bodyParts.Add(armOne);
        bodyParts.Add(armTwo);
        bodyParts.Add(legOne);
        bodyParts.Add(legTwo);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(var part in bodyParts)
        {
            if(part.IsPressed(part.inputButton))
            {
                part.MovePart();
            }
            else
            {
                torso.MovePart();
                head.MovePart();
            }
        }
    }
}
