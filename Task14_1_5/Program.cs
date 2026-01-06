var companies = new Dictionary<string, string[]>();

companies.Add("Apple", new[] { "Mobile", "Desktop" });
companies.Add("Samsung", new[] { "Mobile" });
companies.Add("IBM", new[] { "Desktop" });

var mobileCompanies = from company in companies
                      from type in company.Value
                      where type == "Mobile"
                      select new
                      {
                          company.Key,
                          company.Value = "Mobile"
                      }
                                ;

foreach (var compan in mobileCompanies)
{
    Console.WriteLine(compan );
}
