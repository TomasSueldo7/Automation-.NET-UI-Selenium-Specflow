@Ok_Run
Feature: Log in
	Como usuario comprador
	Quiero iniciar sesión en la aplicación
	Para hacer uso de las funcionalidades de la misma

@HappyPath 
Scenario: The user logs in and out successfully with username and password
	Given the user is in the website
	When the user logs in with email & password 
	Then the system shows the home page
	When the user logs out
	Then the system shows the log in page

@Alternative 
Scenario: The user does not log in due to an incorrect password
	Given the user is in the website
	When the user logs in with email student & password 123
	Then the system shows a login error message

@Alternative 
Scenario: The user does not log in due to an incorrect username
	Given the user is in the website
	When the user logs in with email prueba & password Password123
	Then the system shows a login error message

@Alternative
Scenario: The user tries to log in without email and password
	Given the user is in the website
	When the user logs in with email " " & password " "
	Then the system shows a login error message