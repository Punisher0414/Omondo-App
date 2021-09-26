using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Factories;
using Pizzas;

public class Main : MonoBehaviour
{
   void Start()
   {
   	//Pizas Napolitanas.
   	Pizza PN_Mini = PizzasAbstractFactory.GetLaboratory("Napolitana").CookPizza("Mini");
   	Pizza PN_Mediana = PizzasAbstractFactory.GetLaboratory("Napolitana").CookPizza("Mediana");
   	Pizza PN_Grande = PizzasAbstractFactory.GetLaboratory("Napolitana").CookPizza("Grande");

   	//Pizzas Medianas.
   	Pizza PV_Mini = PizzasAbstractFactory.GetLaboratory("Vegetariana").CookPizza("Mini");
   	Pizza PV_Mediana = PizzasAbstractFactory.GetLaboratory("Vegetariana").CookPizza("Mediana");
   	Pizza PV_Grande = PizzasAbstractFactory.GetLaboratory("Vegetariana").CookPizza("Grande");
   }
}
