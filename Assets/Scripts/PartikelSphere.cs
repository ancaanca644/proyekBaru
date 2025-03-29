using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class PartikelSphere : MonoBehaviour
{
    private float moveSpeed;
    public float minMoveSpeed = 1;
    public float maxMoveSpeed = 5;

    private void Start()
    {
        moveSpeed = Random.Range(minMoveSpeed, maxMoveSpeed);
    }

    private void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("plat"))
        {
            LeanPool.Despawn(gameObject);
        }
    }
}