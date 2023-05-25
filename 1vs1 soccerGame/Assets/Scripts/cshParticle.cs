using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshParticle : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
     public GameObject particleSpawnPoint; // 파티클 생성 위치
      public GameObject particleSpawnPoint2; // 파티클 생성 위치


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "goal")
        {
                // 파티클 생성
            Instantiate(prefab2, particleSpawnPoint2.transform.position, Quaternion.identity);
            
        }
        else if (collision.gameObject.tag == "goal2")
        {
                // 파티클 생성
            Instantiate(prefab, particleSpawnPoint.transform.position, Quaternion.identity);
            
        }
    }
}
