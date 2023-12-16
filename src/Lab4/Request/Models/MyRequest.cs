using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Request.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab4.Request.Models;

public class MyRequest : IRequest
{
    private IList<string>? _request;

    public MyRequest(string request)
    {
        if (request is not null)
        {
            _request = request.Split(' ');
        }
    }

    public string? FindElement(int wordNumber)
    {
        if (_request is not null)
        {
            return _request[wordNumber];
        }

        return null;
    }
}
