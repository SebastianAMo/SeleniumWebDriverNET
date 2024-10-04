# SeleniumWebDriverNET

# SeleniumWebDriverNET Project

Este proyecto utiliza **SpecFlow**, **Selenium WebDriver**, y **LivingDoc** para generar documentación a partir de pruebas automatizadas. Este README describe los comandos necesarios para limpiar el proyecto, compilarlo, ejecutar las pruebas, y generar la documentación LivingDoc.

## Prerrequisitos

Aseg�rate de tener instalados los siguientes componentes:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SpecFlow LivingDoc CLI](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/Getting-Started.html)

Puedes instalar SpecFlow LivingDoc CLI usando el siguiente comando:

```bash
dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI
```


Limpieza del proyecto
Para limpiar el proyecto y eliminar los archivos binarios antiguos, utiliza el siguiente comando:

```bash
dotnet clean
```
Restauración de paquetes NuGet
Si has agregado nuevos paquetes o deseas asegurarte de que todos los paquetes necesarios están correctamente instalados, ejecuta:

```bash
dotnet restore
```
Compilaci�n del proyecto
Para compilar el proyecto despu�s de haber limpiado y restaurado los paquetes, ejecuta:

```bash
dotnet build
```

Ejecución de pruebas
Para ejecutar las pruebas y generar los resultados que se utilizarán en LivingDoc, utiliza el siguiente comando. Este comando generará un archivo TestExecution.json necesario para LivingDoc:

```bash
dotnet test --logger "trx;LogFileName=TestExecution.trx" --results-directory ./bin/Debug/net8.0
```
Generación de LivingDoc con resultados de prueba
Una vez que las pruebas se hayan ejecutado correctamente, puedes generar la documentaci�n LivingDoc. Usa el siguiente comando para crear un archivo HTML con la documentación generada a partir de las pruebas ejecutadas:

```bash
livingdoc test-assembly ./bin/Debug/net8.0/SeleniumWebDriverNET.dll -t ./bin/Debug/net8.0/TestExecution.json --output ./bin/Debug/net8.0/LivingDocReport.html
```

Visualizaci�n del reporte LivingDoc
Despu�s de generar la documentaci�n, puedes abrir el archivo HTML generado para ver el reporte. Usa el siguiente comando para abrir el archivo en tu navegador:

```bash
start ./bin/Debug/net8.0/LivingDocReport.html
```
Comandos opcionales
Limpiar binarios despu�s de generar LivingDoc
Si deseas limpiar nuevamente los binarios del proyecto despu�s de generar el reporte de LivingDoc, puedes ejecutar:

```bash
dotnet clean
```
Generación de LivingDoc con un título personalizado
Si quieres darle un título personalizado al reporte de LivingDoc, puedes utilizar el siguiente comando:

```bash
livingdoc test-assembly ./bin/Debug/net8.0/SeleniumWebDriverNET.dll -t ./bin/Debug/net8.0/TestExecution.json --title "Selenium WebDriver Project" --output ./bin/Debug/net8.0/LivingDocReport.html
```

Ejecuci�n de caracter�sticas espec�ficas (features) o tags
Si deseas ejecutar solo caracter�sticas (features) espec�ficas o usar tags para filtrar las pruebas, puedes hacerlo con estos comandos:

Ejecutar una feature específica:
```bash

dotnet test --filter FullyQualifiedName~Login.feature
```
Ejecutar escenarios con tags espec�ficos:

```bash
dotnet test --filter TestCategory=important
```
Ejecutar con multiples tags (OR):

```bash
dotnet test --filter TestCategory=smoke
```