using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadManager : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Head currentHead;
    public GameObject[] possibleHeads;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("here");
        Instantiate(possibleHeads[Random.Range(0, possibleHeads.Length)], this.transform);
        //currentHead.Init(50);
        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = Resources.Load<Sprite>(currentHead.SpriteLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
