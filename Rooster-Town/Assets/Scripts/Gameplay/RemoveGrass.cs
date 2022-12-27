using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveGrass : MonoBehaviour, Interactable
{
    public GameObject pickup;
    public IEnumerator Interact(Transform initiator)
    {
        yield return DialogManager.Instance.ShowDialogText("This Grass Looks like it can be pulls off");

        int selectedChoice = 0;
        yield return DialogManager.Instance.ShowDialogText($"Do you want to use the shovel? ",
            choices: new List<string>() { "Yes", "No" },
            onChoiceSelected: (selection) => selectedChoice = selection);

        if (selectedChoice == 0)
        {
            //yes
            yield return DialogManager.Instance.ShowDialogText($"You used the shovel to pull off the grass");
            gameObject.SetActive(false);
            pickup.SetActive(true);
        }
    }

}
