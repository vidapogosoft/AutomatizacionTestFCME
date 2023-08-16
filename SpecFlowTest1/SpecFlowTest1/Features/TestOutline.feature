Feature: TestOutline
	Login en web site Demo QA con datos de entrada

@mytag
Scenario Outline: Login Exitoso con parametros
	Given Usuario se dirige a website demoqa.com/login 
	When para ingresar al site digita su usuario <username> y contraseña <password>
	And realiza click en boton Login para ingresar
	Then Login correcto

	Examples:
	| username   | password |
	| testuser_1 | Test@123 |