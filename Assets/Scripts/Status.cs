using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Pizzas;

public class Status : MonoBehaviour
{
    protected OrderList orderInstance;
	public GameObject _listoPed;
	private Image[] _status = new Image[3];
	public GameObject _buttEnFila;
	public GameObject _buttPrepa;
	public GameObject _buttDone;
	public GameObject _cancelMSG;
    
    void Start(){
    	orderInstance = OrderList.GetInstance();

        _status[0] = GameObject.Find("EnFila").GetComponent<Image>();
        _status[1] = GameObject.Find("Preparando").GetComponent<Image>();
        _status[2] = GameObject.Find("Listo").GetComponent<Image>();

        if(orderInstance._sent){
        	_buttEnFila.SetActive(true);
        	_buttPrepa.SetActive(true);
        	_buttDone.SetActive(true);
        }
    }

	public void StartCo(){
        
        Debug.Log("LA CORRUTINA HA EMPEZADO");
	}

	public void CancelarPedido(){
		orderInstance._pizOrder = new List<Pizza>();
		DeactivateButt();
		StartCoroutine(CancelPopUp());
	}

	public void DeactivateButt(){
		_buttEnFila.SetActive(false);
        _buttPrepa.SetActive(false);
        _buttDone.SetActive(false);
	}

	IEnumerator CancelPopUp(){
		if (_cancelMSG != null)
		{
			_cancelMSG.SetActive(true);
			yield return new WaitForSeconds(2.5f);
			_cancelMSG.SetActive(false);			
		}
	}

	public void EnFila(){
		_status[1].color = new Color32(255, 255, 255, 255);
		_status[2].color = new Color32(255, 255, 255, 255);

		_status[0].color = new Color32(0, 130, 130, 255);
		Debug.Log("En fila");
	}

	public void Preparando(){
		_status[0].color = new Color32(255, 255, 255, 255);
		_status[2].color = new Color32(255, 255, 255, 255);

		_status[1].color = new Color32(0, 130, 130, 255);
		Debug.Log("Preparando");
	}

	public void Listo(){
		_status[1].color = new Color32(255, 255, 255, 255);
		_status[0].color = new Color32(255, 255, 255, 255);

		_status[2].color = new Color32(0, 130, 130, 255);
		Debug.Log("Listo");
		StartCoroutine(Done());
		orderInstance._pizOrder = new List<Pizza>();
		DeactivateButt();
	}

     IEnumerator Done()
	{
		yield return new WaitForSecondsRealtime(0.5f);
		_listoPed.SetActive(true);
		yield return new WaitForSeconds(2);
		_listoPed.SetActive(false);
		_status[2].color = new Color32(255, 255, 255, 255);
	}
}
