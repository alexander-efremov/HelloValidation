using Core.Validators;
using MugenMvvmToolkit.Interfaces.Validation;
using MugenMvvmToolkit.Models;
using MugenMvvmToolkit.Modules;
using MugenMvvmToolkit;

namespace Core
{
    public class PortableModule : ModuleBase
    {
        public PortableModule()
            : base(false, LoadMode.All)
        {
        }

        #region Overrides of ModuleBase

        protected override bool LoadInternal()
        {
            IocContainer.Get<IValidatorProvider>().Register<UserValidator>();
            return true;
        }

        protected override void UnloadInternal()
        {
        }

        #endregion
    }
}