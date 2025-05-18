namespace MentorLake.Atk;

public class AtkHyperlinkHandle : GObjectHandle, AtkActionHandle
{
}
public static class AtkHyperlinkHandleSignalExtensions
{

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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void link_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))] MentorLake.Atk.AtkHyperlinkHandle self, IntPtr user_data);

}


public static class AtkHyperlinkHandleExtensions
{
	public static int GetEndIndex(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_end_index(link_);
	}

	public static int GetNAnchors(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_n_anchors(link_);
	}

	public static MentorLake.Atk.AtkObjectHandle GetObject(this MentorLake.Atk.AtkHyperlinkHandle link_, int i)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_object(link_, i);
	}

	public static int GetStartIndex(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_start_index(link_);
	}

	public static string GetUri(this MentorLake.Atk.AtkHyperlinkHandle link_, int i)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_get_uri(link_, i);
	}

	public static bool IsInline(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_is_inline(link_);
	}

	public static bool IsSelectedLink(this MentorLake.Atk.AtkHyperlinkHandle link_)
	{
		if (link_.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkHandle)");
		return AtkHyperlinkHandleExterns.atk_hyperlink_is_selected_link(link_);
	}

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
