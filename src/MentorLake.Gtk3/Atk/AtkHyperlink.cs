namespace MentorLake.Gtk3.Atk;

public class AtkHyperlinkHandle : GObjectHandle, AtkActionHandle
{
}

public static class AtkHyperlinkSignalExtensions
{

	public static IObservable<AtkHyperlinkSignalStructs.LinkActivatedSignal> Signal_LinkActivated(this AtkHyperlinkHandle instance)
	{
		return Observable.Create((IObserver<AtkHyperlinkSignalStructs.LinkActivatedSignal> obs) =>
		{
			AtkHyperlinkSignalDelegates.link_activated handler = (AtkHyperlinkHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new AtkHyperlinkSignalStructs.LinkActivatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "link_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class AtkHyperlinkSignalStructs
{

public struct LinkActivatedSignal
{
	public AtkHyperlinkHandle Self;
	public IntPtr UserData;
}
}

public static class AtkHyperlinkSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void link_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<AtkHyperlinkHandle>))] AtkHyperlinkHandle self, IntPtr user_data);

}


public static class AtkHyperlinkHandleExtensions
{
	public static int GetEndIndex(this AtkHyperlinkHandle link_)
	{
		return AtkHyperlinkExterns.atk_hyperlink_get_end_index(link_);
	}

	public static int GetNAnchors(this AtkHyperlinkHandle link_)
	{
		return AtkHyperlinkExterns.atk_hyperlink_get_n_anchors(link_);
	}

	public static AtkObjectHandle GetObject(this AtkHyperlinkHandle link_, int i)
	{
		return AtkHyperlinkExterns.atk_hyperlink_get_object(link_, i);
	}

	public static int GetStartIndex(this AtkHyperlinkHandle link_)
	{
		return AtkHyperlinkExterns.atk_hyperlink_get_start_index(link_);
	}

	public static string GetUri(this AtkHyperlinkHandle link_, int i)
	{
		return AtkHyperlinkExterns.atk_hyperlink_get_uri(link_, i);
	}

	public static bool IsInline(this AtkHyperlinkHandle link_)
	{
		return AtkHyperlinkExterns.atk_hyperlink_is_inline(link_);
	}

	public static bool IsSelectedLink(this AtkHyperlinkHandle link_)
	{
		return AtkHyperlinkExterns.atk_hyperlink_is_selected_link(link_);
	}

	public static bool IsValid(this AtkHyperlinkHandle link_)
	{
		return AtkHyperlinkExterns.atk_hyperlink_is_valid(link_);
	}

}

internal class AtkHyperlinkExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern int atk_hyperlink_get_end_index(AtkHyperlinkHandle link_);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_hyperlink_get_n_anchors(AtkHyperlinkHandle link_);

	[DllImport(Libraries.Atk)]
	internal static extern AtkObjectHandle atk_hyperlink_get_object(AtkHyperlinkHandle link_, int i);

	[DllImport(Libraries.Atk)]
	internal static extern int atk_hyperlink_get_start_index(AtkHyperlinkHandle link_);

	[DllImport(Libraries.Atk)]
	internal static extern string atk_hyperlink_get_uri(AtkHyperlinkHandle link_, int i);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_hyperlink_is_inline(AtkHyperlinkHandle link_);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_hyperlink_is_selected_link(AtkHyperlinkHandle link_);

	[DllImport(Libraries.Atk)]
	internal static extern bool atk_hyperlink_is_valid(AtkHyperlinkHandle link_);

}
