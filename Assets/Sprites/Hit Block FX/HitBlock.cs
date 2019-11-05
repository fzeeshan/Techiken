using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBlock : MonoBehaviour
{
    [SerializeField]
    GameObject hitPicture;
    [SerializeField]
    GameObject blockPicture;

    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.name.Equals("Player2")){
            Instantiate(hitPicture, new Vector2 (transform.position.x + 6f, transform.position.y - 6f), Quaternion.identity);
        }
        if(col.gameObject.name.Equals("Player2")){
            Instantiate(blockPicture, new Vector2 (transform.position.x + 6f, transform.position.y  - 6f), Quaternion.identity);
        }
    }
}
