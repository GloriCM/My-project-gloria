using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField]
    public InputWrapper inputs;
    public Rigidbody rb;
    public Vector3 Direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        inputs = GetComponent<InputWrapper>(); 
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Direction.x = inputs.GetMovement();
        Direction = Direction.normalized*speed*Time.deltaTime;
        transform.position += Direction;
        Debug.Log(inputs.GetMovement());
        
    }
    
}
