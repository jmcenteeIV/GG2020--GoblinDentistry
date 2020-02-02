using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerpyHead : Head
{
    protected override int badToothProbability => 40;

    public override HeadType headType => HeadType.Derpy;

    protected override List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData =>
        new List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)>
        {
            (new Vector3(0.61f, -6.26f),   new Vector3(1.285f, 2.383f), Tooth.ToothArea.Lower, 4),
            (new Vector3(-0.66f, -6.67f), new Vector3(1.419f, 2.17f), Tooth.ToothArea.Lower, 4),
            (new Vector3(1.84f, -5.23f),  new Vector3(1.365f, 2.127f), Tooth.ToothArea.Lower, 3),
            (new Vector3(-1.81f, -6.15f), new Vector3(1.586f, 2.152f), Tooth.ToothArea.Lower, 3),
            (new Vector3(2.48f, -3.98f),  new Vector3(1.545f, 2.109f), Tooth.ToothArea.Lower, 2),
            (new Vector3(-2.7f, -4.86f),  new Vector3(1.225f, 2.143f), Tooth.ToothArea.Lower, 2),

            (new Vector3(0.39f, -3.87f),  new Vector3(2.103f, 2.383f), Tooth.ToothArea.Upper, 4),
            (new Vector3(-1.22f, -3.5f), new Vector3(1.998f, 2.19f), Tooth.ToothArea.Upper, 4),
            (new Vector3(1.69f, -3.36f),  new Vector3(1.601f, 2.131f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-2.66f, -3.2f), new Vector3(1.496f, 2.166f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-3.8f, -2.82f), new Vector3(1.389f, 2.144f), Tooth.ToothArea.Upper, 2),
            (new Vector3(3.2f, -2.49f),   new Vector3(1.721f, 2.151f), Tooth.ToothArea.Upper, 2)
        };

    protected override void Start()
    {
        base.Start();
    }
}
