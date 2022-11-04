using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileEndBehavior : MonoBehaviour
{
    public float destroyTime = 1.5f;

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.GetComponent<PlayerBehavior>())
        {
            GameObject.FindObjectOfType<GameController>().SpawnNextTile();
            Destroy(transform.parent.gameObject, destroyTime);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
