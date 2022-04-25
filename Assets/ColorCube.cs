using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

[RequireComponent(typeof(Interactable))]
public class ColorCube : MonoBehaviour
{
    Material mat;

    //this is the button you will press on your controller
    //it is an abstract button that will work on any controller
    public SteamVR_Action_Boolean colorAction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("default", "InteractUI");

    private Interactable interactable;  //the interactable component knows when it's been picked up
    private SteamVR_Input_Sources hand; //the contoller picked up this component

    // Start is called before the first frame update
    void Start()
    {
        mat = this.GetComponent<Renderer>().material;
        interactable = this.GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(interactable.attachedToHand)
        {
            hand = interactable.attachedToHand.handType;
        }
        if(colorAction[hand].stateDown)
        {
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        mat.color = Random.ColorHSV();  //this changes color once per frame
    }
}
