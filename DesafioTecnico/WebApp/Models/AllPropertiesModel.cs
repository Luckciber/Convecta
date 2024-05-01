namespace WebApp.Models
{
    public class CurrenciesModel
    {
        public Item[] Items { get; set; }
        public long TotalPages { get; set; }
        public long TotalRecords { get; set; }
        public long PageNumber { get; set; }
        public long PageSize { get; set; }
        public long HttpCode { get; set; }
    }

    public class Item
    {
        public string PropertyTitle { get; set; }
        public Currency CurrencySale { get; set; }
        public Currency CurrencyRent { get; set; }
        public Currency CurrencySeasonalRental { get; set; }
        public string PriceSaleFormatted { get; set; }
        public string PriceRentFormatted { get; set; }
        public User User { get; set; }
        public Characteristics Characteristics { get; set; }
        public PropertyMedia[] PropertyMedia { get; set; }
        public long IdProperty { get; set; }
        public long IdUser { get; set; }
        public long IdClient { get; set; }
        public long IdType { get; set; }
        public long IdState { get; set; }
        public string WebAddress { get; set; }
        public bool Sale { get; set; }
        public bool Rent { get; set; }
        public bool SeasonalRental { get; set; }
        public string FirstImage { get; set; }
        public Uri FirstImageUrl { get; set; }
        public long PriceSale { get; set; }
        public long PriceRent { get; set; }
        public long PriceSeasonalRental { get; set; }
        public long IdCurrencySale { get; set; }
        public long IdCurrencyRent { get; set; }
        public long IdCurrencySeasonalRental { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public long Unit { get; set; }
        public Letter Letter { get; set; }
        public string Phase { get; set; }
        public string Role { get; set; }
        public long IdBorough { get; set; }
        public long IdSector { get; set; }
        public string CoordinatesLat { get; set; }
        public string CoordinatesLong { get; set; }
        public bool Featured { get; set; }
        public bool OnWeb { get; set; }
        public string Observations { get; set; }
        public string InternalObservations { get; set; }
        public string WayToVisit { get; set; }
        public bool ShowMapOnWeb { get; set; }
        public bool SendCoordinatesToPortals { get; set; }
        public bool MarkAsSale { get; set; }
        public bool MarkAsRent { get; set; }
        public bool Visible { get; set; }
    }

    public class Characteristics
    {
        public long TotalSurface { get; set; }
        public long BuildedSurface { get; set; }
        public long UtildSurface { get; set; }
        public long LandSurface { get; set; }
        public long TerraceSurface { get; set; }
        public long HouseSurface { get; set; }
        public long OfficeSurface { get; set; }
        public long WarehouseSurface { get; set; }
        public long PastedSurface { get; set; }
        public long Bedrooms { get; set; }
        public long Bathrooms { get; set; }
        public long Privates { get; set; }
        public long Offices { get; set; }
        public long Parkings { get; set; }
        public long Warehouses { get; set; }
        public bool Pool { get; set; }
    }

    public class Currency
    {
        public long IdCurrency { get; set; }
        public CurrencyRentName Name { get; set; }
        public Symbol Symbol { get; set; }
    }

    public class PropertyMedia
    {
        public long IdPropertyMedia { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public long Order { get; set; }
        public TypeEnum Type { get; set; }
        public long Visibility { get; set; }
    }

    public class User
    {
        public long IdUser { get; set; }
        public FullNameEnum Name { get; set; }
        public string LastName { get; set; }
        public string MotherLastName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public Uri PhotoUrl { get; set; }
        public string Description { get; set; }
        public long IdBranch { get; set; }
        public FullNameEnum FullName { get; set; }
    }

    public enum CurrencyRentName { Peso, Uf };

    public enum Symbol { Empty, Uf };

    public enum Letter { A, Empty };

    public enum TypeEnum { Image, Video };

    public enum FullNameEnum { Convecta };
}
