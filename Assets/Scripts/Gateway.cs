using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gateway : MonoBehaviour
{
    public Vector3 playerOffset;
    public Gateways GatewaysInfoRef;
    public int MoveToRoom;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GatewaysInfoRef.EnterRoom(MoveToRoom);
            collision.transform.position += playerOffset;
        }
    }
}
