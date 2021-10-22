using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paneles : MonoBehaviour
{
	public GameObject panel;
	public GameObject pActive;

	public void Cerrar(){
   	panel.SetActive(false);
   }

	public void Abrir(){
   	panel.SetActive(true);
   }

   public void MsgActive(){
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
