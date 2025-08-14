namespace MentorLake.Atk;

/// <summary>
/// <para>
/// A queryable interface which allows AtkHyperlink instances
/// associated with an AtkObject to be obtained.  AtkHyperlinkImpl
/// corresponds to AT-SPI's Hyperlink interface, and differs from
/// AtkHyperlink in that AtkHyperlink is an object type, rather than an
/// interface, and thus cannot be directly queried. FTW
/// </para>
/// </summary>

public interface AtkHyperlinkImplHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkHyperlinkImplHandleImpl : BaseSafeHandle, AtkHyperlinkImplHandle
{
}

public static class AtkHyperlinkImplHandleExtensions
{
/// <summary>
/// <para>
/// Gets the hyperlink associated with this object.
/// </para>
/// </summary>

/// <param name="impl">
/// a #GObject instance that implements AtkHyperlinkImplIface
/// </param>
/// <return>
/// an AtkHyperlink object which points to this
/// implementing AtkObject.
/// </return>

	public static MentorLake.Atk.AtkHyperlinkHandle GetHyperlink(this MentorLake.Atk.AtkHyperlinkImplHandle impl)
	{
		if (impl.IsInvalid) throw new Exception("Invalid handle (AtkHyperlinkImplHandle)");
		return AtkHyperlinkImplHandleExterns.atk_hyperlink_impl_get_hyperlink(impl);
	}

}

internal class AtkHyperlinkImplHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkHandle>))]
	internal static extern MentorLake.Atk.AtkHyperlinkHandle atk_hyperlink_impl_get_hyperlink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHyperlinkImplHandleImpl>))] MentorLake.Atk.AtkHyperlinkImplHandle impl);

}
