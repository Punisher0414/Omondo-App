using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneles : MonoBehaviour
{
	public GameObject panel;
	public GameObject pActive;
	public OrderList _Instance;

	public void Cerrar(){
   	panel.SetActive(false);
   }

	public void Abrir(){
   	panel.SetActive(true);
   }

	void Start () { 

		_Instance = OrderList.GetInstance();

	}

   public void MsgActive(){

	   _Instance._stateTrig = true; 
	
  	 	StartCoroutine(PopUpMsg());
		   

		
   }

	IEnumerator PopUpMsg(){
		if (pActive.activeSelf){
			pActive.SetActive(false);
		}
			panel.SetActive(true);
			yield return new WaitForSeconds(2.5f);
			panel.SetActive(false);
		
	}

}
