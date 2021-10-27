using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        //transform.Translate(speedPlayer * Time.deltaTime * new Vector3(horizontal, vertical, 0));
        transform.position += new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
    }

}
