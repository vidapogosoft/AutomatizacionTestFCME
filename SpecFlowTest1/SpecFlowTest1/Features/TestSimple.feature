Feature: TestSimple
	Login en web site Demo QA

@mytag
Scenario: Login Exitoso
	Given Usuario se dirige a web site demoqa.com/login
	When usuario ingresa credenciales
	And realiza click en boton Login
	Then Login es exitoso

Scenario: Salir
	When usuario realiza LogOut
	Then Salio de aplicacion