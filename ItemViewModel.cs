using System;
using System.ComponentModel.Composition;

namespace Feio
{
  public class ItemViewModel
  {
    private readonly IItem item;
    private readonly IContentService contentService;
    private readonly IViewModelFactory viewModelFactory;
    
    private DelegateCommand copyCommand;
    private DelegateCommand deleteCommand;
    
    public ItemViewModel(IItem item, DocumentViewModel dvm, IContentService contentService, IViewModelFactory viewModelFactory)
    {
      this.item = item;
      
      this.contentService = contentService;
      
      this.viewModelFactory = viewModelFactory;
      
      deleteCommand = new DelegateCommand(() => item.Document.Items.Remove(item.Id));
    }
    
    public ICommand DeleteCommand => deleteCommand;
    
    public void Show() => contentService.Show(factory.Create(item));
    {
      var viewModel = factory.Create(item);
      
      contentService.Show(viewModel);
    }
  }
}
