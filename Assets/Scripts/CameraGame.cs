using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGame : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float smoothing;
    public Vector2 minPosition;
    public Vector2 maxPosition;
    void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);
            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        }
    }
}
