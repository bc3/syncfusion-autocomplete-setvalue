using Syncfusion.Blazor;
using Index = SourcesBC3.Pages.Index;

namespace SourcesBC3.Data;

public class CountryAdapter : DataAdaptor
{
   public static List<Country> LocalData = new List<Country>
   {
      new Country() { Name = "Australia", Code = "AU" },
      new Country() { Name = "Bermuda", Code = "BM" },
      new Country() { Name = "Canada", Code = "CA" },
      new Country() { Name = "Cameroon", Code = "CM" },
      new Country() { Name = "Denmark", Code = "DK" },
      new Country() { Name = "France", Code = "FR" },
      new Country() { Name = "Finland", Code = "FI" },
      new Country() { Name = "Germany", Code = "DE" },
      new Country() { Name = "Greenland", Code = "GL" },
      new Country() { Name = "Hong Kong", Code = "HK" },
      new Country() { Name = "India", Code = "IN" },
      new Country() { Name = "Italy", Code = "IT" },
      new Country() { Name = "Japan", Code = "JP" },
      new Country() { Name = "Mexico", Code = "MX" },
      new Country() { Name = "Norway", Code = "NO" },
      new Country() { Name = "Poland", Code = "PL" },
      new Country() { Name = "Switzerland", Code = "CH" },
      new Country() { Name = "United Kingdom", Code = "GB" },
      new Country() { Name = "United States", Code = "US" },
   };

   public override object Read(DataManagerRequest dataManagerRequest, string key = null)
   {
      var filter = dataManagerRequest.Where[0].value.ToString();

      return LocalData.Where(x => x.Name.StartsWith(filter));
   }
}