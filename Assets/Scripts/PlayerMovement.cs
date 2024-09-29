using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float limitPlayerPosY;
    [SerializeField] private bool isPlayer1;

    private Vector3 playerPos;

    private void Start()
    {

    }

    

    private void Update()
    {
        MovePlayers();
    }



    private void MovePlayers()
    {
        Vector2 moveUp = Vector2.up * speed * Time.deltaTime;
        Vector2 moveDown = Vector2.down * speed * Time.deltaTime;
        playerPos = transform.position;

        transform.position = new Vector2(playerPos.x, Mathf.Clamp(playerPos.y, -limitPlayerPosY, limitPlayerPosY));

        if (isPlayer1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(moveUp);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(moveDown);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(moveUp);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(moveDown);
            }
        }
    }
}
