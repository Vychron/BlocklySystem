using UnityEngine;

/// <summary>
/// Controller is a starting point for block-built code.
/// </summary>
public class Controller : ActionController
{

    public override void Execute()
    {
        int count = _actions.Count;
        if (count == 0)
        {
            Debug.LogError("Er zijn geen acties toegevoegd aan de controller.");
            return;
        }
        for (int i = 0; i < count; i++)
            _actions[i].Execute();
    }

    private void Update()
    {
        // For testing purposes only, will be replaced by an external trigger in the future.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Execute();
        }
    }

    public override string GetText()
    {
        string output = "";
        int count = _actions.Count;

        if (count > 0)
            for (int i = 0; i < count; i++)
                output += "\n" + _actions[i].GetText();

        return output;
    }
}
