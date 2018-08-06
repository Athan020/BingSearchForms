using System;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using BingSearchForms.Core.ViewModels;

namespace BingSearchForms.Core
{
    public class CoreApp:MvxApplication
    {

        public override void Initialize()
        {
            base.Initialize();


            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();

        }
    }
}
