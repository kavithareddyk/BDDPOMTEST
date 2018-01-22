Feature: Tests
	In order to get through the Online test
	As a automation test engineer
	I need to clear the below mentioned three tests

@Browser:Chrome
Scenario:homepage displays latestnews
	Given user lanuches the valTech website
     When user click on the readmore us
	 Then user should see the latest news displayed on the page

 @Browser:Chrome
Scenario Outline: Verify tmenu pages reflects the respective page title
  Given user lanuches the valTech website
  When user navigate to the tab menu <TabMenu>
  Then user should see the page title as <PageTitle>
Examples: 
| TabMenu     | PageTitle    |
| About       | About        |
| Services    | Services     |
| Work        | Work         |

@Browser:Chrome
Scenario: Contact page and count no offices
	 Given user lanches the valTech website
	 When user navigate to the Contacts page
	 Then usershould be able to calculate the number of offices
