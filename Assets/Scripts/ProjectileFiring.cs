using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileFiring : MonoBehaviour
{
    public float PowerValue;
    public Sprite sp;
    private void Start()
    {
        
    }
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 halfScreenDimentions = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Vector3 mouseDirectionFromPlayer = mousePos - halfScreenDimentions;
        Debug.DrawRay(transform.position, mouseDirectionFromPlayer, Color.green);

        // get correct layer to put game object into
        int layer = LayerMask.NameToLayer("ProjectileLayer");

        if (Input.GetMouseButtonDown(0))
        {
            GameObject Projectile = new GameObject("Proj");
            Projectile.layer = layer;
            Projectile.AddComponent<Rigidbody2D>();
            Projectile.AddComponent<BoxCollider2D>();
            Projectile.AddComponent<SpriteRenderer>();
            Projectile.AddComponent<ProjectileBehavior>();
            Rigidbody2D rb = Projectile.GetComponent<Rigidbody2D>();
            // calculate max veloctiy in x and y direction
            Vector3 precentagePower = new Vector3(mouseDirectionFromPlayer.x / halfScreenDimentions.x, mouseDirectionFromPlayer.y / halfScreenDimentions.y, 0);
            Vector3 currPos = new Vector3(transform.position.x, transform.position.y + 0.1f, 0);
            Projectile.transform.position = currPos;
            rb.velocity = precentagePower * PowerValue;
            // make sprite correct
            SpriteRenderer sr = Projectile.GetComponent<SpriteRenderer>(); 
            sr.enabled = true;
            sr.sprite = sp;

        }
    }
}
