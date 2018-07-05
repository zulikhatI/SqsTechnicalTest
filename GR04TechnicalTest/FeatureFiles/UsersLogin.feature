Feature: UsersLogin
	In order to access the Conduit Application
	As a user
	I want to be be able to sign up and login successfully

 Scenario: 01_Verify that a user is able to sign up an account
   Given a user is not logged in
   When user signs up
   Then the user is automatically logged in
   And the users name is displayed

Scenario: 02_Verify that a user is able to sign in successfully
  Given a user is not logged in 
  When the user signs in
  Then the user is logged in
  And the users name is displayed

Scenario: 03_Verify that a user is able to see global feeds and  popular tags on the home page
   #Given a user is not logged in
   When the home page is shown
   Then the global feeds and popular tags are displayed

Scenario: 04_Verify that a user is redirected to the Sign up page when the user like an article
    Given a user is not logged in
    When a user tries to like an article
    Then the user is directed to the Sign up area

Scenario: 05_Verify that a user is not able to sign up with existing username 
    Given a user is not logged in
    When a user tries to sign up with a username that already exists
    Then a validation error is displayed

Scenario: 06_Verify that a user is unable to sign up with existing email address 
   Given a user is not logged in
   When the user tries to sign up with an email address that already exists
   Then a validation error is displayed

Scenario: 07_Verify that a user is not able sign up with too short password
    Given a user is not logged in
    When the user tries to sign up with a password that is too short
    Then a validation error is displayed

Scenario: 08_Verify that a user is able to see Your Feeds section display by default
   Given a user is not logged in
   When user signs up
   Then the Your Feeds section should be displayed by default
   And the Your Feeds section should be empty

Scenario: 09_Verify that an existing user is able to see article information when a new article is created
  Given a user is logged in 
  When the user creates a new article
  Then the Article section is displayed with the article information
  And the Comment section is displayed 
