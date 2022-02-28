using AutoMapper;
using Basket.API.Entities;
using EventBus.Messages.Events;
using System;
namespace Basket.API.Mapper
{
    public class BasketProfile: Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
