import { Dashboard_OxygenWebTemplatePage } from './app.po';

describe('Dashboard_OxygenWeb App', function() {
  let page: Dashboard_OxygenWebTemplatePage;

  beforeEach(() => {
    page = new Dashboard_OxygenWebTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
