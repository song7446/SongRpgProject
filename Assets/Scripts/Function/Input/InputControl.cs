using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    public static InputControl Instance
    {
        get
        {
            return instance;
        }
    }

    public static InputControl instance = null;

    public Vector2 MouseInput = Vector2.zero;
    public Vector2 MoveInput = Vector2.zero;

    public bool ShiftOn = false;

    private void Awake()
    {
        if (instance != null) 
        {
            if (instance != this) 
            { 
                Debug.LogError("Input Control is not Only : " + instance.gameObject.name);
            }
        }
        instance = this;
        
    }

    private void Update()
    {
        MoveInput.Set(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        MouseInput.Set(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ShiftOn = true;
        }
        else
        {
            ShiftOn = false;
        }
    }

}
