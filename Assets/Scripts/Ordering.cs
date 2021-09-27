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
    	protected Text _name;
        protected OrderList orderInstance;

        void Awake()
        {
    		_name = GameObject.FindWithTag("PizzaName").GetComponent<Text>();
            //PrintOrder
    	}

        void Start()
        {
            orderInstance = OrderList.GetInstance();
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
                Pizza PN_Mini = PizzasAbstractFactory.GetLaboratory(_name.text).CookPizza("Mini");
                Debug.Log("Pizza Mini " + _name.text + " a la orden, doña");
                _pizNum -= 1;

            }

           /* foreach(Pizza in orderInstance._pizOrder) {
            Debug.Log( x.ToString());
            }*/
        }
}
   /*public void PrintOrder(){
        //Imprimir con un For y al final sumar.
        //_TxtoName = NombrePizza;
        //_TxtPrice = PrecioPizza;
        //_TxtoName = NombrePizza;
        //_TxtPrice = PrecioPizza;

    }*/

 




    //Para no tener que hacer un ciclo para cada tipo de pizza, hacer un string name, que devuelva el nombre de esa pizza. Así como Pizza PN_Mini = PizzasAbstractFactory.GetLaboratory(name).CookPizza("Mini");
    //Así que al darle al botón, debe devolver el nombre de la pizza. Un método que haga eso. Como coger el tag del name que aparece en pantalla, dependiendo de la pizza.
