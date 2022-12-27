using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public string Name;
    private Vector2 input;

    public GameObject shopClothes;

    private Character character;

    private void Awake()
    {

        character = GetComponent<Character>();

    }

    void Start()
    {

        DialogManager.Instance.ShowDialogText("This Grass Looks like it can be pulls off");
        //Your code here
    }
    // Start is called before the first frame update


    public void HandleUpdate()
    {
        if (!character.IsMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            //Remove diagonal movement
            if (input.x != 0) input.y = 0;

            if (input != Vector2.zero)
            {
                StartCoroutine(character.Move(input));
            }
        }

        character.HandleUpdate();

        if (Input.GetKeyDown(KeyCode.Z))
        {
            StartCoroutine(Interact());
            Destroy(GameObject.FindWithTag("IntroTxt"));
        }
            
    }

    IEnumerator Interact()
    {
        var facingDir = new Vector3(character.Animator.MoveX, character.Animator.MoveY);
        var interactPos = transform.position + facingDir;

        var collider = Physics2D.OverlapCircle(interactPos, 0.3f, GameLayers.i.InteractableLayer);
        if (collider != null)
        {
           yield return collider.GetComponent<Interactable>()?.Interact(transform);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ((col.tag == "ShopC"))
        {
            shopClothes.SetActive(true);
        }
    }
}
