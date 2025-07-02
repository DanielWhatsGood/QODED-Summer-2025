using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseController : MonoBehaviour
{

    [SerializeField] Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = GameObject.FindGameObjectWithTag("cheesewedge").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPosition()
    {
        transform.position = originalPosition;
    }
}
