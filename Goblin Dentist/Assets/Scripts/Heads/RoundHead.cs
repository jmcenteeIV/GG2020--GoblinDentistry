using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundHead : Head
{
    protected override int badToothProbability => 50;

    public override HeadType headType => HeadType.Round;

    protected override List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData =>
        new List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)>
        {
            (new Vector3(0.57f, -4.71f),   new Vector3(1.285f, 1.683f), Tooth.ToothArea.Lower, 4),
            (new Vector3(-0.65f, -4.86f), new Vector3(1.419f, 1.37f), Tooth.ToothArea.Lower, 4),
            (new Vector3(1.43f, -4.5f),  new Vector3(1.365f, 1.327f), Tooth.ToothArea.Lower, 3),
            (new Vector3(-1.73f, -4.22f), new Vector3(1.586f, 1.552f), Tooth.ToothArea.Lower, 3),
            (new Vector3(2.21f, -3.93f),  new Vector3(1.545f, 1.409f), Tooth.ToothArea.Lower, 2),
            (new Vector3(-2.62f, -3.48f),  new Vector3(1.225f, 1.243f), Tooth.ToothArea.Lower, 2),

            (new Vector3(0.54f, -2.45f),  new Vector3(2.103f, 1.583f), Tooth.ToothArea.Upper, 4),
            (new Vector3(-0.88f, -2.05f), new Vector3(1.998f, 1.49f), Tooth.ToothArea.Upper, 4),
            (new Vector3(1.8f, -2.14f),  new Vector3(1.601f, 1.431f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-2.03f, -2.06f), new Vector3(1.496f, 1.366f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-3.12f, -2.72f), new Vector3(1.389f, 1.344f), Tooth.ToothArea.Upper, 2),
            (new Vector3(3.04f, -2.42f),   new Vector3(1.721f, 1.251f), Tooth.ToothArea.Upper, 2)
        };

    protected override void Start()
    {
        base.Start();
    }
}
