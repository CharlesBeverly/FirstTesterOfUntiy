using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFiring : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 halfScreenDimentions = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Vector3 mouseDirectionFromPlayer = mousePos - halfScreenDimentions;
        Debug.DrawRay(transform.position, mouseDirectionFromPlayer, Color.green);
        Debug.Log(halfScreenDimentions);
        Debug.Log(mouseDirectionFromPlayer);
    }
}
