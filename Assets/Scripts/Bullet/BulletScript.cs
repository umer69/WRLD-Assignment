using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float bulletspeed;
    [SerializeField] private Transform target;

    public Transform Target { get => target; set => target = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        transform.LookAt(target.position);
        transform.position += transform.forward * bulletspeed * Time.deltaTime;


    }
}
