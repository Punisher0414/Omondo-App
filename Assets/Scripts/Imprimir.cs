using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Factories;
using Pizzas;

public class Imprimir : MonoBehaviour
{
	protected OrderList orderInstance;
	private Transform _canvasRef;
	public Text _totalPrice;
    // Start is called before the first frame update
    void Awake()
    {
    	orderInstance = OrderList.GetInstance();
        _canvasRef = GameObject.Find("Canvas").GetComponent<Transform>();

        orderInstance._root[0] = GameObject.Find("RootPiz").GetComponent<Transform>();
        orderInstance._root[1] = GameObject.Find("RootQuant").GetComponent<Transform>();

        PrintOrder();
    }

    public void PrintOrder(){
            
            foreach(Pizza piz in orderInstance._pizOrder){ 
            	orderInstance._prefab[0] = GameObject.Instantiate(Resources.Load<GameObject>("TxtPrint"));
                orderInstance._prefab[1] = GameObject.Instantiate(Resources.Load<GameObject>("QuantPrefab"));
                

                for(int i = 0; i < 2 ; i++){

                    orderInstance._prefab[i].transform.SetParent(_canvasRef, false);
                    orderInstance._prefab[i].transform.position = orderInstance._root[i].transform.position;

                    orderInstance._root[i].position = new Vector3(orderInstance._root[i].position.x, orderInstance._root[i].position.y - 120, orderInstance._root[i].position.z);
                    orderInstance._prefabTxt[i] = orderInstance._prefab[i].GetComponentInChildren<Text>();
                }

                for(int i = 0; i<piz.Quant; i++){
                    orderInstance._priceTotal += piz.Price;
                    Debug.Log("Precio total: " + orderInstance._priceTotal);
                }
                    _totalPrice.text = orderInstance._priceTotal.ToString();
                    orderInstance._prefabTxt[0].text = piz.Name;
                    orderInstance._prefabTxt[1].text = piz.Quant.ToString();
                    Debug.Log(piz.Name + " " + piz.Price + " " + orderInstance._prefabTxt[0].text + orderInstance._prefabTxt[1].text);
                    Debug.Log("CANTIDAD DE PIZZAS " + orderInstance._pizOrder.Count);
            }

        }
}
