<Query Kind="Statements">
  <Connection>
    <ID>cdd8df40-124a-4036-b06d-57d99ffd316a</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

var results = from data in BillItems
				//once group is used then details are aggregrates
              group data by new {cat = data.Item.MenuCategory.Description, dd= data.Item.Description} into g
                          //orderby data.Item.MenuCategory.Description, data.Item.Description
                          select new 
                          {
                              //BillDate = data.Key,
                              CatDescription = g.Key.cat, //data.Item.MenuCategory.Description,
                              ItemDescription = g.Key.dd,
                              Quantity = g.Sum( x=> x.Quantity),
                              Sales = g.Sum(x=> x.SalePrice * x.Quantity),
                              CostOfSales = g.Sum(x=> x.UnitCost * x.Quantity),
                          };
results.Count().Dump();
results.Dump();