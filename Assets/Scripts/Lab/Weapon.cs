using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] int damage;
    public int Damage { get { return damage; } set { damage = value; } }

    protected IShootable shooter;

    public abstract void OnHitWith(Character character);

    public abstract void Move();

    public void Init(int _damage, IShootable owner)
    {
        Damage = _damage;
        shooter = owner;
    }

    public int GetShootDirection()
    {
        float shootDir = shooter.BulletSpawnPoint.position.x - shooter.BulletSpawnPoint.parent.position.x;
        if (shootDir > 0)
        {
            return 1;
        }
        else { return -1; }
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith( other.GetComponent<Character>() );
    }
}
