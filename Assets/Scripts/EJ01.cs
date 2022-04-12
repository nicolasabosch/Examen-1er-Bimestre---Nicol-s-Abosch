using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Se pide que se ingrese por inspector:
. Los nombre de tres productos
. Los precios de cada producto
. La cantidad de unidades deseada de cada producto

El programa debe cumplir los siguientes requerimientos:

Debe calcularse un descuento del 20% sobre la compra de un producto si la cantidad de unidades del mismo supera las 3. 

El programa debe devolver un mensaje de error descriptivo si el precio del producto o la cantidad de unidades son menores a 1.

El programa debe devolver el total de la compra de los tres productos mostrando un mensaje que incluya el monto total sin descuento

El monto de los descuentos aplicados y el total con los descuentos aplicados.
*/

public class EJ01 : MonoBehaviour
{

    public string prdct1;
    public string prdct2;
    public string prdct3;

    public float prdct1Precio;
    public float prdct2Precio;
    public float prdct3Precio;

    public float prdct1Cantidad;
    public float prdct2Cantidad;
    public float prdct3Cantidad;



    void Start()
    {

        float prdct1Precio2 = prdct1Precio;
        float prdct2Precio2 = prdct2Precio;
        float prdct3Precio2 = prdct3Precio;

        if (prdct1Cantidad >= 3)
        {
            prdct1Precio2 = (prdct1Precio2 - (prdct1Precio2 * 20) / 100);
        }

        if (prdct1Cantidad < 1)
        {
            Debug.Log("Debes agregar por lo menos 1 en cantidad de el 1er producto");
            prdct1Cantidad = 0;
        }

        if (prdct2Cantidad >= 3)
        {
            prdct2Precio2 = (prdct2Precio2 - (prdct2Precio2 * 20) / 100);
        }
        if (prdct2Cantidad < 1)
        {
            Debug.Log("Debes agregar por lo menos 1 en cantidad de el 2do producto");
            prdct2Cantidad = 0;
        }
        if (prdct3Cantidad >= 3)
        {
            prdct3Precio2 = (prdct3Precio2 - (prdct3Precio2 * 20) / 100);
        }
        if (prdct3Cantidad < 1)
        {
            Debug.Log("Debes agregar por lo menos 3 en cantidad de el 1er producto");
            prdct3Cantidad = 0;
        }

        float sumaTotalSinDescuento = prdct1Precio + prdct2Precio + prdct3Precio;
        float sumaTotalDescuento = prdct1Precio2 + prdct2Precio2 + prdct3Precio2;
        float montoDescuento = sumaTotalSinDescuento - sumaTotalDescuento;

        Debug.Log("El monto total sin descuento es de $"  + sumaTotalSinDescuento + ", El monto a descontar es $" + montoDescuento + ", El total con descuento es de $" + sumaTotalDescuento);
    }


}
