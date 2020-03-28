using UnityEngine;

/// <summary>
/// Comparator is used to compare arguments with each other and returns a boolean based on the outcome.
/// </summary>
public class Comparator : Operation
{
    [SerializeField]
    private Comparators _comparator = Comparators.GelijkAan;

    public override float GetValue()
    {
        int count = _arguments.Count;

        if (count < 2)
        {
            Debug.LogError("Er zijn te weinig argumenten om met elkaar te vergelijken.");
            return 2;
        }
        /*
            The "pass" int is used as a boolean with an extra state for exceptions.
            The states of the pass are as following:
            0 = false
            1 = true
            2 = exception - attention is required.
        */
        int pass = 1;
        switch (_comparator)
        {
            case Comparators.NietGelijkAan:
                for (int i = 0; i < count - 1; i++)
                    if (_arguments[i].GetValue() == _arguments[i + 1].GetValue())
                        pass = 0;
                break;

            default:
                for (int i = 0; i < count - 1; i++)
                    if (_arguments[i].GetValue() != _arguments[i + 1].GetValue())
                        pass = 0;
                break;
        }
        return pass;
    }
}
