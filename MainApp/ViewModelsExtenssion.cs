using System.Collections.Generic;
using System.Linq;

public static class ProductExtensions
{
    public static IEnumerable<ProductViewModel> ToProductViewModels(this IEnumerable<ProductDb> source)
    {
        return source.Select(db => new ProductViewModel
        {
            Id = db.Id,
            Name = db.Name,
            Cost = db.Cost
        });
    }
}