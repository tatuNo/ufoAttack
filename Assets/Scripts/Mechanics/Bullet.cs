using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public LayerMask whatIsSolid;
    public int damage;

    private void Start()
    {
        Invoke("DestroyProjectile", lifetime);
    }
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsSolid);

        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                Debug.Log("Enemy must take damage");
                hitInfo.collider.GetComponent<Enemy>().takeDamage(damage);
            }
            DestroyProjectile();
        }

        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    void DestroyProjectile ()
    {
        Destroy(gameObject);
    }
}
