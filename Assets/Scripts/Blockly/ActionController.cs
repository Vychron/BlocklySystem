using System.Collections.Generic;
using UnityEngine;

public abstract class ActionController : Action
{
    [SerializeField]
    protected List<Action> _actions;
}
