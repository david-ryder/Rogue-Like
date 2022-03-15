using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhancedPlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform player;

    // Update is called once per frame
    void Update()
    {
        // Move up
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.transform.position = new Vector3(player.position.x, player.position.y + 1);
        }

        // Move left
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position = new Vector3(player.position.x - 1, player.position.y);
        }

        // Move right
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position = new Vector3(player.position.x + 1, player.position.y);
        }

        // Move down
        if (Input.GetKeyDown(KeyCode.S))
        {
            player.transform.position = new Vector3(player.position.x, player.position.y - 1);
        }

        // Move up right
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position = new Vector3(player.position.x + 1, player.position.y + 1);
        }

        // Move down right
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position = new Vector3(player.position.x + 1, player.position.y - 1);
        }

        // Move down left
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position = new Vector3(player.position.x - 1, player.position.y - 1);
        }

        // Move up left
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position = new Vector3(player.position.x - 1, player.position.y + 1);
        }
    }
}
