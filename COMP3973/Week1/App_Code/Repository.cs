using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for Repository
/// </summary>
public class Repository
{
    private static readonly NorthwindEntities Model = new NorthwindEntities();

    public static Repository Instance
    {
        get
        {
            return InstanceHolder.Value;
        }
    }

    private static readonly Lazy<Repository> InstanceHolder = new Lazy<Repository>(() => new Repository());

    private Repository()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int AddRegion(string description)
    {
        var region = new Region
        {
            RegionDescription = description
        };

        Model.Regions.Add(region);
        Model.SaveChanges();
        return region.RegionID;
    }

    public IEnumerable<Region> GetRegions()
    {
        return Model.Regions.ToList();
    }

    public void UpdateRegion(int regionId, string regionDescription)
    {
        Region region = Model.Regions.FirstOrDefault(r => r.RegionID == regionId);
        region.RegionDescription = regionDescription;
        Model.SaveChanges();
    }

    public void DeleteRegion(int regionId)
    {
        Region region = Model.Regions.FirstOrDefault(r => r.RegionID == regionId);
        Model.Regions.Remove(region);
        Model.SaveChanges();
    }
}