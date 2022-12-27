using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    [Header("Default and NPC Skin")]
    [SerializeField] List<Sprite> defaultWalkDownSprites;
    [SerializeField] List<Sprite> defaultWalkUpSprites;
    [SerializeField] List<Sprite> defaultWalkRightSprites;
    [SerializeField] List<Sprite> defaultWalkLeftSprites;


    [Header("Skin 2")]
    [SerializeField] List<Sprite> skin2WalkDownSprites;
    [SerializeField] List<Sprite> skin2WalkUpSprites;
    [SerializeField] List<Sprite> skin2WalkRightSprites;
    [SerializeField] List<Sprite> skin2WalkLeftSprites;

    [Header("Skin 3")]
    [SerializeField] List<Sprite> skin3WalkDownSprites;
    [SerializeField] List<Sprite> skin3WalkUpSprites;
    [SerializeField] List<Sprite> skin3WalkRightSprites;
    [SerializeField] List<Sprite> skin3WalkLeftSprites;

    [Header("Skin 4")]
    [SerializeField] List<Sprite> skin4WalkDownSprites;
    [SerializeField] List<Sprite> skin4WalkUpSprites;
    [SerializeField] List<Sprite> skin4WalkRightSprites;
    [SerializeField] List<Sprite> skin4WalkLeftSprites;

    [Header("Skin 5")]
    [SerializeField] List<Sprite> skin5WalkDownSprites;
    [SerializeField] List<Sprite> skin5WalkUpSprites;
    [SerializeField] List<Sprite> skin5WalkRightSprites;
    [SerializeField] List<Sprite> skin5WalkLeftSprites;

    [Header("Skin 6")]
    [SerializeField] List<Sprite> skin6WalkDownSprites;
    [SerializeField] List<Sprite> skin6WalkUpSprites;
    [SerializeField] List<Sprite> skin6WalkRightSprites;
    [SerializeField] List<Sprite> skin6WalkLeftSprites;

    [SerializeField] List<Sprite> defaultSkin;

    // Parameters

    public float MoveX { get; set; }

    public float MoveY { get; set; }

    public bool IsMoving { get; set; }

    // States
    SpriteAnimator defaultWalkDownAnim;
    SpriteAnimator defaultWalkUpAnim;
    SpriteAnimator defaultWalkRightAnim;
    SpriteAnimator defaultWalkLeftAnim;

    SpriteAnimator skin2WalkDownAnim;
    SpriteAnimator skin2WalkUpAnim;
    SpriteAnimator skin2WalkRightAnim;
    SpriteAnimator skin2WalkLeftAnim;

    SpriteAnimator skin3WalkDownAnim;
    SpriteAnimator skin3WalkUpAnim;
    SpriteAnimator skin3WalkRightAnim;
    SpriteAnimator skin3WalkLeftAnim;

    SpriteAnimator skin4WalkDownAnim;
    SpriteAnimator skin4WalkUpAnim;
    SpriteAnimator skin4WalkRightAnim;
    SpriteAnimator skin4WalkLeftAnim;

    SpriteAnimator skin5WalkDownAnim;
    SpriteAnimator skin5WalkUpAnim;
    SpriteAnimator skin5WalkRightAnim;
    SpriteAnimator skin5WalkLeftAnim;

    SpriteAnimator skin6WalkDownAnim;
    SpriteAnimator skin6WalkUpAnim;
    SpriteAnimator skin6WalkRightAnim;
    SpriteAnimator skin6WalkLeftAnim;


    SpriteAnimator currentAnim;
    bool wasPreviouslyMoving;

    // References
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultWalkDownAnim = new SpriteAnimator(defaultWalkDownSprites, spriteRenderer);
        defaultWalkUpAnim = new SpriteAnimator(defaultWalkUpSprites, spriteRenderer);
        defaultWalkRightAnim = new SpriteAnimator(defaultWalkRightSprites, spriteRenderer);
        defaultWalkLeftAnim = new SpriteAnimator(defaultWalkLeftSprites, spriteRenderer);

        skin2WalkDownAnim = new SpriteAnimator(skin2WalkDownSprites, spriteRenderer);
        skin2WalkUpAnim = new SpriteAnimator(skin2WalkUpSprites, spriteRenderer);
        skin2WalkRightAnim = new SpriteAnimator(skin2WalkRightSprites, spriteRenderer);
        skin2WalkLeftAnim = new SpriteAnimator(skin2WalkLeftSprites, spriteRenderer);

        skin3WalkDownAnim = new SpriteAnimator(skin3WalkDownSprites, spriteRenderer);
        skin3WalkUpAnim = new SpriteAnimator(skin3WalkUpSprites, spriteRenderer);
        skin3WalkRightAnim = new SpriteAnimator(skin3WalkRightSprites, spriteRenderer);
        skin3WalkLeftAnim = new SpriteAnimator(skin3WalkLeftSprites, spriteRenderer);

        skin4WalkDownAnim = new SpriteAnimator(skin4WalkDownSprites, spriteRenderer);
        skin4WalkUpAnim = new SpriteAnimator(skin4WalkUpSprites, spriteRenderer);
        skin4WalkRightAnim = new SpriteAnimator(skin4WalkRightSprites, spriteRenderer);
        skin4WalkLeftAnim = new SpriteAnimator(skin4WalkLeftSprites, spriteRenderer);

        skin5WalkDownAnim = new SpriteAnimator(skin5WalkDownSprites, spriteRenderer);
        skin5WalkUpAnim = new SpriteAnimator(skin5WalkUpSprites, spriteRenderer);
        skin5WalkRightAnim = new SpriteAnimator(skin5WalkRightSprites, spriteRenderer);
        skin5WalkLeftAnim = new SpriteAnimator(skin5WalkLeftSprites, spriteRenderer);

        skin6WalkDownAnim = new SpriteAnimator(skin6WalkDownSprites, spriteRenderer);
        skin6WalkUpAnim = new SpriteAnimator(skin6WalkUpSprites, spriteRenderer);
        skin6WalkRightAnim = new SpriteAnimator(skin6WalkRightSprites, spriteRenderer);
        skin6WalkLeftAnim = new SpriteAnimator(skin6WalkLeftSprites, spriteRenderer);


        currentAnim = new SpriteAnimator(defaultSkin, spriteRenderer);
    }

    private void Update()
    {
        var prevAnim = currentAnim;

        if ( tag == "Player" && MoveX == 1)
            currentAnim = defaultWalkRightAnim;
        else if (tag == "Player" && MoveX == -1)
            currentAnim = defaultWalkLeftAnim;
        else if (tag == "Player" && MoveY == 1)
            currentAnim = defaultWalkUpAnim;
        else if (tag == "Player" && MoveY == -1)
            currentAnim = defaultWalkDownAnim;

        else if (tag == "Skin 2" && MoveX == 1)
            currentAnim = skin2WalkRightAnim;
        else if (tag == "Skin 2" && MoveX == -1)
            currentAnim = skin2WalkLeftAnim;
        else if (tag == "Skin 2" && MoveY == 1)
            currentAnim = skin2WalkUpAnim;
        else if (tag == "Skin 2" && MoveY == -1)
            currentAnim = skin2WalkDownAnim;

        else if (tag == "Skin 3" && MoveX == 1)
            currentAnim = skin3WalkRightAnim;
        else if (tag == "Skin 3" && MoveX == -1)
            currentAnim = skin3WalkLeftAnim;
        else if (tag == "Skin 3" && MoveY == 1)
            currentAnim = skin3WalkUpAnim;
        else if (tag == "Skin 3" && MoveY == -1)
            currentAnim = skin3WalkDownAnim;

        else if (tag == "Skin 4" && MoveX == 1)
            currentAnim = skin4WalkRightAnim;
        else if (tag == "Skin 4" && MoveX == -1)
            currentAnim = skin4WalkLeftAnim;
        else if (tag == "Skin 4" && MoveY == 1)
            currentAnim = skin4WalkUpAnim;
        else if (tag == "Skin 4" && MoveY == -1)
            currentAnim = skin4WalkDownAnim;

        else if (tag == "Skin 5" && MoveX == 1)
            currentAnim = skin5WalkRightAnim;
        else if (tag == "Skin 5" && MoveX == -1)
            currentAnim = skin5WalkLeftAnim;
        else if (tag == "Skin 5" && MoveY == 1)
            currentAnim = skin5WalkUpAnim;
        else if (tag == "Skin 5" && MoveY == -1)
            currentAnim = skin5WalkDownAnim;

        else if (tag == "Skin 6" && MoveX == 1)
            currentAnim = skin6WalkRightAnim;
        else if (tag == "Skin 6" && MoveX == -1)
            currentAnim = skin6WalkLeftAnim;
        else if (tag == "Skin 6" && MoveY == 1)
            currentAnim = skin6WalkUpAnim;
        else if (tag == "Skin 6" && MoveY == -1)
            currentAnim = skin6WalkDownAnim;

        if (currentAnim != prevAnim || IsMoving != wasPreviouslyMoving)
            currentAnim.Start();

        if (IsMoving)
            currentAnim.HandleUpdate();
        else
            spriteRenderer.sprite = currentAnim.Frames[0];

        wasPreviouslyMoving = IsMoving;
    }
}
