using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToObject : MonoBehaviour
{
    public string targetTag; // The tag of the object to stick to
    private bool isStuck = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isStuck && collision.gameObject.CompareTag(targetTag))
        {
            Transform hitTransform = collision.transform;
            transform.SetParent(hitTransform);

            isStuck = true;
        }
    }
}