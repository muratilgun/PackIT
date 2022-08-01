using System;
using System.Linq;
using PackIT.Domain.Entities;
using PackIT.Domain.Exceptions;
using PackIT.Domain.Factories;
using PackIT.Domain.Policies;
using PackIT.Domain.ValueObjects;
using Shouldly;
using Xunit;

namespace PackIT.UnitTest.Domain
{
    public class PackingListTests
    {
        [Fact]
        public void AddItem_Throws_PackingItemAlreadyExistsException_When_There_Is_Already_Item_With_The_Same_Name()
        {
            //Arrange
            var packingList = GetPackingList();
            packingList.AddItem(new PackingItem("item 1",1));
            //Act
            var exception = Record.Exception(()=>packingList.AddItem(new PackingItem("item 1",1)));
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<PackingItemAlreadyExistsException>();

        }

      

        #region ARRANGE
        private PackingList GetPackingList()
        {
            var packingList = _factory.Create(Guid.NewGuid(), "MyList", Localization.Create("Warsaw,Poland"));
            packingList.ClearEvents();
            return packingList;
        }
        private readonly IPackingListFactory _factory;

        public PackingListTests()
        {
            _factory = new PackingListFactory(Enumerable.Empty<IPackingItemsPolicy>());
        }

        #endregion
    }
}