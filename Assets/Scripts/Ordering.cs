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
        public Transform canvasRef;
        PizzaFactory PF = new PizzaFactory();

        void Awake(){
            orderInstance = OrderList.GetInstance();
            canvasRef = GameObject.Find("Canvas").GetComponent<Transform>();

            foreach(Pizza piz in orderInstance._pizOrder)
            {       orderInstance._prefab = GameObject.Instantiate(Resources.Load<GameObject>("TextToPrint"), Vector3.zero, Quaternion.identity);
                    orderInstance._prefab.transform.SetParent(canvasRef, false);
                    orderInstance._prefab.transform.position = new Vector3(200, 74, 0);
                    Debug.Log(orderInstance._prefab.transform.position);

                    orderInstance._prefabTxt = orderInstance._prefab.GetComponent<Text>();
                    orderInstance._prefabTxt.text = piz.Name;

                    Debug.Log(piz.Name + " " + piz.Price + " " + orderInstance._prefabTxt.text);
            }
        }
        
       	public void AddPiz(){
        	if(_pizNum<10){
        	_pizNum += 1;
        	_pizTotal.text = _pizNum.ToString(); 
        	}
        }

       public void SubtPiz(){
        	if(_pizNum>0){
        	_pizNum -= 1;
        	_pizTotal.text = _pizNum.ToString(); 
        	}
        }

        public void AddOrder(){

            while (_pizNum > 0){
                Pizza PNew = PF.CookPizza(orderInstance._name.text);

                _pizNum -= 1;
            }
        }
}