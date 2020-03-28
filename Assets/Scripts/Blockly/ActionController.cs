using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Abstract class for every block that executes actions.
/// </summary>
public abstract class ActionController : Action
{
    // A protected list to store all actions to be executed by the controller.
    [SerializeField]
    protected List<Action> _actions;
}
