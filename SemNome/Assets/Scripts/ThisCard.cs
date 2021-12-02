using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ThisCard : MonoBehaviour
{
    public List<Card> thisCard = new List<Card>();

    public int thisId;

    public int id;
    public string nomeCarta;
    public int custo;
    public int forca;
    public string descricaoCarta;

    public Text textoNome;
    public Text textoCusto;
    public Text textoForca;
    public Text textoDescricao;

    void Start () {
        thisCard[0] = CardDatabase.cardList[thisId]; 
    }   

    void Update () {
        id = thisCard[0].id;
        nomeCarta = thisCard[0].nomeCarta;
        custo = thisCard[0].custo;
        descricaoCarta = thisCard[0].descricaoCarta;

        textoNome.text = ""+nomeCarta;
        textoCusto.text = ""+custo;
        textoForca.text = ""+forca;
        textoDescricao.text = ""+ descricaoCarta ;

    }
    
}
