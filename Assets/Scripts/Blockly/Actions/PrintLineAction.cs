using UnityEngine;

/// <summary>
/// A simple action to print a line to the console.
/// </summary>
public class PrintLineAction : Action
{
    [SerializeField]
    private string _text = "";

    public override void Execute()
    {
        print(_text);
    }

    public override string GetText()
    {
        string indent = "";
        _depth = GetDepth();
        for (int i = 0; i < _depth; i++)
        {
            indent += " ";
        }
        return indent + "PrintLine(\"" + _text + "\");";
    }
}
