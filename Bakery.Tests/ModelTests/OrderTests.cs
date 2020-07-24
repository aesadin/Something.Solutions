using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test2", "Test4");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrder_OrderList()
    {
      string title1 = "title1";
      string title2 = "title2";
      string description1 = "this is title1";
      string description2 = "this is title 2";
      string date1 = "this date";
      string date2 = "that date";
      Order newItem1 = new Order(title1, description1, date1);
      Order newItem2 = new Order(title2, description2, date2);
      List<Order> newList = new List<Order> { newItem1, newItem2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}