using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] WalletUI walletUI;
    public GameObject SkinUI;
    public GameObject sk1, sk2, sk3, sk4, sk5, sk6;
    public Sprite sp1, sp2, sp3, sp4, sp5, sp6;

     void Update()
    {
        if (SkinUI.activeSelf)
        {
            walletUI.Show();
            if (Input.GetKeyDown(KeyCode.X))
            {
                SkinUI.SetActive(false);
                walletUI.Close();
            }
                
        }
        
    }

    public void NextOption()
    {
        if(sk1.activeSelf)
        {
            sk1.SetActive(false);
            sk2.SetActive(true);
        }
        else if(sk2.activeSelf)
        {
            sk2.SetActive(false);
            sk3.SetActive(true);
        }
        else if (sk3.activeSelf)
        {
            sk3.SetActive(false);
            sk4.SetActive(true);
        }
        else if (sk4.activeSelf)
        {
            sk4.SetActive(false);
            sk5.SetActive(true);
        }
        else if (sk5.activeSelf)
        {
            sk5.SetActive(false);
            sk6.SetActive(true);
        }
        else if (sk6.activeSelf)
        {
            sk6.SetActive(false);
            sk1.SetActive(true);
        }

    }

    public void BackOption()
    {
        if (sk1.activeSelf)
        {
            sk1.SetActive(false);
            sk6.SetActive(true);
        }
        else if (sk6.activeSelf)
        {
            sk6.SetActive(false);
            sk5.SetActive(true);
        }
        else if (sk5.activeSelf)
        {
            sk5.SetActive(false);
            sk4.SetActive(true);
        }
        else if (sk4.activeSelf)
        {
            sk4.SetActive(false);
            sk3.SetActive(true);
        }
        else if (sk3.activeSelf)
        {
            sk3.SetActive(false);
            sk2.SetActive(true);
        }
        else if (sk2.activeSelf)
        {
            sk2.SetActive(false);
            sk1.SetActive(true);
        }
    }

    public void PlayGame()
    {
        if (sk1.activeSelf)
        {
            Player.GetComponent<SpriteRenderer>().sprite = sp1;
            Player.transform.gameObject.tag = "Player";
            SkinUI.SetActive(false);

        }
        else if (sk2.activeSelf)
        {
            Wallet.i.TakeMoney(300);
            Player.GetComponent<SpriteRenderer>().sprite = sp2;
            Player.transform.gameObject.tag = "Skin 2";
            SkinUI.SetActive(false);
            walletUI.Close();

        }
        else if (sk3.activeSelf)
        {
            Wallet.i.TakeMoney(400);
            Player.GetComponent<SpriteRenderer>().sprite = sp3;
            Player.transform.gameObject.tag = "Skin 3";
            SkinUI.SetActive(false);
            walletUI.Close();
        }
        else if (sk4.activeSelf)
        {
            Wallet.i.TakeMoney(200);
            Player.GetComponent<SpriteRenderer>().sprite = sp4;
            Player.transform.gameObject.tag = "Skin 4";
            SkinUI.SetActive(false);
            walletUI.Close();
        }
        else if (sk5.activeSelf)
        {
            Wallet.i.TakeMoney(150);
            Player.GetComponent<SpriteRenderer>().sprite = sp5;
            Player.transform.gameObject.tag = "Skin 5";
            SkinUI.SetActive(false);
            walletUI.Close();
        }
        else if (sk6.activeSelf)
        {
            Wallet.i.TakeMoney(150);
            Player.GetComponent<SpriteRenderer>().sprite = sp6;
            Player.transform.gameObject.tag = "Skin 6";
            SkinUI.SetActive(false);
            walletUI.Close();
        }
    }
}


