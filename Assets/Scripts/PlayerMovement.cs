using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [Range(0, 100)]
    public float Speed;
    private Vector2 movement = new Vector2(1, 1);
    [SerializeField]
    public GameObject Player;

    public string movementAxis = "Horizontal";
    public string jumpAxis = "Jump";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float axis = Input.GetAxis(movementAxis);

        Player.transform.Translate(new Vector2(axis * Speed * Time.deltaTime, 0));

        float jumping = Input.GetAxis(jumpAxis);

        Player.transform.Translate(new Vector2(0, jumping * 260 * Time.deltaTime));

    }
    private void FixedUpdate()
    {
        
    }
}
