using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    Rigidbody2D rb2d;
    Vector2 force;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Damage = 20;
        force = new Vector2 (GetShootDirection() * 5, 10);
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Move()
    {
        rb2d.AddForce (force);
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
    }
}
