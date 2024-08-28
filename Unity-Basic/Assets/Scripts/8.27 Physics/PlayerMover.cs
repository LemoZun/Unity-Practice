using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] Vector3 destination;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed*Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, destination, moveSpeed * Time.deltaTime);

    }

    public void Move(Vector3 destination)
    {
        this.destination = destination;
    }
}
