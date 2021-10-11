using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    //protected OrderList orderInstance;
	public GameObject _listoPed;
	private Image[] _status = new Image[3];
	//private bool _stateTrig;

//Por alguna razón cuando lo pongo en Start o en Update, sólo hace esa línea y luego deja de funcioanr lo demás. ¿Qué sucede?
//Creo que es porque es static, pero entonces kiago?
//Pero en el script del Ordering sí funciona.
    
    void Start(){
    	//orderInstance = OrderList.GetInstance();
    	Debug.Log("TOMMY TE AMO SOS UN CRACK START");

        _status[0] = GameObject.Find("EnFila").GetComponent<Image>();
        _status[1] = GameObject.Find("Preparando").GetComponent<Image>();
        _status[2] = GameObject.Find("Listo").GetComponent<Image>();


        StateStart(); 

        /*if(orderInstance._stateTrig){
        	StateStart();}*/
    }


    private void StateStart(){
    	Debug.Log("Corrutina empezada");
    	StartCoroutine(StatesChange());
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
