describe('My First Test suite', () => {
    it('My first test case!', () => {
      cy.visit(" http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
      cy.get('#UserName').type('hari');
      cy.get('#Password').type('123123');
      cy.get('.btn').click();
      cy.get('#maxbutton').should('have.text','Maximise');
      
    })
  })