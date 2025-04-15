using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;
    [SerializeField] private Text _text;

    private string _simpleText = "Текст просто заменяется";
    private string _addedText = "[Добавленный текст]";
    private string _scrollText = "*Перебор с заменой*";

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence
            .Append(_text.DOText(_simpleText, _duration))
            .Append(_text.DOText(_addedText, _duration).SetRelative())
            .Append(_text.DOText(_scrollText, _duration, true, ScrambleMode.All))
            .SetLoops(-1, LoopType.Restart);
    }
}
