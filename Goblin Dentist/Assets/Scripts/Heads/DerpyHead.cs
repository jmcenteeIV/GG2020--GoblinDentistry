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
            (new Vector3(0.61f, -6.26f),   new Vector3(1.285f, 1.7f), Tooth.ToothArea.Lower, 4),
            (new Vector3(-0.66f, -6.33f), new Vector3(1.419f, 1.59f), Tooth.ToothArea.Lower, 4),
            (new Vector3(1.54f, -5.19f),  new Vector3(1.365f, 1.43f), Tooth.ToothArea.Lower, 3),
            (new Vector3(-1.81f, -5.82f), new Vector3(1.586f, 1.60f), Tooth.ToothArea.Lower, 3),
            (new Vector3(2.44f, -4.12f),  new Vector3(1.26f, 1.34f), Tooth.ToothArea.Lower, 2),
            (new Vector3(-2.7f, -5.01f),  new Vector3(1.225f, 1.47f), Tooth.ToothArea.Lower, 2),

            (new Vector3(0.37f, -3.71f),  new Vector3(1.59f, 1.71f), Tooth.ToothArea.Upper, 4),
            (new Vector3(-1.03f, -3.77f), new Vector3(1.69f, 1.61f), Tooth.ToothArea.Upper, 4),
            (new Vector3(1.65f, -3.03f),  new Vector3(1.71f, 1.29f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-2.39f, -3.45f), new Vector3(1.32f, 1.42f), Tooth.ToothArea.Upper, 3),
            (new Vector3(-3.62f, -2.82f), new Vector3(1.389f, 1.22f), Tooth.ToothArea.Upper, 2),
            (new Vector3(3.1f, -2.42f),   new Vector3(1.521f, 1.21f), Tooth.ToothArea.Upper, 2)
        };

    protected override void Start()
    {
        base.Start();
    }
}
