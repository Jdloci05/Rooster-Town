using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] Sprite icon;
    [SerializeField] float price;
    [SerializeField] bool isSellable;

    public string Name => name;
    public string Description => description;
    public Sprite Icon => icon;

    public float Price => price;

    public bool IsSellable => isSellable;

}
