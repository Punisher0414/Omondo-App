using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    protected OrderList orderInstance;
	public GameObject _listoPed;
	private Image[] _status = new Image[3];
    
    void Start(){
    	orderInstance = OrderList.GetInstance();

        _status[0] = GameObject.Find("EnFila").GetComponent<Image>();
        _status[1] = GameObject.Find("Preparando").GetComponent<Image>();
        _status[2] = GameObject.Find("Listo").GetComponent<Image>();

    if(orderInstance._stateTrig){
			Debug.Log("LA CORRUTINA HA EMPEZADO");
        	StartCoroutine(StatesChange());
		}
    }

     IEnumerator StatesChange()
	{
		_status[0].color = new Color32(0, 130, 130, 255);
		Debug.Log("En fila");
		yield return new WaitForSecondsRealtime(10);

		_status[0].color = new Color32(255, 255, 255, 255);
		_status[1].color = new Color32(0, 130, 130, 255);
		Debug.Log("Preparando");
		yield return new WaitForSecondsRealtime(10);
		StopCoroutine(StatesChange());

		_status[1].color = new Color32(255, 255, 255, 255);
		_status[2].color = new Color32(0, 130, 130, 255);
		Debug.Log("Listo");
		yield return new WaitForSecondsRealtime(10);
		_listoPed.SetActive(true);
		yield return new WaitForSeconds(2.5f);
		_listoPed.SetActive(false);
		_status[2].color = new Color32(255, 255, 255, 255);
	}
}
