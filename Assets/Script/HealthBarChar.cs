using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarChar : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)){
            // DealDamage(10);
        }
    }

    public void DealDamage(int from, float damageVal){
        currentHealth -= damageVal;
        healthbar.value = CalculateHealth();
        Debug.Log("player hit received from " + from);
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
