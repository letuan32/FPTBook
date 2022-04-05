using AutoMapper;
using Domain.Entities;
using WebMVC.Models.Books.Requests;
using WebMVC.ViewModels.Books.Requests;

namespace WebMVC.Mapper;

public class AutoMapperProfile:Profile
{
    public AutoMapperProfile()
    {
        CreateMap<BookAddVm, Book>();
            
    }
}