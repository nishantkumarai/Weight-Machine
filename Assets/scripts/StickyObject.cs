using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyObject : MonoBehaviour
{
    public string targetTag; // The tag of the objects to stick to
    public float stickDistance = 1.0f; // Distance at which the object sticks

    private void Update()
    {
        StickToObjectsWithTag();
    }

    private void StickToObjectsWithTag()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag(targetTag);

        foreach (GameObject target in targets)
        {
            Vector3 targetPosition = target.transform.position + (target.transform.up * stickDistance);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f);
        }
    }
}

