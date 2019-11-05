using UnityEngine;

public class HitScript : MonoBehaviour
{
    public int player = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D obj){
        Debug.Log("Player " + player + " attacking.");
        Debug.Log(gameObject.name);
        if (!obj.gameObject.tag.Equals(gameObject.tag))
        obj.gameObject.GetComponent<HealthBarChar> ().DealDamage(player, 10);
    }
}
