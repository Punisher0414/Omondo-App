using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Pizzas
{
	public abstract class Pizza
	{
  		//Variables
  		private string _name;
      private int _price;
      private string _ingr;
      private int _quant;

      protected OrderList orderInstance;

    	//Constructor.
      public Pizza (string name, int price, string ingr, int quant)
      {
      	_name = name;
        _price = price;
      	_ingr = ingr;
        _quant = quant;
        

        orderInstance = OrderList.GetInstance();
        	//PrintIngr();
   		}

   		//Modificadores.
		  public string Name{
    		get {return _name;}
    		set {_name = value;}
    	}

      public int Price{
        get {return _price;}
        set {_price = value;}
      }

    	public string Ingr{
   			get { return _ingr; }
        	set { _ingr = value; }
   		}

      public int Quant{
        get {return _quant;}
        set {_quant = value;}
      }



      protected abstract void PrintIngr();
	}

   	public class Napolitana : Pizza
    {
      //Constructor.
   		public Napolitana(int quant):
   			base("Pizza Napolitana", 32000, "Base de tomate, queso, albahaca fresca, tomate y pesto", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
        }

      protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }

   	}

   	public class Vegetariana: Pizza
   	{
   		//Constructor.
   		public Vegetariana(int quant):
   			base("Pizza Vegetariana", 30000, "Base de tomate, queso, champiñón, maíz y piña", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		protected override void PrintIngr(){
			Debug.Log(Ingr);
		}

   	}
}
