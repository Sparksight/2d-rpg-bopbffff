using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public int damageInflicted
    void OnTriggerEnter2D(Colide2D collision)
    {
        if (collision is BoxCollider2D)
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            StartCoroutine(enemy.DamageCharacter(damageInflicted, object.0.0f));
            gameObject.SetActive(false)};
    }