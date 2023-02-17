using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive;
using System;
using System.Collections.Generic;
using System.CommandLine.Invocation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeMath;

public static class Commanding
{
    public static void Display(string text)
    {
        KernelInvocationContext.Current.Display(new HtmlString(text), "text/html");
    }

    public static async Task ExecuteAsync(string commandName)
    {
        Display($"<div>{commandName ?? "CIAONE"}</div>");
    }
}
