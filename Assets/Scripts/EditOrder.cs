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
    PizzaFactory PF = new PizzaFactory();
    
	void Awake(){
		orderInstance = OrderList.GetInstance();
//PREGUNTAR AL PROFE
		/*TextPrefab1 = orderInstance._prefab[1].GetComponentInChildren<Text>();
    	_quantTxt = TextPrefab1.text;
    	_pizQuantCur = int.Parse(_quantTxt);*/
	}

	public void EditSubtPiz(){
		TextPrefab1 = orderInstance._prefab[1].GetComponentInChildren<Text>();
    	_quantTxt = TextPrefab1.text;
    	_pizQuantCur = int.Parse(_quantTxt);

          if(_pizQuantCur>0){
              _pizQuantCur -= 1;
              TextPrefab1.text = _pizQuantCur.ToString(); 
          }
        }

    public void EditAddPiz(){
		TextPrefab1 = orderInstance._prefab[1].GetComponentInChildren<Text>();
    	_quantTxt = TextPrefab1.text;
    	_pizQuantCur = int.Parse(_quantTxt);

          if(_pizQuantCur<3){
              _pizQuantCur += 1;
              TextPrefab1.text = _pizQuantCur.ToString(); 
          }
        }

    public void Order(){
    	TextPrefab1 = orderInstance._prefab[1].GetComponentInChildren<Text>();
    	Text _textPrefab0 = orderInstance._prefab[0].GetComponentInChildren<Text>();

    	_pizQuantCur = int.Parse(TextPrefab1.text);
        orderInstance._pizQuant = _pizQuantCur;
        Pizza PNew = PF.CookPizza(_textPrefab0.text);

        Debug.Log(orderInstance._pizQuant);

       	orderInstance._sent = true;
    }
}
