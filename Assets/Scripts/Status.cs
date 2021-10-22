using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Pizzas;

namespace Statuses{
public class Status : MonoBehaviour
{
	//PARA QUE LA CORRUTINA CONTINÚE DEBE STAR EN EL SINGLETON?

    protected OrderList orderInstance;
	public GameObject _listoPed;
	private Image[] _status = new Image[3];

	public GameObject _cancelMSG;
    
    void Start(){
    	orderInstance = OrderList.GetInstance();

        _status[0] = GameObject.Find("EnFila").GetComponent<Image>();
        _status[1] = GameObject.Find("Preparando").GetComponent<Image>();
        _status[2] = GameObject.Find("Listo").GetComponent<Image>();
    	

    	if(orderInstance._sent == true){
    		if(orderInstance._stateTrig == false){
    			StartCo();
    		}
    	}
    }

	public void StartCo(){
        StartCoroutine(StatesChange());
        Debug.Log("LA CORRUTINA HA EMPEZADO");
	}

	public void CancelarPedido(){
		orderInstance._pizOrder = new List<Pizza>();
		StopCoroutine(StatesChange());
		StartCoroutine(CancelPopUp());
	}

	IEnumerator CancelPopUp(){
		if (_cancelMSG != null)
		{
			_cancelMSG.SetActive(true);
			yield return new WaitForSeconds(2.5f);
			_cancelMSG.SetActive(false);			
		}
	}

     IEnumerator StatesChange()
	{
		orderInstance._stateTrig = true;

		_status[0].color = new Color32(0, 130, 130, 255);
		Debug.Log("En fila");
		yield return new WaitForSecondsRealtime(3);

		_status[0].color = new Color32(255, 255, 255, 255);
		_status[1].color = new Color32(0, 130, 130, 255);
		Debug.Log("Preparando");
		yield return new WaitForSecondsRealtime(3);
		StopCoroutine(StatesChange());

		_status[1].color = new Color32(255, 255, 255, 255);
		_status[2].color = new Color32(0, 130, 130, 255);
		Debug.Log("Listo");
		yield return new WaitForSecondsRealtime(3);
		_listoPed.SetActive(true);
		yield return new WaitForSeconds(2.5f);
		_listoPed.SetActive(false);
		_status[2].color = new Color32(255, 255, 255, 255);
	}
}
}
