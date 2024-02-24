using Arth.Application.Authentication.Commands.Register;
using Arth.Application.Authentication.Common;
using Arth.Application.Authentication.Queries.Login;
using Arth.Contracts.Authentication;
using Mapster;

namespace Arth.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        //If i need to configure anymore mappings, i'll do it here.
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}
