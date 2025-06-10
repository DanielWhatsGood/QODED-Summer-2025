using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    [SerializeField] Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = GameObject.FindGameObjectWithTag("cube").transform.position;
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
