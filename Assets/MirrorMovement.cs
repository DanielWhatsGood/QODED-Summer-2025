using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMovement : MonoBehaviour
{
    public Transform playerTarget;
    public Transform mirror;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTarget != null)
        {
            Vector3 localPlayer = mirror.InverseTransformDirection(playerTarget.position);
            transform.position = mirror.TransformPoint(new Vector3(localPlayer.x, localPlayer.y, localPlayer.z));

            Vector3 lookAtMirror = mirror.TransformPoint(new Vector3(-localPlayer.x, localPlayer.y, localPlayer.z));
            transform.LookAt(lookAtMirror);
        }
    }
}
