using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    float Smothing = 10f;
    Vector3 Offset;
    // Start is called before the first frame update
    void Start()
    {
        Offset = gameObject.transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, Player.transform.position +Offset, Smothing);
    }



}
