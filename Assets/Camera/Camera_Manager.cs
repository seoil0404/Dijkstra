using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Manager : MonoBehaviour
{
    public Vector3 position;
    public float speed;

    private void Awake()
    {
        position = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(position.x, position.y, transform.position.z), speed);
    }
}
