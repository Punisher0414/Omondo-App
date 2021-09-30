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

        public int _pizNum = 0;
        public Text _pizTotal;
        protected OrderList orderInstance;
        private Transform[] _root = new Transform[2];
        private Transform _canvasRef;
        PizzaFactory PF = new PizzaFactory();

        void Awake(){
            orderInstance = OrderList.GetInstance();
            _canvasRef = GameObject.Find("Canvas").GetComponent<Transform>();

            _root[0] = GameObject.Find("RootPiz").GetComponent<Transform>();
            _root[1] = GameObject.Find("RootQuant").GetComponent<Transform>();
            orderInstance._prefab[0] = GameObject.Instantiate(Resources.Load<GameObject>("TextToPrint"));
            orderInstance._prefab[1] = GameObject.Instantiate(Resources.Load<GameObject>("TextQuantPrint"));

            PrintOrder();
        }
        
       	public void AddPiz(){
        	if(_pizNum<3){
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

    //Botón Agregar: llama a la factoría y crea la pizza que se ha pedido, con su respectivo nombre. 
        public void AddOrder(){
            //Siempre va a crear una sola pizza, pero va a guardar la cantidad y se lo va adar a la pizza, luego la pizza imprime el número y ya.
                orderInstance._pizQuant =_pizNum;
                Pizza PNew = PF.CookPizza(orderInstance._name.text);
                Debug.Log(orderInstance._pizQuant);
            }

        public void PrintOrder(){

            foreach(Pizza piz in orderInstance._pizOrder){ 
                for(int i = 0; i < 2 ; i++){
                    orderInstance._prefab[i].transform.SetParent(_canvasRef, false);
                    orderInstance._prefab[i].transform.position = _root[i].transform.position;

                    _root[i].position = new Vector3(_root[i].position.x, _root[i].position.y - 30, _root[i].position.z);
                    orderInstance._prefabTxt[i] = orderInstance._prefab[i].GetComponent<Text>();
                }
                    orderInstance._prefabTxt[0].text = piz.Name;
                    orderInstance._prefabTxt[1].text = piz.Quant.ToString();

                   Debug.Log(piz.Name + " " + piz.Price + " " + orderInstance._prefabTxt[0].text + orderInstance._prefabTxt[1].text);
            }

        }
        
}