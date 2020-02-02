using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadlessHead : Head
{
    protected override int badToothProbability => 40;

    public override HeadType headType => HeadType.Headless;

    protected override List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)> toothData =>
        new List<(Vector3 position, Vector3 scale, Tooth.ToothArea toothArea, int layerOrder)>
        {
            (new Vector3(0.79f, -3f),   new Vector3(1.285f, 1.683f), Tooth.ToothArea.Lower, 5),
            (new Vector3(-0.32f, -3f), new Vector3(1.419f, 1.37f), Tooth.ToothArea.Lower, 5),
            (new Vector3(1.85f, -2.56f),  new Vector3(1.365f, 1.327f), Tooth.ToothArea.Lower, 4),
            (new Vector3(-1.34f, -2.88f), new Vector3(1.586f, 1.552f), Tooth.ToothArea.Lower, 4),
            (new Vector3(3.08f, -1.96f),  new Vector3(1.545f, 1.409f), Tooth.ToothArea.Lower, 3),
            (new Vector3(-2.37f, -2.41f),  new Vector3(1.225f, 1.243f), Tooth.ToothArea.Lower, 3),
            (new Vector3(4.5f, -1.36f),  new Vector3(1.225f, 1.243f), Tooth.ToothArea.Lower, 2),
            (new Vector3(-3.38f, -1.46f),  new Vector3(1.225f, 1.243f), Tooth.ToothArea.Lower, 2)
        };

    protected override void Start()
    {
        base.Start();
    }
}
