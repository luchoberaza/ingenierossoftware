#!/bin/bash
variable=$(zenity --list --title="Que es lo que quiere hacer" --width="340" --height="200" --radiolist  \
--column=" " --column="Opción a elegir"  \
FALSE "Buscar Producto" \
FALSE "Buscar Cliente" \
FALSE "Salir"
)

case $variable in
"Buscar Producto") 
    idproducto=$(zenity --entry --title="Ingrese ID del Producto" --width=250 --height=160 --ok-label="Aceptar" --cancel-label="Cancelar" --text="¿Cual es la ID?")
    read=$idproducto
    echo "SELECT * FROM producto_venta where IDPROD=${idproducto}" | sudo mysql proyecto -N | tr '\t' '\n' | zenity --list --title="Producto en venta" --text=" " --column="ID.PROD" --column="Stock" --column="Descripcion" --column="Precio Unitario" --height=180 --width=450;
    ;;
"Buscar Cliente")
    idcliente=$(zenity --entry \
                --title="Ingrese ID" \
                --width=250 \
                --height=160 \
                --ok-label="Aceptar" \
                --cancel-label="Cancelar" \
                --text="¿Cual es la ID?")
read=$idcliente


echo "SELECT * FROM cliente where IDCLI=${idcliente}" | sudo mysql proyecto -N | tr '\t' '\n' | zenity --list --title="Cliente" --text=" " --column="ID Cliente" --column="Nombre" --column="Direccion" --column="Telefono" --column="Saldo" --height=180 --width=450;

    ;;
"Salir")
    zenity --info --title="Saliendo..." --text="Adios"
    ;;
    
esac
