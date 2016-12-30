using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Core.Models;
using MugenMvvmToolkit.Infrastructure.Validation;

namespace Core.Validators
{
    public class UserValidator : ValidatorBase<User>
    {
        #region Overrides of ValidatorBase

        protected override Task<IDictionary<string, IEnumerable>> ValidateInternalAsync(string propertyName, CancellationToken token)
        {
            if (propertyName == GetMemberName(() => (user => user.Firstname)))
            {
                if (string.IsNullOrEmpty(Instance.Firstname))
                    return FromResult(new Dictionary<string, IEnumerable>
                    {
                        { propertyName, "First name cannot be empty!" }
                    });
                if (!char.IsUpper(Instance.Firstname[0]))
                {
                    return FromResult(new Dictionary<string, IEnumerable>
                    {
                        { propertyName, "First letter of first name have to be in upper case!" }
                    });
                }
            }
            else if (propertyName == GetMemberName(() => (user => user.Lastname)))
            {
                if (string.IsNullOrEmpty(Instance.Lastname))
                    return FromResult(new Dictionary<string, IEnumerable>
                    {
                        { propertyName, "Last name cannot be empty!" }
                    });
                if (!char.IsUpper(Instance.Lastname[0]))
                {
                    return FromResult(new Dictionary<string, IEnumerable>
                    {
                        { propertyName, "First letter of last name have to be in upper case!" }
                    });
                }
            }
        }

        protected override Task<IDictionary<string, IEnumerable>> ValidateInternalAsync(CancellationToken token)
        {
            return EmptyResult;
        }

        #endregion
    }
}
