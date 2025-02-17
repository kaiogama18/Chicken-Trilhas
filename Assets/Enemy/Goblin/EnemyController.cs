using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.5f;
    public Transform[] destinations;

    int currentIndex = 0;

    Animator animator;
    SpriteRenderer sprite;

    void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        if(destinations.Length == 0)
        {
            animator.SetBool("b_isWalking", false);
            return;
        }

        animator.SetBool("b_isWalking", true);

        var currentDestination = destinations[currentIndex];

        sprite.flipX = transform.position.x > currentDestination.position.x;

        transform.position = Vector3.MoveTowards(transform.position, currentDestination.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentDestination.position) <= 0.1f)
        {
            currentIndex = (currentIndex + 1) % destinations.Length; 

        }
    }
}
