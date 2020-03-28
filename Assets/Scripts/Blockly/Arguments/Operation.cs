using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abstract class for argument operations.
/// </summary>
public abstract class Operation : Argument
{
    // A protected list to store all arguments for the operation.
    [SerializeField]
    protected List<Argument> _arguments;
}
