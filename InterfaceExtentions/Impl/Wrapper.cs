using InterfaceExtentions.Interfaces;

namespace InterfaceExtentions.Impl
{
    public class Wrapper<TRequest, TResponse> : 
        IWrapper<IRequest, IResponse>, // Iinterface inheritance, parameterized Interface
        IWrapper<Request, Response> // Interface inheritance, parameterized Class
        // no matter if Request implement IRequest.
    {
        
    }
}