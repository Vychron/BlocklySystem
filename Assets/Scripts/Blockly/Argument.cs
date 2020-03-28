/// <summary>
/// Abstract class for arguments to separate them from actions.
/// </summary>
public abstract class Argument : Blockly
{
    /*
       A float to return the value stored in the argument, as it can substitute for many variables,
       such as integers, doubles and even booleans.
    */
    public abstract float GetValue();
}
