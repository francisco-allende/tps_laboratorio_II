# tps_laboratorio_II
Francisco Allende Division 2A turno mañana 2022

## Correcciones TPS

**TP1 y TP4 aprobados, solo recupero TP2 y TP3**
**En la carpeta Recuperatorio-fecha-finales** se encuentran los tps a recuperar. Las carpetas que se llaman "recuperatorio" tambien poseen estos trabajos, las dejo por las dudas que conste que estaban subidos y rehechos con anterioridad.


### Mis correcciones en el TP2 son:

No cumple con salida por pantalla. Operador - incompleto. No aplica polimorfismo en Listar. 
Utilizar polimorfismo para $"TAMAÑO : {this.Tamanio}"
Sedan no reutiliza los constructores de forma adecuada
if (v.Tamanio == Vehiculo.ETamanio.Chico) la comparación está muy mal. Tenés que chequear el tipo del objeto, la propiedad puede tener el mismo valor en
otros objetos.

**A la cual se agrega una consigna general para todos los que tengan que recuperar TP2:**

Para recuperatorio, modificar estas líneas en el Program.cs para hacer más explícito uno de sus errores
// Quito 2 items y muestro
taller -= c1;
taller -= new Ciclomotor(Vehiculo.EMarca.HarleyDavidson, "LEM666", ConsoleColor.Red);
No sobreescribir Equals ni nada que no se pida

TODAS LAS CORRECCIONES SE ENCUENTRAS APLICADAS EN EL TP2


### Mis correcciones TP3:

Gestión de heladeria - no puede llamarse Form1.cs
Hay 2 tests que rompen.
La nomenclatura de las excepciones es ItemNoSeleccionadoException, también podrías ponerle un
mensaje personalizado.
No es necesario que guardes lo mismo en los tres tipos de archivos. Json, XML y txt cada uno tienen
un uso diferente.
Es un poco engorroso que en cada paso de tomar un pedido haya que confirmar todo, pensá que si
es alguien que atiende al público y necesita hacer muchos pasos para hacer una venta es probable
que genere demoras, no es muy ágil. Buscale la vuelta a esa parte

TODAS LAS CORRECCIONES SE ENCUENTRAS APLICADAS EN EL TP3
