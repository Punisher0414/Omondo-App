using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Factories;
using Pizzas;


public class EditOrder : MonoBehaviour
{
  protected OrderList orderInstance;
  private Text TextPrefab1;
  private string _quantTxt;
  private int _pizQuantCur;
  public Text _totalPrice;
  PizzaFactory PF = new PizzaFactory();
    
  void Start(){
    orderInstance = OrderList.GetInstance();

    TextPrefab1 = orderInstance._prefab[1].GetComponentInChildren<Text>();
      _quantTxt = TextPrefab1.text;
      _pizQuantCur = int.Parse(_quantTxt);
  }

  public void EditSubtPiz(){
          if(_pizQuantCur>0){
              _pizQuantCur -= 1;
              TextPrefab1.text = _pizQuantCur.ToString(); 
          }
        }

    public void EditAddPiz(){
          if(_pizQuantCur<3){
              _pizQuantCur += 1;
              TextPrefab1.text = _pizQuantCur.ToString(); 
          }
        }

    public void Order(){
      orderInstance._sent = true;
    }

    public void Actualizar(){
      orderInstance._priceTotal = 0;
      Text _textPrefab0 = orderInstance._prefab[0].GetComponentInChildren<Text>();
      _pizQuantCur = int.Parse(TextPrefab1.text);
      orderInstance._pizQuant = _pizQuantCur;
      Debug.Log("Cantidad de pizza Singleton: " + orderInstance._pizQuant);

      foreach(Pizza piz in orderInstance._pizOrder){
        piz.Quant = orderInstance._pizQuant;
        Debug.Log(piz.Ingr);
        Debug.Log("Cantidad de pizzas nuevas: " + piz.Quant);
      }
      
      foreach(Pizza piz in orderInstance._pizOrder){
        for(int i = 0; i<piz.Quant; i++){
          orderInstance._priceTotal += piz.Price;
          Debug.Log("Vuelta " + i);
          Debug.Log("Precio total: " + orderInstance._priceTotal);
      }
      _totalPrice.text = orderInstance._priceTotal.ToString();
    }
  }
}
