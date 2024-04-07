using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnityTest.InventorySystem 
{
    public class SelectIngredientUI : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private Image _image;
        [SerializeField] private TextMeshProUGUI _nameText;
        [SerializeField] private TextMeshProUGUI _qtyText;

        private InventoryView view;

        public string Name => _nameText.text;

        public void Initialize(InventoryView view, string name, Sprite sprite, int quantity = 0)
        {
            this.view = view;
            _nameText.text = name;
            _image.sprite = sprite;
            _qtyText.text = quantity.ToString();
        }

        public void SetQtyText(string qty)
        {
            _qtyText.text = qty;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            view.SelectIngredient(Name);
        }
    }
}