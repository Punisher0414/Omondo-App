using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Pizzas;

public class OrderList
{
	//Aquí hay implementado un Singleton, para que todas las clases puedan acceder a la lista...
	//...donde se van a alamcenar las pizzas al ser pedidas.

    public List<Pizza> _pizOrder = new List<Pizza>();
    public List<Text> _stringTxts = new List <Text>();
    public List<Text> _intTxts = new List <Text>();


    private static OrderList _orderInstance;

	//Singleton.
	public static OrderList GetInstance(){
		if(_orderInstance == null){
			_orderInstance = new OrderList();
		}
		return _orderInstance;
	}
}
