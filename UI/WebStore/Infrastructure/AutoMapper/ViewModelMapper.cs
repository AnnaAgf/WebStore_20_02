using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domain.Entities.Identity;
using WebStore.Domain.ViewModels.Identity;

namespace WebStore.Infrastructure.AutoMapper
{
    //правила для ViewModels
    public class ViewModelMapping : Profile
    {
        public ViewModelMapping()
        {
            //RegisterUserViewModel дб преобразована в User
            CreateMap<RegisterUserViewModel, User>()
                //.ForMember(UserModel => UserModel.UserName, opt => opt.MapFrom(ViewModel => ViewModel.UserName))
                ;

        }
    }
}
