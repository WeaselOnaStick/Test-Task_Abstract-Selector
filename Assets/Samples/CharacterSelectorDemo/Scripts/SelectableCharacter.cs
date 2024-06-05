
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Selectable Character", menuName = "Selectables/Character")]
public class SelectableCharacter : SelectableItem
{
    public string name;
    public int level;
    public Sprite icon;
    public GameObject previewModel;
}
