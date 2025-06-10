using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterTakeoffScript : MonoBehaviour
{

    [SerializeField] private float takeoffSpeed = 0.1f;
    [SerializeField] private float takeoffDelay;

    [SerializeField] private float cruisingSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, takeoffSpeed, 0f));

    }
}
