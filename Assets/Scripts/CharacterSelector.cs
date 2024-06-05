using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : ItemSelector<SelectableCharacter>
{
    [SerializeField]
    TextMeshProUGUI _name_label;

    [SerializeField]
    TextMeshProUGUI _level_label;

    [SerializeField]
    Image _icon_display;

    [SerializeField]
    Transform _preview_model_parent;

    public override void DisplayCurrentItem()
    {
        _name_label.text = Current_item.name;
        _level_label.text = Current_item.level.ToString();
        _icon_display.sprite = Current_item.icon;
        FlushModel();
        Instantiate(Current_item.previewModel, _preview_model_parent);
    }

    public void FlushModel()
    {
        while (_preview_model_parent.childCount > 0)
            Destroy(_preview_model_parent.GetChild(0));
    }
}
