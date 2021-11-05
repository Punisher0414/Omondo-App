using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pizzas;

namespace Factories
{
    

    public interface Factory
    {
        Pizza CookPizza(string kind);
    }


public class PizzaFactory :  Factory
    {
        protected OrderList orderInstance;

    	public Pizza CookPizza(string kind)
    	{
            orderInstance = OrderList.GetInstance();

    		switch(kind) {
                case "Presumida": return new Presumida(orderInstance._pizQuant);
                case "Estirada": return new Estirada(orderInstance._pizQuant);
                case "Conchuda": return new Conchuda(orderInstance._pizQuant);
                case "Chismosa": return new Chismosa(orderInstance._pizQuant);
                case "Bichota": return new Bichota(orderInstance._pizQuant);
                case "Chocolate": return new Chocolate(orderInstance._pizQuant);
                case "Carnuda": return new Carnuda(orderInstance._pizQuant);
                case "Hierbabuena": return new Hierbabuena(orderInstance._pizQuant);
                case "Coco": return new Coco(orderInstance._pizQuant);
                case "Cereza": return new Cereza(orderInstance._pizQuant);
                default: return null;
            }
    	}
    }
}
