using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipHitbox : MonoBehaviour
{
    private BoxCollider2D box;
    private CircleCollider2D circle;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        box.offset = new Vector2 (box.offset.x * -1, box.offset.y);
    }
}
