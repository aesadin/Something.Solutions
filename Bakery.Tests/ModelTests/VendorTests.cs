using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
    [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test2");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    // [TestMethod]
    // public void GetName_ReturnsName_String()
    // {
    //   //Arrange
    //   string vendorName = "Test Vendor";
    //   Vendor newVendor = new Vendor(vendorName);

    //   //Act
    //   string result = newVendor.VendorName;

    //   //Assert
    //   Assert.AreEqual(vendorName, result);
    // }

    [TestMethod]
    public void GetAll_ReturnsAllCategoryObjects_VendorList()
    {
      
      string vendorName01 = "Name1";
      string vendorName02 = "Name2";
      string vendorDescription1 = "pastry shop";
      string vendorDescription2 = "bread shop";
      Vendor newVendor1 = new Vendor(vendorName01, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName02, vendorDescription2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      
      string vendorName03 = "Name3";
      string vendorName04 = "Name4";
      string vendorDescription3 = "pastry shop";
      string vendorDescription4 = "bread shop";
      Vendor newVendor3 = new Vendor(vendorName03, vendorDescription3);
      Vendor newVendor4 = new Vendor(vendorName04, vendorDescription4);
      

      List<Vendor> result = Vendor.GetAll();

      
      CollectionAssert.AreEqual(newList, result);
    }
  }
}