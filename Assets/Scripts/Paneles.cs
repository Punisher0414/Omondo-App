using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Paneles : MonoBehaviour
{
	public GameObject panel;
	public GameObject pActive;

	public GameObject addedMSG;

	public void Cerrar(){
   	panel.SetActive(false);
   }

	public void Abrir(){
   	panel.SetActive(true);
   }

   public void MsgActive(){
  	 	StartCoroutine(PopUpMsg());	
   }

   public void ShowAdded(){
	   StartCoroutine(AddedPopUp());
   }

   public void ChargeStart(){
	   SceneManager.LoadScene("Inicio", LoadSceneMode.Single);
   }

   public void ChargeAR(){
	   SceneManager.LoadScene("AR", LoadSceneMode.Single);
   }

   IEnumerator AddedPopUp(){
	   addedMSG.SetActive(true);
	   yield return new WaitForSeconds(1f);
	   addedMSG.SetActive(false);
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
