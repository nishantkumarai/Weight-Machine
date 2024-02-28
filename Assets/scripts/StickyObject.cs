using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyObject : MonoBehaviour
{
    public string targetTag; // The tag of the target object
    public float stickDistance = 1.0f; // Distance at which the object sticks

    private FixedJoint fixedJoint;
    private GameObject targetObject;

    private void Start()
    {
        targetObject = GameObject.FindGameObjectWithTag(targetTag);
        if (targetObject != null)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.isKinematic = true;

            fixedJoint = gameObject.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = targetObject.GetComponent<Rigidbody>();
            fixedJoint.anchor = Vector3.zero;
            fixedJoint.connectedAnchor = Vector3.up * stickDistance;

            gameObject.layer = LayerMask.NameToLayer("StickyObject");
        }
    }

    private void Update()
    {
        if (fixedJoint != null && targetObject != null)
        {
            // Move the target along with the main object
            Vector3 targetPosition = transform.position + (transform.up * stickDistance);
            fixedJoint.connectedBody.transform.position = targetPosition;
        }
    }
}

