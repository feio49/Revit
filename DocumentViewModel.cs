namespace Applications
{
  public class DocumentViewModel
  {
    private readonly IDocument document;
    
    public DocumentViewModel(IDocument document)
    {
      this.document = document;
    }
    
    void Delete(Item item) = document.Items.Remove(item.id);
}
