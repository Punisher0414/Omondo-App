using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Factories;
using Pizzas;

public class Order : MonoBehaviour
{
	protected int _pizNum = 0;
	public Text _pizTotal;
	protected Text _name;

	void Awake()
	{
		_name = GameObject.FindWithTag("PizzaName").GetComponent<Text>();
	}

   	public void AddPiz()
    {
    	if(_pizNum<5){
    	_pizNum += 1;
    	_pizTotal.text = _pizNum.ToString(); 
    	}
    }

   public void SubtPiz()
    {
    	if(_pizNum>0){
    	_pizNum -= 1;
    	_pizTotal.text = _pizNum.ToString(); 
    	}
    }

    public void AddOrder(){

        //System.Convert.ToInt32(_pizNum);

        while (_pizNum > 0 && _pizNum < 5){
            Pizza PN_Mini = PizzasAbstractFactory.GetLaboratory(_name.text).CookPizza("Mini");
            Debug.Log("Pizza mini a la roden, doña");
        }
    	//While TextNum is >0, create that number of pizzas.
    	//Pizza PN_Mini = PizzasAbstractFactory.GetLaboratory(_name).CookPizza("Mini");

    }

    /*public void AddOrder(){

    }*/
    
    //Para no tener que hacer un ciclo para cada tipo de pizza, hacer un string name, que devuelva el nombre de esa pizza. Así como Pizza PN_Mini = PizzasAbstractFactory.GetLaboratory(name).CookPizza("Mini");
    //Así que al darle al botón, debe devolver el nombre de la pizza. Un método que haga eso. Como coger el tag del name que aparece en pantalla, dependiendo de la pizza.
}
