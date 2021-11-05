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
    public GameObject[] _prefab = new GameObject[2];
	public GameObject[] _prefabQuant = new GameObject [2];
    public Text[] _prefabTxt = new Text[2];
    public int _pizQuant;
    public int _priceTotal = 0;
    //public Text _name;
    public string _targetName;
    public bool _sent = false;
    public Transform[] _root = new Transform[2];


    private static OrderList _orderInstance;
    
	//Singleton.
	public static OrderList GetInstance(){
		if(_orderInstance == null){
			_orderInstance = new OrderList();
		}

		/*if(_orderInstance._name == null){
			GameObject objeto = GameObject.FindWithTag("PizzaName");
			if (objeto != null) {
				_orderInstance._name = objeto.GetComponent<Text>();
			}
		}*/

		return _orderInstance;
	}


}
