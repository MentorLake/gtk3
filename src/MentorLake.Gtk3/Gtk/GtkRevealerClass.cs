namespace MentorLake.Gtk;

public class GtkRevealerClassHandle : BaseSafeHandle
{
}


public static class GtkRevealerClassExtensions
{

	public static GtkRevealerClass Dereference(this GtkRevealerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkRevealerClass>(x.DangerousGetHandle());
}
internal class GtkRevealerClassExterns
{
}

public struct GtkRevealerClass
{
	public GtkBinClass parent_class;
}
