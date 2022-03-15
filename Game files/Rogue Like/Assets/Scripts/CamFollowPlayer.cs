using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    [SerializeField] private Camera mainCam;

    [SerializeField] private Transform player;

    void Start()
    {
        mainCam.transform.position = new Vector3(player.position.x, player.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        mainCam.transform.position = new Vector3(player.position.x, player.position.y, -10);
    }
}
