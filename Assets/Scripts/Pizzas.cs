using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pizzas
{
	public abstract class Pizza
	{
		//Genéricos.
		private string _name;
    	private string _ingr;

      	//Prices.
      	private int _pSml;
		private int _pMid;
		private int _pLrg;
	
		protected int _size;

    	//Constructor.
    	public Pizza (string name, string ingr, int pSml, int pMid, int pLrg, int size)
    	{
    		_name = name;
    		_ingr = ingr;
        	_size = size;

        	_pSml = pSml;
        	_pMid = pMid;
        	_pLrg = pLrg;

        	GetSize();
        	PrintIngr();
   		}

   		//Modificadores.
		public string Name{
    		get {return _name;}
    		set {_name = value;}
    	}

    	public string Ingr{
   			get { return _ingr; }
        	set { _ingr = value; }
   		}


    	public int PSml{
    		get {return _pSml;}
    		set {_pSml = value;}
    	}

    	public int PMid{
    		get {return _pMid;}
    		set {_pMid = value;}
    	}

    	public int PLrg{
    		get {return _pLrg;}
    		set {_pLrg = value;}
    	}

      protected abstract void GetSize();
      protected abstract void PrintIngr();
	}

   	public class Napolitana : Pizza
    {
      //Constructor.
   		public Napolitana (int size = 1):
   			base("Napolitana", "Base de tomate, queso, albahaca fresca, tomate y pesto", 15000, 25000, 35000, size){}

     
     	protected override void GetSize(){
         	switch (_size){
          	case 1:
          	Debug.Log("La pizza Napolitana Mini cuesta :" + PSml);
          	break;
          	case 2:
          	Debug.Log("La pizza Napolitana Mediana cuesta :" + PMid);
          	break;
          	case 3:
          	Debug.Log("La pizza Napolitana Grande cuesta :" + PLrg);
          	break;
          	default:
          	Debug.Log("No se ha pedido pizza");
          	break;
        }
      }

      protected override void PrintIngr(){
			Debug.Log(Ingr);
		}

   	}

   	public class Vegetariana: Pizza
   	{
   		//Constructor.
   		public Vegetariana (int size = 1):
   			base("Vegetariana", "Base de tomate, queso, champiñón, maíz y piña", 13000, 23000, 33000, size){}
     
     	protected override void GetSize(){
         	switch (_size){
          	case 1:
          	Debug.Log("La pizza Vegetariana Mini cuesta :" + PSml);
          	
          	break;
          	case 2:
          	Debug.Log("La pizza Vegetariana Mediana cuesta :" + PMid);
          	break;
          	case 3:
          	Debug.Log("La pizza Vegetariana Grande cuesta :" + PLrg);
          	break;
          	default:
          	Debug.Log("No se ha pedido pizza");
          	break;
        	}
      	}

		protected override void PrintIngr(){
			Debug.Log(Ingr);
		}

   	}
}
