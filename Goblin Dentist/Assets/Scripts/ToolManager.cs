using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolManager : SingletonBase<ToolManager>
{

    protected ToolManager() { }
    private GameObject currentObj;
    private Tooth.ToothType repairType;
    public GameObject getInActive()
    {
        return currentObj;
    }
    public void setInActive(GameObject newObject)
    {
        if (currentObj)
        {
            currentObj.SetActive(true);
        }
        currentObj = newObject;
        currentObj.SetActive(false);
    }
    public Tooth.ToothType getrepairType()
    {
        return repairType;
    }
    public void setrepairMode(Tooth.ToothType repairMode)
    {
        repairType = repairMode;
    }
}
