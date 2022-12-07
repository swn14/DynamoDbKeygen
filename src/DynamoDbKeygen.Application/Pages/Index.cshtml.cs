using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DynamoDbKeygen.Application.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public DynamoDbKeyModel ViewModel;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        ViewModel = new DynamoDbKeyModel();
    }

    public void OnGet()
    {

    }
    
    public void OnPost()
    {
        ViewModel.RootNamespace = Request.Form["rootNamespace"];
        ViewModel.RootIdentifier = Request.Form["rootIdentifier"];
        ViewModel.DomainNamespace = Request.Form["domainNamespace"];
        ViewModel.DomainIdentifier = Request.Form["domainIdentifier"];
    }
}
