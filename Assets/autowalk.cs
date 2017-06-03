using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class autowalk : MonoBehaviour
{
    public float speed = 3.0F;
    public bool moveForward;

    private CharacterController controller;
    private Transform vrHead;

    void Start() {
        controller = GetComponent<CharacterController>();
        vrHead = Camera.main.transform;
    }
    void Update()
    {
        if(moveForward)
        {
            Vector3 dir = vrHead.TransformDirection(Vector3.forward);
            controller.SimpleMove(dir * speed);
        }        
    }
    public void setMoveForward()
    {
        if (moveForward) moveForward = false;
        else moveForward = true;
    }
}