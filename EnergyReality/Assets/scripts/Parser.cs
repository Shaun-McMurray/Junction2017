using SimpleJSON;
using System;


public class Parser
{
    public FortumJson[] Json { get; set; }
}

public class FortumJson
{
    public int location { get; set; }
    public string city { get; set; }
    public int zipcode { get; set; }
    public int amountofinhabitants { get; set; }
    public int buildingyear { get; set; }
    public int cubicmeters { get; set; }
    public int electricityheatingsurface { get; set; }
    public int squaremeters { get; set; }
    public string buildingtype_id { get; set; }
    public string primaryheatingtype_id { get; set; }
    public string secondaryheatingtype_id { get; set; }
}

public class ComparisonJson
{

    public class Rootobject
    {
        public string job_id { get; set; }
        public string status { get; set; }
        public int free_credits { get; set; }
        public int paid_credits { get; set; }
        public Product[] products { get; set; }
    }

    public class Product
    {
        public string source { get; set; }
        public string country { get; set; }
        public string key { get; set; }
        public string value { get; set; }
        public bool success { get; set; }
        public DateTime updated_at { get; set; }
        public string id { get; set; }
        public string condition_filter { get; set; }
        public string[] gtins { get; set; }
        public string[] eans { get; set; }
        public string name { get; set; }
        public object brand_name { get; set; }
        public object category_name { get; set; }
        public int review_count { get; set; }
        public int review_rating { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string description { get; set; }
        public Offer[] offers { get; set; }
    }

    public class Offer
    {
        public string shop_id { get; set; }
        public string shop_name { get; set; }
        public string shop_url { get; set; }
        public object name { get; set; }
        public string price { get; set; }
        public string price_with_shipping { get; set; }
        public string shipping_costs { get; set; }
        public string currency { get; set; }
        public object condition { get; set; }
        public object tax { get; set; }
        public string url { get; set; }
    }

}
