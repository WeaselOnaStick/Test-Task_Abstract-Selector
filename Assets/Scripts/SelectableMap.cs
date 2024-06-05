
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Selectable Map", menuName = "Selectables/Map")]
public class SelectableMap : SelectableItem
{
    public string name;
    public string description;
    public Sprite image;
    public int sceneID;
}
