using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public abstract class Head : MonoBehaviour
{
    public enum HeadType
    {
        Jawless,
        Scary,
        Derpy,
        Round,
        Headless
    }
    public GameObject tooth;

    public abstract HeadType headType { get; }

    protected abstract int badToothProbability { get; }

    protected abstract List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData { get; }

    private List<GameObject> headTeeth;

    protected virtual void Start()
    {
        headTeeth = new List<GameObject>();
        foreach (var data in toothData)
        {
            GameObject newTooth = Instantiate(tooth, transform);
            newTooth.name = $"Tooth:{Enum.GetName(typeof(Tooth.ToothArea), data.toothArea)}.{data.layerOrder}";
            Tooth toothComp = newTooth.GetComponent<Tooth>();
            toothComp.Init(data.position, data.scale, data.toothArea, data.layerOrder, badToothProbability);
            headTeeth.Add(newTooth);
        }
    }

    public int GetBadTeethCount()
    {
        int badTeeth = 0;
        foreach(GameObject gameObject in headTeeth)
        {
            Tooth tooth = gameObject.GetComponent<Tooth>();
            if (tooth.GetToothAttribute() != Tooth.ToothAttribute.Healthy)
            {
                badTeeth++;
            }
        }
        return badTeeth;
    }
}
