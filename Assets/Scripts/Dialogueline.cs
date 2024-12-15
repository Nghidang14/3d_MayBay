using TMPro;
using UnityEngine;

public class Dialogueline : MonoBehaviour
{
    [SerializeField] string[] timelineTextLines;
    [SerializeField] TMP_Text dialogueText;
    int curLine = 0;

    public void NextDialogueLine()
    {
        curLine++;
        dialogueText.text = timelineTextLines[curLine];
    }
}
