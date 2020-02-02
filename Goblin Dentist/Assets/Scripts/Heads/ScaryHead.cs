using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryHead : Head
{
    protected override int badToothProbability => 50;

    public override HeadType headType => HeadType.Scary;

    protected override List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData =>
        new List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)>
        {
            (new Vector3(0.61f, -6.26f),   new Vector3(1.285f, 1.683f), Tooth.ToothArea.Lower, 4),
            (new Vector3(-0.66f, -6.67f), new Vector3(1.419f, 1.37f), Tooth.ToothArea.Lower, 4),
            (new Vector3(1.54f, -6.16f),  new Vector3(1.365f, 1.327f), Tooth.ToothArea.Lower, 3),
            (new Vector3(-1.81f, -6.15f), new Vector3(1.586f, 1.552f), Tooth.ToothArea.Lower, 3),
            (new Vector3(2.23f, -5.18f),  new Vector3(1.545f, 1.409f), Tooth.ToothArea.Lower, 2),
            (new Vector3(-2.719f, -5.85f),  new Vector3(1.225f, 1.243f), Tooth.ToothArea.Lower, 2),

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
