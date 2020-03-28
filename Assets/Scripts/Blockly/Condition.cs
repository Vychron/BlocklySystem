using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abstract class for action controllers with conditions.
/// </summary>
public abstract class Condition : ActionController
{
    /* 
       A protected list to store all arguments that make up the conditions,
       such as booleans or numeric values to compare with each other.
    */ 
    [SerializeField]
    protected List<Argument> _arguments;
}
