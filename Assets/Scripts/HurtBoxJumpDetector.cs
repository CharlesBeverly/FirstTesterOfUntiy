using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HurtBoxJumpDetector : MonoBehaviour
{
    BoxCollider2D HurtBox;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        HurtBox = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        transform.position = player.transform.position;
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<Player_Movement>().can_jump = true;
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        player.GetComponent<Player_Movement>().can_jump = true;
        UnityEngine.Debug.Log("In Contact");
    }
    void OnTriggerExit(Collider other)
    {
        player.GetComponent<Player_Movement>().can_jump = false;
    }

}
