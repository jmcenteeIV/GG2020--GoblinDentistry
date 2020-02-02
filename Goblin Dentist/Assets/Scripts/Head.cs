using System;
using System.Collections;
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

    protected virtual void Start()
    {
        foreach (var data in toothData)
        {
            GameObject newTooth = Instantiate(tooth, transform);
            newTooth.name = $"Tooth:{Enum.GetName(typeof(Tooth.ToothArea), data.toothArea)}.{data.layerOrder}";
            Tooth toothComp = newTooth.GetComponent<Tooth>();
            toothComp.Init(data.position, data.scale, data.toothArea, data.layerOrder, badToothProbability);
        }
    }
}
