Feature: Test2
	Suma de dos numeros diferentes valores

@mytag
Scenario: Suma de 2 numeros
	Given el primer numero es 50
	And el segundo numero es 70
	When los dos numeros son sumados
	Then el resultado es 120


Scenario: Suma de 2 numeros distintos valores
	Given el primer numero es 90
	And el segundo numero es 70
	When los dos numeros son sumados
	Then el resultado es 160