using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Abstract base of all blocks.
/// Every block will derive from this class.
/// </summary>
public abstract class Blockly : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // The depth of the block in hierarchy.
    protected int _depth;

    // Reference to the hover text.
    protected Text _hText => HoverText.Instance.GetComponent<Text>();

    /// <summary>
    /// Pointer event to check if mouse starts hovering over a block.
    /// </summary>
    /// <param name="eventData">Data of the pointer event.</param>
    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        SetText();
        StartCoroutine(ShowText());
    }

    /// <summary>
    /// Short delay before showing hover text.
    /// </summary>
    public virtual IEnumerator ShowText()
    {
        yield return new WaitForSeconds(0.5f);
        _hText.transform.position = Input.mousePosition;
        _hText.enabled = true;
    }

    /// <summary>
    /// Pointer event to check if the mouse stops hovering over a block.
    /// </summary>
    /// <param name="eventData">Data of the pointer event.</param>
    public virtual void OnPointerExit(PointerEventData eventData)
    {
        _hText.enabled = false;
        StopCoroutine(ShowText());
    }

    /// <summary>
    /// Gets the code that the block substitutes.
    /// </summary>
    /// <returns>Returns a sting of the code that the block substitutes.</returns>
    public virtual string GetText()
    {
        return " ";
    }

    /// <summary>
    /// Sets the hoverText object's text to the code that the block substitutes.
    /// </summary>
    public virtual void SetText()
    {
        _hText.text = GetText();
    }

    /// <summary>
    /// Gets the depth of the block in the block hierarchy.
    /// </summary>
    /// <returns>Integer of the block's depth in the block hierarchy.</returns>
    public virtual int GetDepth()
    {
        int currentDepth = 0;
        Blockly parent = transform.parent?.GetComponent<Blockly>();
        if (!parent)
            return 0;

        currentDepth += 2;
        return currentDepth + parent.GetDepth();
    }
}
