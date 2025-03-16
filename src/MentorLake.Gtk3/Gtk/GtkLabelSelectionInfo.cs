namespace MentorLake.Gtk;

public class GtkLabelSelectionInfoHandle : BaseSafeHandle
{
}


public static class GtkLabelSelectionInfoExtensions
{

	public static GtkLabelSelectionInfo Dereference(this GtkLabelSelectionInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkLabelSelectionInfo>(x.DangerousGetHandle());
}
internal class GtkLabelSelectionInfoExterns
{
}

public struct GtkLabelSelectionInfo
{
}
