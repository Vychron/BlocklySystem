using UnityEngine;

public class HoverText : MonoBehaviour
{
    public static HoverText Instance;

    private void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
}
