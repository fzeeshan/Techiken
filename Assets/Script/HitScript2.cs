using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D obj){
        Debug.Log("Player 2 attacking.");
        // obj.gameObject.GetComponent<HealthBarChar> ().DealDamage(15);
    }
}
