# Hill Cipher Message Encoder/Decoder

Este proyecto es una implementación del método de cifrado y descifrado Hill en C#.

## Descripción

El método de Hill es un cifrado polialfabético que usa álgebra lineal para codificar y descodificar mensajes. Esta implementación específica permite cifrar un mensaje dado y descifrarlo usando matrices definidas por el usuario.

## Estructura del Proyecto

- `Program.cs`: Contiene la lógica principal para la codificación y descodificación de mensajes usando matrices.
- `ImprimirMatriz(int[,] matriz)`: Función auxiliar para imprimir matrices.
- `ImprimirMOD(int[,] matriz)`: Función auxiliar para imprimir matrices con valores mod 26 y convertir esos valores en letras.

## Uso

1. **Codificación:**
   - Sustituye los espacios en tu mensaje original por 'X'.
   - Convierte cada letra a su valor numérico correspondiente (A=0, B=1, ..., Z=25).
   - Llena la matriz de mensaje con estos valores.
   - Multiplica la matriz del mensaje por la matriz llave definida.
   - Aplica el módulo 26 a la matriz resultante para obtener los valores dentro del rango del alfabeto.
   - Convierte estos valores numéricos a letras para obtener el mensaje cifrado.

2. **Descodificación:**
   - Convierte el mensaje cifrado a sus valores numéricos correspondientes.
   - Multiplica esta matriz por la inversa de la matriz llave.
   - Aplica el módulo 26 a la matriz resultante para obtener los valores dentro del rango del alfabeto.
   - Convierte estos valores numéricos a letras para obtener el mensaje original.


## Cómo Ejecutar

1. Clona este repositorio.
2. Abre el proyecto en tu IDE favorito.
3. Ejecuta el proyecto.


```bash
git clone https://github.com/tu-usuario/nombre-del-repositorio.git
cd nombre-del-repositorio 

```
## Contribuciones
Las contribuciones son bienvenidas. Por favor, abre un issue para discutir cualquier cambio significativo antes de hacer una solicitud de extracción.
