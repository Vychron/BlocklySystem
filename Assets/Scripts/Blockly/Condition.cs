using System.Collections.Generic;
using UnityEngine;

public abstract class Condition : ActionController
{
    [SerializeField]
    protected List<Argument> _arguments;
}
