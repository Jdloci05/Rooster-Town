using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CuttableTree : MonoBehaviour, Interactable
{
    public GameObject pickup;
    public IEnumerator Interact(Transform initiator)
    {
        yield return DialogManager.Instance.ShowDialogText("This tree Looks like it can be cut");

        int selectedChoice = 0;
        yield return DialogManager.Instance.ShowDialogText($"Do you want to use the axe? ",
            choices: new List<string>() { "Yes", "No"},
            onChoiceSelected: (selection) => selectedChoice = selection);

        if (selectedChoice == 0)
        {
            //yes
            yield return DialogManager.Instance.ShowDialogText($"You used the axe to cut");
            gameObject.SetActive(false);
            pickup.SetActive(true);
        }
    }
    
}
