namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Type definition for a function that will be called back when an URI request is
/// made for a user registered URI scheme.
/// </para>
/// </summary>

/// <param name="request">
/// the #WebKitURISchemeRequest
/// </param>
/// <param name="user_data">
/// user data passed to the callback
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void WebKitURISchemeRequestCallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitURISchemeRequestHandle>))] MentorLake.WebKit2.WebKitURISchemeRequestHandle request, IntPtr user_data);
