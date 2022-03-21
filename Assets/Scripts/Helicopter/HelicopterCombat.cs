using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterCombat : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject target;
    [SerializeField] private float bulletForce;
    private Vector3 hitPoint;

    private void Start()
    {
        GetTarget();
    }

    private void GetTarget()
    {
        hitPoint = target.transform.position - transform.position;
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        BulletScript bulletScript = bullet.GetComponent<BulletScript>();
        bulletScript.Target = target.transform;


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
