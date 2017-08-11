using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenIGTLinkFlag : MonoBehaviour {
    public bool ReceiveTransform = false;
    public bool SendTransform = false;
    public bool SendPoint = false;

    private Vector3 lastPosition;
    private bool movedPosition;

    private void Start()
    {
        lastPosition = transform.localPosition;
    }

    void Update()
    {
        if (Mathf.Abs(lastPosition.x - transform.localPosition.x) > 0.000001 | Mathf.Abs(lastPosition.y - transform.localPosition.y) > 0.000001 | Mathf.Abs(lastPosition.z - transform.localPosition.z) > 0.000001)
        {
            movedPosition = true;
            lastPosition = transform.localPosition;
        }
        else
        {
            movedPosition = false;
        }
    }

    public bool GetMovedPosition()
    {
        return movedPosition;
    }
}
