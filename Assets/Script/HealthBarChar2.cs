using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarChar2 : MonoBehaviour
{
    public float currentHealth { get; set; }
    public float maxHealth { get; set; }

    public Slider healthbar;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100f;
        currentHealth = maxHealth;

        healthbar.value = CalculateHealth();
    }


    public void DealDamage(int from, float damageVal){
        currentHealth -= damageVal;
        healthbar.value = CalculateHealth(); Debug.Log("player2 hit " + currentHealth);
        if(currentHealth <= 0){
            Die();
        }
    }

    float CalculateHealth(){
        return currentHealth/maxHealth;
    }

    void Die(){
        currentHealth = 0;
    }
}
