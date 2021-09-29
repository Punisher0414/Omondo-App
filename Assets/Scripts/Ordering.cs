using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Factories;
using Pizzas;

    //Aquí están incluidas todas las funciones de los botones, en la pantalla de AR.
public class Ordering : MonoBehaviour
    {

    	protected int _pizNum = 0;
    	public Text _pizTotal;

        protected OrderList orderInstance;

        void Awake(){
            orderInstance = OrderList.GetInstance();
            orderInstance.BuildLists();
        }
        

       	public void AddPiz()
        {
        	if(_pizNum<3){
        	_pizNum += 1;
        	_pizTotal.text = _pizNum.ToString(); 
        	}
        }

       public void SubtPiz()
        {
        	if(_pizNum>0){
        	_pizNum -= 1;
        	_pizTotal.text = _pizNum.ToString(); 
        	}
        }

        public void AddOrder(){

            while (_pizNum > 0){
                PizzaFactory PF = new PizzaFactory();
                Pizza PNew = PF.CookPizza(orderInstance._name.text);

                _pizNum -= 1;
            }

            foreach(Pizza piz in orderInstance._pizOrder){
                for (int i = 0; i < orderInstance._pizOrder.Count; i++){
                    orderInstance._stringTxts[i] = piz.Name;
                    orderInstance._goTxts[i].GetComponent<Text>().text = orderInstance._stringTxts[i]; 
                    //PruebaTexto[i].text = piz.Name;
                    Debug.Log(piz.Name + " " + piz.Price + " " + orderInstance._stringTxts[i]);
                }
                
            }
        }
}