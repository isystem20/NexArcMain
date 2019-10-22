import { NEXARCTemplatePage } from './app.po';

describe('NEXARC App', function() {
  let page: NEXARCTemplatePage;

  beforeEach(() => {
    page = new NEXARCTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
