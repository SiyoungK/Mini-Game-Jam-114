using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minimumDistance;

    public bool isSeeking = true;
    public Animator animator;

    private void Update() {
        if (Vector2.Distance(transform.position, target.position) > minimumDistance) {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        animator.SetBool("isSeeking", isSeeking);

    }

    
}
