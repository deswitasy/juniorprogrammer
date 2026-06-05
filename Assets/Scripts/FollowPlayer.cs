using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0f, 6f, -9f);
    private bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            if(toggle)
            {
                offset = new Vector3(0f, 6f, -9f);
            }else
            {
                offset = new Vector3(0f, 2.22f, 0.7f);
            }
            toggle = !toggle;
        }
        transform.position = player.transform.position + offset;
    }
}
