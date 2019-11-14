// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Win32.SafeHandles
{
    internal sealed class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        internal SafeFindHandle() : base(true) { }

        protected override bool ReleaseHandle()
        {
            return Interop.Kernel32.FindClose(handle);
        }
    }
}