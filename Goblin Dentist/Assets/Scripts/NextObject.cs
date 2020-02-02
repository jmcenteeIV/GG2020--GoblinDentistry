using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class NextObject : MonoBehaviour
{
    GameObject nextObject;
    GameObject currentObject;
    GameObject btn;
    public HeadManager reInit;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            List<RaycastHit2D> hits = Physics2D.LinecastAll(clickPostion, clickPostion).ToList();
            if (hits.Count() != 0)
            {
                btn = hits[0].collider.gameObject;
                AudioManager.Instance.toolPickup();
                Debug.Log("Clicked on next");
                currentObject = GameObject.Find("GoblinHolder");
                HeadManager reInit = (HeadManager)currentObject.GetComponent(typeof(HeadManager));
                reInit.Init();
               // Destroy(currentObject);
                //nextObject = Instantiate(currentObject);
               // nextObject.name = "GoblinHolder";
            }
        }
        
    }

}
