using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeScript : MonoBehaviour
{

    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1f, 100*Time.deltaTime*1f, 0f));
        transform.Translate(new Vector3(speed, 0f, 0f));
        Debug.Log(speed);
    }
}
