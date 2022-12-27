using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGrave : MonoBehaviour, Interactable
{
    public GameObject pickup;
    public IEnumerator Interact(Transform initiator)
    {
        yield return DialogManager.Instance.ShowDialogText("This Grave Looks like it can be Destroy");

        int selectedChoice = 0;
        yield return DialogManager.Instance.ShowDialogText($"Do you want to use the pickaxe? ",
            choices: new List<string>() { "Yes", "No" },
            onChoiceSelected: (selection) => selectedChoice = selection);

        if (selectedChoice == 0)
        {
            //yes
            yield return DialogManager.Instance.ShowDialogText($"You used the pickaxe to cut");
            gameObject.SetActive(false);
            pickup.SetActive(true);
        }
    }

}