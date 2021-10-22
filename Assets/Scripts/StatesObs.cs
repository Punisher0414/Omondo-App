using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatesObs : MonoBehaviour
{
	//Observaría la lista.
    //Necsita de un me´todo
    //Cada objeto observable tiene al observador

	//protected OrderList orderInstance;
	/*private Image[] _status = new Image[3];

    void Start()
    {
        //orderInstance = OrderList.GetInstance();
        _status[0] = GameObject.Find("EnFila").GetComponent<Image>();
        _status[1] = GameObject.Find("Preparando").GetComponent<Image>();
        _status[2] = GameObject.Find("Listo").GetComponent<Image>();

        StartCoroutine(StatesChange());

        Debug.Log("Me inicié");

    }*/

    /*public void BeginState(){
    	if(la lista tiene info){
    		StartCoroutine(States());
    	}
    }
    */

    /*IEnumerator StatesChange()
	{
		 Debug.Log("ola wapo");
		_status[0].color = new Color32(0, 130, 130, 255);
		Debug.Log("En fila");
		yield return new WaitForSecondsRealtime(5);

		_status[2].color = new Color32(0, 130, 130, 255);
		Debug.Log("En fila");
		yield return new WaitForSecondsRealtime(5);

		_status[3].color = new Color32(0, 130, 130, 255);
		Debug.Log("En fila");
		yield return new WaitForSecondsRealtime(5);
	}*/
}
