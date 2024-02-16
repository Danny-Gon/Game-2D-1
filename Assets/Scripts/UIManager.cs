using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private int totalMonedas;
    [SerializeField] private TMP_Text textoMonedas;
    [SerializeField] private List<GameObject> LifesList;
    [SerializeField] private Sprite Lifefalse;
    private void Start()
    {
        Money.sumaMoneda += SumarMonedas;
    }

    private void SumarMonedas(int moneda)
    {
        totalMonedas += moneda;
        textoMonedas.text = totalMonedas.ToString();
    }

    public void RestaLife (int indice)
    {
        Image imagenLife = LifesList[indice].GetComponent<Image>();
        imagenLife.sprite = Lifefalse;
    }
}
