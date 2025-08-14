namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An ATK object which encapsulates a link or set of links in a hypertext document.
/// </para>
/// <para>
/// An ATK object which encapsulates a link or set of links (for
/// instance in the case of client-side image maps) in a hypertext
/// document.  It may implement the AtkAction interface.  AtkHyperlink
/// may also be used to refer to inline embedded content, since it
/// allows specification of a start and end offset within the host
/// AtkHypertext object.
/// </para>
/// </summary>

public class AtkHyperlinkHandle : GObjectHandle, AtkActionHandle
{
}
public static class AtkHyperlinkHandleSignalExtensions
{
/// <summary>
/// <para>
/// The signal link-activated is emitted when a link is activated.
/// </para>
/// </summary>

	public static IObservable<AtkHyperlinkHandleSignalStructs.LinkActivatedSignal> Signal_LinkActivated(this AtkHyperlinkHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkHyperlinkHandleSignalStructs.LinkActivatedSignal> obs) =>
		{
			AtkHyperlinkHandleSignalDelegates.link_activated handler = ( MentorLake.Atk.AtkHyperlinkHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkHyperlinkHandleSignalStructs.LinkActivatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "link-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class AtkHyperlinkHandleSignalStructs
{

public class LinkActivatedSignal
{

	public MentorLake.Atk.AtkHyperlinkHandle Self;

	public IntPtr UserData;
}
}

public static class AtkHyperlinkHandleSignalDelegates
{

/// <summary>
/// <para>
/// The signal link-activated is emitted when a link is activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void link_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle self, IntPtr user_data);

}


public static class AtkHyperlinkHandleExtensions
{
/// <summary>
/// <para>
/// Gets the index with the hypertext document at which this link ends.
/// </para>
/// </summary>

/// <param name="link_">
/// an #AtkHyperlink
/// </param>
/// <return>
/// the index with the hypertext document at which this link ends
/// </return>

	public static int GetEndIndex(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_end_index(link_);
	}

/// <summary>
/// <para>
/// Gets the number of anchors associated with this hyperlink.
/// </para>
/// </summary>

/// <param name="link_">
/// an #AtkHyperlink
/// </param>
/// <return>
/// the number of anchors associated with this hyperlink
/// </return>

	public static int GetNAnchors(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_n_anchors(link_);
	}

/// <summary>
/// <para>
/// Returns the item associated with this hyperlinks nth anchor.
/// For instance, the returned #AtkObject will implement #AtkText
/// if @link_ is a text hyperlink, #AtkImage if @link_ is an image
/// hyperlink etc.
/// </para>
/// <para>
/// Multiple anchors are primarily used by client-side image maps.
/// </para>
/// </summary>

/// <param name="link_">
/// an #AtkHyperlink
/// </param>
/// <param name="i">
/// a (zero-index) integer specifying the desired anchor
/// </param>
/// <return>
/// an #AtkObject associated with this hyperlinks
/// i-th anchor
/// </return>

	public static MentorLake.Atk.AtkObjectHandle GetObject(this MentorLake.Atk.AtkHyperlinkHandle link_, int i)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_object(link_, i);
	}

/// <summary>
/// <para>
/// Gets the index with the hypertext document at which this link begins.
/// </para>
/// </summary>

/// <param name="link_">
/// an #AtkHyperlink
/// </param>
/// <return>
/// the index with the hypertext document at which this link begins
/// </return>

	public static int GetStartIndex(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_start_index(link_);
	}

/// <summary>
/// <para>
/// Get a the URI associated with the anchor specified
/// by @i of @link_.
/// </para>
/// <para>
/// Multiple anchors are primarily used by client-side image maps.
/// </para>
/// </summary>

/// <param name="link_">
/// an #AtkHyperlink
/// </param>
/// <param name="i">
/// a (zero-index) integer specifying the desired anchor
/// </param>
/// <return>
/// a string specifying the URI
/// </return>

	public static string GetUri(this MentorLake.Atk.AtkHyperlinkHandle link_, int i)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_uri(link_, i);
	}

/// <summary>
/// <para>
/// Indicates whether the link currently displays some or all of its
///           content inline.  Ordinary HTML links will usually return
///           %FALSE, but an inline &lt;src&gt; HTML element will return
///           %TRUE.
/// </para>
/// </summary>

/// <param name="link_">
/// an #AtkHyperlink
/// </param>
/// <return>
/// whether or not this link displays its content inline.
/// </return>

	public static bool IsInline(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_is_inline(link_);
	}

/// <summary>
/// <para>
/// Determines whether this AtkHyperlink is selected
/// </para>
/// </summary>

/// <param name="link_">
/// an #AtkHyperlink
/// </param>
/// <return>
/// True if the AtkHyperlink is selected, False otherwise
/// </return>

	public static bool IsSelectedLink(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_is_selected_link(link_);
	}

/// <summary>
/// <para>
/// Since the document that a link is associated with may have changed
/// this method returns %TRUE if the link is still valid (with
/// respect to the document it references) and %FALSE otherwise.
/// </para>
/// </summary>

/// <param name="link_">
/// an #AtkHyperlink
/// </param>
/// <return>
/// whether or not this link is still valid
/// </return>

	public static bool IsValid(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_is_valid(link_);
	}

}

internal class AtkHyperlinkHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_hyperlink_get_end_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle link_);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_hyperlink_get_n_anchors([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle link_);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))]
	internal static extern MentorLake.Atk.AtkObjectHandle atk_hyperlink_get_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle link_, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_hyperlink_get_start_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle link_);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string atk_hyperlink_get_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle link_, int i);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_hyperlink_is_inline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle link_);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_hyperlink_is_selected_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle link_);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_hyperlink_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle link_);

}
