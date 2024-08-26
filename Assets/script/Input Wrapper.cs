using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputWrapper : MonoBehaviour
{
    [SerializeField] 
    private float speed;
    private PlayerInput inputs;
    private InputAction jumpAction;
    private InputAction movementAction;


    // Start is called before the first frame update
    void Start()
    {
      inputs = GetComponent<PlayerInput>();  
      jumpAction = inputs.actions["Jump"]; 
      movementAction = inputs.actions["Walk"]; 
      Debug.Log(inputs); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public float GetMovement()
  {
    return movementAction.ReadValue<float>();
  }
}

