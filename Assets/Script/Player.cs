using UnityEngine;
using UnityEngine.UI;

public abstract class Player : MonoBehaviour
{
   // Can use get/set and make them private
   public float currentHealth;
   public float maxHealth;
   public Slider healthbar;

   public Player() {

   }

   // Start is called before the first frame update
   void Start()
   {
      
   }

   // Update is called once per frame
   void Update()
   {
      
   }

   private void DealDamage(Player player, float damage) {
      player.currentHealth -= damage;
      player.healthbar.value = updateHealthbar();

      Debug.Log(this.name + " has attacked " + player.name + " and dealt " + damage + " damage.");

      if (player.currentHealth <= 0) {
         player.Die();
      }
   }

   private float updateHealthbar() {
      return currentHealth / maxHealth;
   }

   private void Die() {
      currentHealth = 0;
      Debug.Log(this.name + " has been killed.");
   }
}