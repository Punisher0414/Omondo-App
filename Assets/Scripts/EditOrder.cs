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
  List<GameObject> _prefabQuantNums = new List<GameObject>();
  List<int> Quantities = new List<int>();
    
  void Start(){
    orderInstance = OrderList.GetInstance();
  }

  public void EditSubtPiz(){
    TextPrefab1 = this.GetComponentInChildren<Text>();
    _quantTxt = TextPrefab1.text;
    _pizQuantCur = int.Parse(_quantTxt);

      if(_pizQuantCur>0){
          _pizQuantCur -= 1;
          TextPrefab1.text = _pizQuantCur.ToString(); 
        }
      }

  public void EditAddPiz(){
    TextPrefab1 = this.GetComponentInChildren<Text>(); //Toma el componente texto del prefab
     _quantTxt = TextPrefab1.text; //guarda el texto en quanttxt
     _pizQuantCur = int.Parse(_quantTxt); //lo convierte a int

      if(_pizQuantCur<3){
          _pizQuantCur += 1;
          TextPrefab1.text = _pizQuantCur.ToString(); 
        }
      }

    public void Order(){
      orderInstance._sent = true;
    }

    public void Actualizar(){
      orderInstance._priceTotal = 0; //Elimina todo lo que está en la suma de precio total.
      _prefabQuantNums = new List<GameObject>();
      Quantities = new List<int>();
      
      _prefabQuantNums.AddRange(GameObject.FindGameObjectsWithTag("QuantPrefabNum")); //Guarda todos los prefabs que hay en la escena.

      foreach(GameObject prefab in _prefabQuantNums){
        string prefabtxt = prefab.GetComponent<Text>().text; //Toma el texto.
        int pizQuantCurrent = int.Parse(prefabtxt); //Convierte ese texto (el número) en int.
        Debug.Log("Cantidad actual de pizzas en prefab: " + pizQuantCurrent); //Imprime el número actualizado de pizzas.
        Quantities.Add(pizQuantCurrent);
      }

      for(int i = 0; i<orderInstance._pizOrder.Count; i++){
        Debug.Log("Antes: " + orderInstance._pizOrder[i].Quant);
        orderInstance._pizOrder[i].Quant = Quantities[i];
        Debug.Log("Después: " + orderInstance._pizOrder[i].Quant);
      }

      if(orderInstance._priceTotal == 0){
        foreach(Pizza piz in orderInstance._pizOrder){
          for(int i = 0; i<piz.Quant; i++){
            orderInstance._priceTotal += piz.Price;
            Debug.Log("Se sumó " + orderInstance._priceTotal + " de " + piz.Name);
          }
        }
      }
      _totalPrice.text = orderInstance._priceTotal.ToString();
  }
}
