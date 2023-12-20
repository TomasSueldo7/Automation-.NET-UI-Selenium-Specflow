Selenium .Net - BaseFramework
=================================================================================================================
##Prerequisitos

#Instalación de programas requeridos

Previo a correr las pruebas se deben tener instalados los siguientes programas:

- [Node] (https://nodejs.org/en) --> Para verificar la instalación del programa abra una terminal y coloque el comando "node --version"
- [.NET] (https://dotnet.microsoft.com/es-es/download) --> Entorno de ejecución necesario. Si posee VS, considereló ya instalado


Los siguientes programas son opcionales (su función esta descrita junto con ellos):

-[Specflow] (https://docs.specflow.org/projects/getting-started/en/latest/GettingStarted/Step1.html) --> En caso de utilizar Visual Studio como IDE

#Dependencias utilizadas
El proyecto utiliza las siguientes dependencias. Para la instalación manual de cada una de las dependencias se puede usar Install-Package [NombreDelPaquete] -Version [X.Y.Z].
Caso contrario dirigirse a "Comandos útiles" (sección inferior) para usar el archivo .csproj para la instalación de los paquetes a través de -NET.

- Appium.WebDriver (4.4.5)
- DotNetSeleniumExtras.WaitHelpers (3.11.0)
- FluentAssertions (6.12.0)
- Microsoft.NET.Test.Sdk (17.7.2)
- nunit (3.13.3)
- NUnit3TestAdapter (4.5.0)
- Selenium.WebDriver (3.141.0)
- Selenium.WebDriver.ChromeDriver (118.0.5993.7000)
- SpecFlow.NUnit (3.9.74)
- SpecFlow.Plus.LivingDocPlugin (3.9.57)


##Configuración de parámetros de Test
Para la ejución de los test es necesario configurar correctamente los parámetros del archivo Test.runsettings (.\Enviroment\XmlFiles\[ArchivoDeConfiguracion].runsettings) con los siguientes valores:

	WebSite: Dirección web donde se harán las pruebas
	User: Nombre de usuario válido para ingresar a la web
	Password: Contraseña válida para el usuario cargado


Ejemplo:

	<?xml version="1.0" encoding="utf-8"?>
	<RunSettings>
		<RunConfiguration>
			<TestAdapters>
				<TestAdapter Framework="dotnet" />
			</TestAdapters>
		</RunConfiguration>
		<TestRunParameters>
			<Parameter name="WebSite" value="https://practicetestautomation.com/practice-test-login/" />
			<Parameter name="User" value="student" />
			<Parameter name="Password" value="Password123" />
		</TestRunParameters>
	</RunSettings>

##Ejecución de Pruebas

#Ejecución con explorador de pruebas de VS

En caso de querer utilizar el explorador de pruebas de visual studio, se debe configurar manualmente la dirección del archivo en 
Prueba > Configurar parametros de ejución > Selecciónar el XML correspondiente


#Comandos útiles
- Comando para la instalación de dependencias mediante .NET: dotnet build
- Comando para ejecutar todas las pruebas: dotnet test
- Comando para ejecutar las pruebas bajo una etiqueta (Ejemplo: @Ok_Run): dotnet test --filter Category=@Ok_Run
- Comando para ejecutar un archivo de runSettings en especifico: dotnet test --settings [ruta del .runsettings]
- Combinación de anteriores: dotnet test --filter Category=@Ok_Run --settings [ruta del .runsettings]
