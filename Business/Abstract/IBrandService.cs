using Business.Request.Brand;
using Business.Responses.Brand;

namespace Business.Abstract;

public interface IBrandService
{
    public AddBrandResponse Add(AddBrandRequest request);
    public GetBrandListResponse GetList(GetBrandListRequest rewuest);
}
