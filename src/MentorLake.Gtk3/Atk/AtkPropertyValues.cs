namespace MentorLake.Atk;

public class AtkPropertyValuesHandle : BaseSafeHandle
{
}


public static class AtkPropertyValuesExtensions
{

	public static AtkPropertyValues Dereference(this AtkPropertyValuesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkPropertyValues>(x.DangerousGetHandle());
}
internal class AtkPropertyValuesExterns
{
}

public struct AtkPropertyValues
{
	public string property_name;
	public GValue old_value;
	public GValue new_value;
}
