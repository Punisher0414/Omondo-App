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

      protected OrderList orderInstance;

    	//Constructor.
      public Pizza (string name, int price, string ingr)
      {
      	_name = name;
        _price = price;
      	_ingr = ingr;
        

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


      protected abstract void PrintIngr();
	}

   	public class Napolitana : Pizza
    {
      //Constructor.
   		public Napolitana():
   			base("Pizza Napolitana", 30000, "Base de tomate, queso, albahaca fresca, tomate y pesto"){
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
   		public Vegetariana():
   			base("Pizza Vegetariana", 28000, "Base de tomate, queso, champiñón, maíz y piña"){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		protected override void PrintIngr(){
			Debug.Log(Ingr);
		}

   	}
}
