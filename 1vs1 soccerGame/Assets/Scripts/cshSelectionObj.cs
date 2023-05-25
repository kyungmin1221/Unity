using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSelectionObj : MonoBehaviour
{
     public Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if(hit.transform.gameObject.tag == "SelectableObj")
                {
                    Debug.Log(hit.transform.gameObject);
                    SetForce(hit.transform.gameObject);
                }
            }
        }
    }

    void SetForce(GameObject obj)
    {
        float power = Random.Range(500.0f, 1000.0f);
        Vector3 dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        dir = dir.normalized;
        obj.GetComponent<Rigidbody>().AddForce(dir * power);
    }
}
