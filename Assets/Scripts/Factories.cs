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
    	public Pizza CookPizza(string kind)
    	{

    		switch(kind) {
                case "Vegetariana": return new Vegetariana();
                case "Napolitana": return new Napolitana();
                case "Dulce": return new Napolitana();
                default: return null;
            }
    	}
    }
}
