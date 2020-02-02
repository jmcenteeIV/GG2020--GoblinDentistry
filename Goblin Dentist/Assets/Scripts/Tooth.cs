using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tooth : MonoBehaviour
{

    public enum ToothType
    {
        Healthy,
        Wooden,
        Gold,
        Metal,
        Missing
    }
    
    enum ToothAttribute
    {
        Healthy,
        Rotten,
        Missing
    }

    public enum ToothArea
    {
        Upper,
        Lower
    }

    private List<(ToothType type, ToothAttribute attribute, string spritePath)> toothData 
        = new List<(ToothType type, ToothAttribute attribute, string spritePath)>
    {
        (ToothType.Healthy, ToothAttribute.Healthy, "Teeth/Normal/{0}"),
        (ToothType.Wooden, ToothAttribute.Rotten, "Teeth/Wood/{0}"),
        (ToothType.Gold, ToothAttribute.Rotten, "Teeth/Gold/{0}"),
        (ToothType.Metal, ToothAttribute.Rotten, "Teeth/Unique/{0}/gobtooth_nazgul"),
        (ToothType.Missing, ToothAttribute.Rotten, "nothing"),
        (ToothType.Missing, ToothAttribute.Missing, "nothing")
    };

    private (ToothType type, ToothAttribute attribute, string spritePath) toothSelection;

    private ToothArea selectedToothArea;
    private ToothAttribute selectedAttribute;
    private ToothType selectedToothType;

    public Tool tool;
    
    public void Init(Vector3 position, Vector3 scale, ToothArea toothArea, int layerOrder, int badToothProbability)
    {
        selectedToothArea = toothArea;
        // Determine if the tooth should be healthy.
        selectedAttribute = UnityEngine.Random.Range(1, 100) < 
            badToothProbability ? ToothAttribute.Rotten : ToothAttribute.Healthy;

        SpriteRenderer toothSprite = GetComponent<SpriteRenderer>();

        // Setup the location and sprite
        toothSprite.transform.position += position;
        toothSprite.transform.localScale = scale;
        toothSprite.sortingOrder = layerOrder;
        SetToothState(selectedAttribute);
    }
    
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SelectObject();
        }
    }

    void SelectObject()
    {
        Vector3 clickPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        List<RaycastHit2D> hits = Physics2D.LinecastAll(clickPostion, clickPostion).ToList();
        if (hits.Count() != 0)
        {
            if (toothSelection.type == ToolManager.Instance.getrepairType())
            {
                if (selectedAttribute == ToothAttribute.Rotten)
                    SetToothState(ToothAttribute.Healthy);
                else
                {
                    SetToothState(ToothAttribute.Missing);

                    // Enable to disable object.
                    //CapsuleCollider2D capsuleCollider = GetComponent<CapsuleCollider2D>();
                    //capsuleCollider.enabled = false;
                }
                AudioManager.Instance.toothRepair();
            }
        }
    }

    void SetToothState(ToothAttribute attribute)
    {
        SpriteRenderer toothSprite = GetComponent<SpriteRenderer>();

        // Randomly select a tooth of the healthiness determined.
        var possibleTeeth = toothData.Where(t => t.attribute == attribute);
        toothSelection = possibleTeeth.ElementAt(UnityEngine.Random.Range(0, possibleTeeth.Count()));

        // Set the tooth sprite path based on the area it exists. Requires the folder structure to be setup correctly.
        toothSelection.spritePath = string.Format(toothSelection.spritePath, Enum.GetName(typeof(ToothArea), selectedToothArea));
        var spriteList = Resources.LoadAll(toothSelection.spritePath, typeof(Sprite));
        
        toothSprite.sprite = spriteList[UnityEngine.Random.Range(0,spriteList.Length)] as Sprite;
        selectedToothType = toothSelection.type;
        selectedAttribute = attribute;
    }
}
