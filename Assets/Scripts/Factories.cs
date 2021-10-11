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
                case "Vegetariana": return new Vegetariana(orderInstance._pizQuant);
                case "Napolitana": return new Napolitana(orderInstance._pizQuant);
                default: return null;
            }
    	}
    }
}
