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

   	public class Presumida: Pizza
   	{
   		public Presumida(int quant):
   			base("Pizza La Presumidad", 32000, "Base de tomate, queso, queso de búfala, queso azul, queso parmesano, tocineta, albahaca y tomate perla.", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }

   	}

   	public class Estirada: Pizza
   	{
   		public Estirada(int quant):
   			base("Pizza La Estirada", 33000, "Base de tomate, queso doble crema, queso bufala, queso azul, queso philadelphia y queso parmesano.", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}

   	public class Conchuda: Pizza
   	{
   		public Conchuda(int quant):
   			base("Pizza La Conchuda", 33000, "Base BBQ, queso, carne en BBQ de la casa, queso philadelphia y queso azul.", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}

   	public class Chismosa: Pizza
   	{
   		public Chismosa(int quant):
   			base("Pizza La Chismosa", 33000, "Base de tomate, queso, chorizo y chicharron caramelizados, madurito, maicitos y aguacate.", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}

   	public class Bichota: Pizza
   	{
   		public Bichota(int quant):
   			base("Pizza La Bichota", 35000, "Base de tomate, queso, albahaca fresca, tomate perla, queso philadelphia y burrata.", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}

   	public class Chocolate: Pizza
   	{
   		public Chocolate(int quant):
   			base("Pizza de Chocolate", 28000, "Base de chocolate, queso, lecherita, bocadillo y fresas.", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}

   	public class Carnuda: Pizza
   	{
   		public Carnuda(int quant):
   			base("Pizza La Carnuda", 32000, "Base de tomate, queso, jamon, salami, peperoni, cabano y tocineta.", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}

   	public class Hierbabuena: Pizza
   	{
   		public Hierbabuena(int quant):
   			base("Limonada de Hierbabuena", 6500, "", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}

   	public class Coco: Pizza
   	{
   		public Coco(int quant):
   			base("Limonada de Coco", 8000, "", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}

   	public class Cereza: Pizza
   	{
   		public Cereza(int quant):
   			base("Limonada de Cereza", 6500, "", quant){
          orderInstance._pizOrder.Add(this);
          Debug.Log(orderInstance._pizOrder.Count);
   			}

		  protected override void PrintIngr(){
			   Debug.Log(Ingr);
		  }
   	}
}
