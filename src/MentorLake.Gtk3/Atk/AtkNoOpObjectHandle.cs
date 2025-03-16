namespace MentorLake.Atk;

public class AtkNoOpObjectHandle : AtkObjectHandle, AtkActionHandle, AtkComponentHandle, AtkDocumentHandle, AtkEditableTextHandle, AtkHypertextHandle, AtkImageHandle, AtkSelectionHandle, AtkTableHandle, AtkTableCellHandle, AtkTextHandle, AtkValueHandle, AtkWindowHandle
{
	public static MentorLake.Atk.AtkNoOpObjectHandle New(MentorLake.GObject.GObjectHandle obj)
	{
		return AtkNoOpObjectHandleExterns.atk_no_op_object_new(obj);
	}

}

public static class AtkNoOpObjectHandleExtensions
{
}

internal class AtkNoOpObjectHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkNoOpObjectHandle atk_no_op_object_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle obj);

}
