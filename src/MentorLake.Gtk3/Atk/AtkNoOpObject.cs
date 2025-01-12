namespace MentorLake.Gtk3.Atk;

public class AtkNoOpObjectHandle : AtkObjectHandle, AtkActionHandle, AtkComponentHandle, AtkDocumentHandle, AtkEditableTextHandle, AtkHypertextHandle, AtkImageHandle, AtkSelectionHandle, AtkTableHandle, AtkTableCellHandle, AtkTextHandle, AtkValueHandle, AtkWindowHandle
{
	public static AtkNoOpObjectHandle New(GObjectHandle obj)
	{
		return AtkNoOpObjectExterns.atk_no_op_object_new(obj);
	}

}

public static class AtkNoOpObjectHandleExtensions
{
}

internal class AtkNoOpObjectExterns
{
	[DllImport(Libraries.Atk)]
	internal static extern AtkNoOpObjectHandle atk_no_op_object_new(GObjectHandle obj);

}
