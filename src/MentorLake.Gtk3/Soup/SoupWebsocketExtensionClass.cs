namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The class structure for the [class@WebsocketExtension].
/// </para>
/// </summary>

public class SoupWebsocketExtensionClassHandle : BaseSafeHandle
{
}


public static class SoupWebsocketExtensionClassExtensions
{

	public static SoupWebsocketExtensionClass Dereference(this SoupWebsocketExtensionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupWebsocketExtensionClass>(x.DangerousGetHandle());
}
internal class SoupWebsocketExtensionClassExterns
{
}

/// <summary>
/// <para>
/// The class structure for the [class@WebsocketExtension].
/// </para>
/// </summary>

public struct SoupWebsocketExtensionClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// the name of the extension
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// called to configure the extension with the given parameters
/// </para>
/// </summary>

public IntPtr configure;
	/// <summary>
/// <para>
/// called by the client to build the request header.
///    It should include the parameters string starting with &apos;;&apos;
/// </para>
/// </summary>

public IntPtr get_request_params;
	/// <summary>
/// <para>
/// called by the server to build the response header.
///    It should include the parameters string starting with &apos;;&apos;
/// </para>
/// </summary>

public IntPtr get_response_params;
	/// <summary>
/// <para>
/// called to process the payload data of a message
///    before it&apos;s sent. Reserved bits of the header should be changed.
/// </para>
/// </summary>

public IntPtr process_outgoing_message;
	/// <summary>
/// <para>
/// called to process the payload data of a message
///    after it&apos;s received. Reserved bits of the header should be cleared.
/// </para>
/// </summary>

public IntPtr process_incoming_message;
}
