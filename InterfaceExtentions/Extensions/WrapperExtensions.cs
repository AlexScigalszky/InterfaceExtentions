using InterfaceExtentions.Impl;
using InterfaceExtentions.Interfaces;

namespace InterfaceExtentions.Extensions
{
    public static class WrapperExtensions
    {
        public static string ExecuteClassClass<TRequest, TResponse>(
            this Wrapper<Request, Response> wrapper)
        {
            return "[Class, Class] Type: " + wrapper.GetType().Name;
        }

        public static string ExecuteClassInterface<TRequest, TResponse>(
            this Wrapper<IRequest, IResponse> wrapper)
            where TRequest : IRequest
            where TResponse : IResponse
        {
            return "[Class, Interface] Type: " + wrapper.GetType().Name;
        }

        public static string ExecuteInterfaceInterface<TRequest, TResponse>(
            this IWrapper<IRequest, IResponse> wrapper)
            where TRequest : IRequest
            where TResponse : IResponse
        {
            return "[Interface, Interface] Type: " + wrapper.GetType().Name;
        }

        public static string ExecuteInterfaceClass<TRequest, TResponse>(
            this IWrapper<Request, Response> wrapper)
            where TRequest : Request
            where TResponse : Response
        {
            return "[Interface, Class] Type: " + wrapper.GetType().Name;
        }

    }
}
