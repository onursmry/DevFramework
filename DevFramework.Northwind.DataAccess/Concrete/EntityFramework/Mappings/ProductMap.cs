﻿using System.Data.Entity.ModelConfiguration;
using DevFramework.Northwind.Entities.Concrete;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;

public class ProductMap:EntityTypeConfiguration<Product>
{
    public ProductMap()
    {
        ToTable(@"Products", @"dbo");
        HasKey(x => x.ProductId);
        Property(x => x.ProductId).HasColumnName("ProductID");
        Property(x => x.CategoryId).HasColumnName("CategoryID");
        Property(x => x.ProductName).HasColumnName("ProductName");
        Property(x => x.QuantityPerUnit).HasColumnName("QuantityPerUnit");
        Property(x => x.UnitPrice).HasColumnName("UnitPrice");
    }
}