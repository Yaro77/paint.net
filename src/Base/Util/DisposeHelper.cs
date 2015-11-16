using System;
using System.Collections.Generic;
using System.Text;

namespace PaintDotNet.Base.Util
{
    public static class DisposeHelper
    {
        public static void Dispose<T>(ref T @object)
            where T : class, IDisposable
        {
            if (@object != null)
            {
                @object.Dispose();
                @object = null;
            }
        }
    }
}
