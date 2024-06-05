using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapSelector : ItemSelector<SelectableMap>
{
    [SerializeField]
    TextMeshProUGUI _name_label;

    [SerializeField]
    TextMeshProUGUI _description_label;

    [SerializeField]
    Image _image_display;

    public override void DisplayCurrentItem()
    {
        _name_label.text = Current_item.name;
        _description_label.text = Current_item.description;
        _image_display.sprite = Current_item.image;
    }
}
