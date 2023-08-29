Feature: Cuenta

A short summary of the feature

@tag1
Scenario: Debito de Cuenta con monto valido actualiza saldo
	Given Mi saldo inicial de dolares en cuenta es de 40
	When Se debita un monto en dolares de 10
	Then Saldo actual en cuenta de 30 
