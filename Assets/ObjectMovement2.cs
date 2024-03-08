using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement2 : MonoBehaviour
{
    public float speed = 1.0f;
    public float length = 1.0f;

    private float runTime = 0.0f;
    private float posY = 0.0f;

    void Update()
    {
        runTime += Time.deltaTime * speed;
        posY = Mathf.Sin(runTime) * length;
        Debug.Log(posY);
        transform.position = new Vector3(0, posY);
    }
}
