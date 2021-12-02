using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card 
{
    public int id;
    public string nomeCarta;
    public int custo;
    public int forca;
    public string descricaoCarta;

    public Card(){

    }

    public Card(int Id, string NomeCarta, int Custo, int Forca, string DescricaoCarta){
        this.id = Id;
        this.nomeCarta = NomeCarta;
        this.custo = Custo;
        this.forca = Forca;
        this.descricaoCarta = DescricaoCarta; 
    }

}
