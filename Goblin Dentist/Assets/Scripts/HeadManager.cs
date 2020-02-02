using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadManager : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject currentHead;
    public GameObject[] possibleHeads;

    // Start is called before the first frame update
    void Start()
    {
        Init();
        //currentHead.Init(50);
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = Resources.Load<Sprite>(currentHead.SpriteLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Init()
    {
        if (currentHead != null) {
            Destroy(currentHead);
            currentHead = null;
            Debug.Log("Deleted old Head");
        }
            Debug.Log("New Head Generated");
            currentHead = Instantiate(possibleHeads[Random.Range(0, possibleHeads.Length)], this.transform);

    }

}
