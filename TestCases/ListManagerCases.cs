using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    private ListManager _listManager;
    private List<int> _list;

    [SetUp]
    public void Setup()
    {
        _listManager = new ListManager();
        _list = new List<int>();
    }

    [Test]
    public void AddElement_AddsElementToList()
    {
        _listManager.AddElement(_list, 10);
        Assert.Contains(10, _list);
    }

    [Test]
    public void RemoveElement_RemovesExistingElement()
    {
        _listManager.AddElement(_list, 20);
        bool removed = _listManager.RemoveElement(_list, 20);
        Assert.IsTrue(removed);
        Assert.IsFalse(_list.Contains(20));
    }

    [Test]
    public void RemoveElement_ReturnsFalseIfElementNotFound()
    {
        bool removed = _listManager.RemoveElement(_list, 30);
        Assert.IsFalse(removed);
    }

    [Test]
    public void GetSize_ReturnsCorrectListSize()
    {
        _listManager.AddElement(_list, 5);
        _listManager.AddElement(_list, 15);
        Assert.AreEqual(2, _listManager.GetSize(_list));
    }

    [Test]
    public void Methods_ThrowExceptionForNullList()
    {
        Assert.Throws<ArgumentNullException>(() => _listManager.AddElement(null, 5));
        Assert.Throws<ArgumentNullException>(() => _listManager.RemoveElement(null, 5));
        Assert.Throws<ArgumentNullException>(() => _listManager.GetSize(null));
    }
}
