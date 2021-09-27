using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pizzas;
using Orders;

namespace Factories
{
    public class PizzasAbstractFactory
    {
    	public static PizzaFactory GetLaboratory(string kind)
    	{
    		switch (kind)
    		{
    			case "Napolitana": return new NapolitanaFactory();
    			case "Vegetariana": return new VegetarianaFactory();
    			default: return null;
    		}
    	}
    }


    public abstract class PizzaFactory{

    	public abstract Pizza CookPizza(string kind);
    }

    public class NapolitanaFactory :  PizzaFactory
    {
    	public override Pizza CookPizza(string kind)
    	{

    		switch(kind) {
                case "Mini": return new Napolitana(1);
                case "Mediana": return new Napolitana(2);
                case "Grande": return new Napolitana(3);
                default: return null;
            }
    	}
    }

	public class VegetarianaFactory :  PizzaFactory
    {
    	public override Pizza CookPizza(string kind)
    	{
    		switch(kind) {
                case "Mini": return new Vegetariana("Pizza Vegetariana Mediana", 23000, 2);
                //_pizOrder.Add(new Vegetariana("Pizza Vegetariana Mini", 13000, 1));
                //break;
               // case "Mediana": return new Vegetariana("Pizza Vegetariana Mediana", 0, 23000, 0, 2);
                //case "Grande": return new Vegetariana("Pizza Vegetariana Grande", 0, 0, 33000, 3);
                default: return null;
                //Debug.Log("No se ha pedido pizza");
                //break;
            }
    	}
    }
}
