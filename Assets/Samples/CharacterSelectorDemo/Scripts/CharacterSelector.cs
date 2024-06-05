using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharacterSelector : ItemSelector<SelectableCharacter>
{
    [SerializeField]
    TextMeshProUGUI _name_label;

    [SerializeField]
    Transform _preview_model_parent;

    [SerializeField]
    GameObject _item_button_prefab;

    [SerializeField]
    RectTransform _item_buttons_parent;

    public override void DisplayCurrentItem()
    {
        _name_label.text = $"{Current_item.name} (LVL {Current_item.level})";
        FlushModel();
        Instantiate(Current_item.previewModel, _preview_model_parent);
    }

    public void FlushModel()
    {
         for (int i = 0; i< _preview_model_parent.childCount; i++)
            Destroy(_preview_model_parent.GetChild(0).gameObject);
    }

    public override void InitializeList()
    {
        // for variety let's pick character from VLG of buttons with icons

        foreach (Transform child in _item_buttons_parent.transform)
            Destroy(child.gameObject);

        for (int i = 0; i < items.Count; i++)
        {
            int idx = i;
            Debug.Log($"Binding button #{idx}");
            SelectableCharacter character = items[i];
            GameObject new_button = Instantiate(_item_button_prefab, _item_buttons_parent);
            new_button.transform.GetChild(0).GetComponent<Image>().sprite = character.icon;
            new_button.GetComponentInChildren<TextMeshProUGUI>().text = $"{character.name} (LVL {character.level})";
            new_button.GetComponent<Button>().onClick.AddListener(() => { GoToSelection(idx); Debug.Log($"Character #{idx} selected"); });
        }
    }
}