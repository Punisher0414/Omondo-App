using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Factories;
using Pizzas;

    //Aquí están incluidas todas las funciones de los botones, en la pantalla de AR.
public class Ordering : MonoBehaviour
    {

    	protected int _pizNum = 0;
    	public Text _pizTotal;
    	protected Text _name;
        protected OrderList orderInstance;
        private List<GameObject> _goTxts = new List <GameObject>();
        private List<String> _stringTxts = new List <String>();

        void Awake()
        {
            //_name se refiere al nombre de la pizza del target que aaprece en ese momento.o . Sirve para que cuando aaprezca la pizza en específico
            //esto sirve para no tener que referirse a cada nombre, sino al que aparezca en pantalla.
            //Pipo, para lo que usted tiene que hacer, póngale la etiqueta de "PizzaName" a todos los nombres de las pizzas
            //que aparecen con AR. De esta manera, lee el nombre y se lo pasa al Factory (ver método AddOrder).

            _name = GameObject.FindWithTag("PizzaName").GetComponent<Text>();
            orderInstance = OrderList.GetInstance();

            //Como las listas son estúpidas y tercas con la clase System.Collections.Generic y les vale un carajo UnityEngine.UI, entonces
            //tuve que crear una lista de objetos que contienen los textos donde se imprimen los pedidos y
            //luego esos objetos los pasé a una lista de strings que tiene el componente text.
            //Y con Add, no usen Add.Range, es una mierda (a veces(en este caso lo es)).

            _goTxts.AddRange(GameObject.FindGameObjectsWithTag("stringTxt"));

            for (int i = 0; i < _goTxts.Count; i++)
            {
                _stringTxts.Add(_goTxts[i].GetComponent<Text>().text);
                Debug.Log("Listo " + _goTxts.Count + " " + _stringTxts.Count);
            }
    		
    	}

       	public void AddPiz()
        {
        	if(_pizNum<3){
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

            while (_pizNum > 0){
                PizzaFactory PF = new PizzaFactory();
                Pizza PNew = PF.CookPizza(_name.text);

                _pizNum -= 1;
            }

            foreach(Pizza piz in orderInstance._pizOrder){
                for (int i = 0; i < orderInstance._pizOrder.Count; i++){
                    _stringTxts[i] = piz.Name;
                    //PruebaTexto[i].text = piz.Name;
                    Debug.Log(piz.Name + " " + piz.Price + " " + _stringTxts[i]);
                }
                
            }
        }
}
   /*public void PrintOrder(){
        //Imprimir con un For y al final sumar.
        //_TxtoName = NombrePizza;
        //_TxtPrice = PrecioPizza;
        //_TxtoName = NombrePizza;
        //_TxtPrice = PrecioPizza;

    }*/

 




    //Para no tener que hacer un ciclo para cada tipo de pizza, hacer un string name, que devuelva el nombre de esa pizza. Así como Pizza PN_Mini = PizzasAbstractFactory.GetLaboratory(name).CookPizza("Mini");
    //Así que al darle al botón, debe devolver el nombre de la pizza. Un método que haga eso. Como coger el tag del name que aparece en pantalla, dependiendo de la pizza.
