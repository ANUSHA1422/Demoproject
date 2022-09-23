Feature: Login to Turnup portal
Scenario: Login to the Turnup portal page
   Given I have navigated to the Turnup portal page
   When I input Username
   And I input Password
   Then I should see the homepage displayed