using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake(){
        cardList.Add (new Card (0, "Mago",4,7,"O Mago é Implacável"));
        cardList.Add (new Card (1, "Guerreiro",3,4,"Um simples guerreiro"));
        cardList.Add (new Card (2, "Arqueiro",5,3,"I'm the bone of my sword"));
        cardList.Add (new Card (3, "Saber",8,8,"EXCALIBURRRR!!!!"));
        cardList.Add (new Card (4, "Lanceiro",5,9,"Gae Bolg!"));
    }
}
