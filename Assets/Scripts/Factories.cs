using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pizzas;

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
                case "Mini": return new Vegetariana(1);
                case "Mediana": return new Vegetariana(2);
                case "Grande": return new Vegetariana(3);
                default: return null;
            }
    	}
    }
}
