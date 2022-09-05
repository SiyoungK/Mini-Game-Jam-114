using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    private int hits = 0;
    public int endurance = 3;

    public void TakeDamage (int damage) {
        health -= damage;

        if (health <= 0) {
            Die();
        }

        hits += 1;
        if (hits == endurance) {
            Freeze();
            hits = 0;
        }
    }

    public void Freeze () {
        //Play freeze animation
        //Pause movement
    }

    void Die() {
        //Play death animation
        Destroy(gameObject);
    }
}
