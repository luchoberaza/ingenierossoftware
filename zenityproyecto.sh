#!/bin/bash

variable=$(zenity --list --title="Que es lo que quiere hacer" --width="340" --height="200" --radiolist  \
--column=" " --column="Opción a elegir"  \
FALSE "Buscar Producto" \
FALSE "Buscar Cliente" \
FALSE "Salir"
)

case $variable in
"Buscar Producto") 
    nombreproducto=$(zenity --entry --title="Ingrese ID del Producto" --width=250 --height=160 --ok-label="Aceptar" --cancel-label="Cancelar" --text="¿Cual es el nombre del producto?")
    read=$nombreproducto
    echo "SELECT 'ID.Prod', Stock, Descripcion, PrecioUnitario FROM producto_venta where Descripcion='$nombreproducto'" | sudo mysql proyecto -N | tr '\t' '\n' | zenity --list --title="Producto en venta" --text=" " --column="ID.PROD" --column="Stock" --column="Descripcion" --column="Precio Unitario" --height=180 --width=450;
    ;;
"Buscar Cliente")
    nomcliente=$(zenity --entry \
                --title="Ingrese ID" \
                --width=250 \
                --height=160 \
                --ok-label="Aceptar" \
                --cancel-label="Cancelar" \
                --text="¿Cual es el nombre del cliente?")
read=$nomcliente


echo "SELECT 'ID.CLI', Nombre, Direccion, Telefono, Saldo FROM cliente where Nombre='$nomcliente'" | sudo mysql proyecto -N | tr '\t' '\n' | zenity --list --title="Cliente" --text=" " --column="ID Cliente" --column="Nombre" --column="Direccion" --column="Telefono" --column="Saldo" --height=180 --width=450;

    ;;
"Salir")
    zenity --info --title="Saliendo..." --text="Adios"
    ;;
    
esac
