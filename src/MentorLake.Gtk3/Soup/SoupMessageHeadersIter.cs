namespace MentorLake.Soup;

/// <summary>
/// <para>
/// An opaque type used to iterate over a [struct@MessageHeaders] structure
/// </para>
/// <para>
/// After intializing the iterator with [func@MessageHeadersIter.init], call
/// [func@MessageHeadersIter.next] to fetch data from it.
/// </para>
/// <para>
/// You may not modify the headers while iterating over them.
/// </para>
/// </summary>

public class SoupMessageHeadersIterHandle : BaseSafeHandle
{
}


public static class SoupMessageHeadersIterExtensions
{

	public static SoupMessageHeadersIter Dereference(this SoupMessageHeadersIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupMessageHeadersIter>(x.DangerousGetHandle());
}
internal class SoupMessageHeadersIterExterns
{
	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_iter_init(out MentorLake.Soup.SoupMessageHeadersIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_headers_iter_next(ref MentorLake.Soup.SoupMessageHeadersIter iter, out string name, out string value);

}

/// <summary>
/// <para>
/// An opaque type used to iterate over a [struct@MessageHeaders] structure
/// </para>
/// <para>
/// After intializing the iterator with [func@MessageHeadersIter.init], call
/// [func@MessageHeadersIter.next] to fetch data from it.
/// </para>
/// <para>
/// You may not modify the headers while iterating over them.
/// </para>
/// </summary>

public struct SoupMessageHeadersIter
{
/// <summary>
/// <para>
/// Initializes @iter for iterating @hdrs.
/// </para>
/// </summary>

/// <param name="iter">
/// a pointer to a #SoupMessageHeadersIter structure
/// </param>
/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>

	public static void Init(out MentorLake.Soup.SoupMessageHeadersIter iter, MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		SoupMessageHeadersIterExterns.soup_message_headers_iter_init(out iter, hdrs);
	}

/// <summary>
/// <para>
/// Yields the next name/value pair in the [struct@MessageHeaders] being
/// iterated by @iter.
/// </para>
/// <para>
/// If @iter has already yielded the last header, then
/// [func@MessageHeadersIter.next] will return %FALSE and @name and @value
/// will be unchanged.
/// </para>
/// </summary>

/// <param name="iter">
/// a #SoupMessageHeadersIter
/// </param>
/// <param name="name">
/// pointer to a variable to return
///   the header name in
/// </param>
/// <param name="value">
/// pointer to a variable to return
///   the header value in
/// </param>
/// <return>
/// %TRUE if another name and value were returned, %FALSE
///   if the end of the headers has been reached.
/// </return>

	public static bool Next(ref MentorLake.Soup.SoupMessageHeadersIter iter, out string name, out string value)
	{
		return SoupMessageHeadersIterExterns.soup_message_headers_iter_next(ref iter, out name, out value);
	}

}
