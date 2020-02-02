using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JawlessHead : Head
{
    protected override int badToothProbability => 50;

    public override HeadType headType => HeadType.Jawless;

    protected override List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData =>
        new List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)>
        {
            (new Vector3(0.58f, -3.28f),  new Vector3(2.103f, 1.583f), Tooth.ToothArea.Upper, 4),
            (new Vector3(-0.82f, -3.75f), new Vector3(1.998f, 1.49f), Tooth.ToothArea.Upper, 4),
            (new Vector3(1.73f, -3.44f),  new Vector3(1.601f, 1.431f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-2.28f, -3.24f), new Vector3(1.496f, 1.366f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-3.29f, -3.83f), new Vector3(1.389f, 1.344f), Tooth.ToothArea.Upper, 2),
            (new Vector3(2.69f, -4.2f),   new Vector3(1.721f, 1.251f), Tooth.ToothArea.Upper, 2)
        };

    protected override void Start()
    {
        base.Start();
    }
}
