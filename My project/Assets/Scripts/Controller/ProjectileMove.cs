using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ProjectileMove : MonoBehaviour
{ 
    public enum PROJECTILETYPE
{
        PLAYER,
        ENEMY
}


    public Vector3 launchDirection;
    internal PROJECTILETYPE projectileType;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Wall")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Mpnster_Damaged(1);
            Destroy(this.gameObject);
        }

    }

    private void OnTrigerEnter(Collision other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Monster")
        {
            other.gameObject.GetComponent<MonsterController>().Mpnster_Damaged(1);
            other.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1);
            Destroy(this.gameObject);
        }

    }

        private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);
    }
}
