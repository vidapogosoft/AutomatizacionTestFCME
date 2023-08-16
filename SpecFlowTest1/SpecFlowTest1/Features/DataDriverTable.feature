Feature: DataDriverTable
	Login en web site Demo QA 3

@mytag1
Scenario: Login Exitoso con parametros DataTable
	Given Usuario ingresa a website demoqa.com/login 
	When digita sus credenciales de acceso
	| Username   | Password |
	| testuser_1 | Test@123 |
	And realiza click en Login para ingresar
	Then Ingreso correcto