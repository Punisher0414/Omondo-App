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
        private Transform _canvasRef;
        PizzaFactory PF = new PizzaFactory();

        void Awake(){
            orderInstance = OrderList.GetInstance();
            _canvasRef = GameObject.Find("Canvas").GetComponent<Transform>();
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
                Debug.Log(orderInstance._pizQuant);

                switch (orderInstance._targetName){
                    case "Target_La_Presumida":
                    Pizza Presumida = PF.CookPizza("Presumida");
                    Debug.Log("Presumida");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    case "Target_La_Conchuda":
                    Pizza Conchuda = PF.CookPizza("Conchuda");
                    Debug.Log( "Conchuda");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    case "Target_La_Estirada":
                    Pizza Estirada = PF.CookPizza("Estirada");
                    Debug.Log("Estirada");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    case "Target_La_Chismosa":
                    Pizza Chismosa = PF.CookPizza("Chismosa");
                    Debug.Log("Chismosa");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    case "Target_La_Carnuda":
                    Pizza Carnuda = PF.CookPizza("Carnuda");
                    Debug.Log("Carnuda");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    case "Target_La_Bichota":
                    Pizza Bichota = PF.CookPizza("Bichota");
                    Debug.Log("Bichota");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    case "Target_Limonada_de_Cereza":
                    Pizza Cereza = PF.CookPizza("Cereza");
                    Debug.Log("Cereza");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                   	case "Target_Limonada_de_coco":
                    Pizza Coco = PF.CookPizza("Coco");
                    Debug.Log("Coco");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    case "Target_Limonada_de_Hierba_Buena":
                    Pizza Hierbabuena = PF.CookPizza("Hierbabuena");
                    Debug.Log("Hierbabuena");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    case "Target_Pizza_de_Chocolate":
                    Pizza Chocolate = PF.CookPizza("Chocolate");
                    Debug.Log("Chocolate");
                    Debug.Log("LISTA DE PIZZAS " + orderInstance._pizOrder.Count);
                    break;
                    default:
                    Debug.Log("Pida pues, óme");
                    break;
                }
            }
}