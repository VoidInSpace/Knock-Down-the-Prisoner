using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public LayerMask layers;
    private Collider2D target;

    public float bulletForce = 20f;
    public float radius = 3f;
    public float fireRate = 1f;
    public float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        nextFire = Time.time;
    } 

    // Update is called once per frame
    void Update()
    {
        CheckEnvironment();
        LookAtTarget();
        CheckIfTimeToFire();
    }

    private void CheckEnvironment()
    {
        target = Physics2D.OverlapCircle(transform.position, radius, layers);

        if (target != null)Debug.Log(target.gameObject.name);
    }

    private void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Shoot();
        }
    }

    private void LookAtTarget()
    {
        if (target != null)
        {
            Vector3 direction = target.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    private void Shoot()
    {
        if (target != null)
        {
            GameObject enemyBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = enemyBullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

            nextFire = Time.time + fireRate / 5;
        }
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
