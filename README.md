﻿# Extention methods using Classes and Interfaces

This repository shows how with C# we can extend parametrized classes and interfaces

## IMPORTANT

Look at the double implementation in the class ´Wrapper´. That's the key.

```C#
public class Wrapper<TRequest, TResponse> : 
        IWrapper<IRequest, IResponse>, // Interface inheritance, parameterized Interface
        IWrapper<Request, Response> // Interface inheritance, parameterized Class
        // no matter if Request implements IRequest.
    {
        
    }
```

If the class Wrapper doesn't implement the class parametrized interfaces, the tests ´Use_Interface_Interface_Extension_Test´ and ´Use_Interface_Class_Extension_Test´ won't compile.
C# doesn't know how to cast th line

```C#

IWrapper<Request, Response> wrapper = new Wrapper<Request, Response>();

```

And you will see the error

```

Error	CS0266	
Cannot implicitly convert
type 'InterfaceExtentions.Impl.Wrapper<InterfaceExtentions.Impl.Request, InterfaceExtentions.Impl.Response>' 
to 'InterfaceExtentions.Interfaces.IWrapper<InterfaceExtentions.Impl.Request, InterfaceExtentions.Impl.Response>'. 
An explicit conversion exists (are you missing a cast?)

```
