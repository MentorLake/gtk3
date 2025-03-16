namespace MentorLake.Vulkan;

public class VkBorderColorHandle : BaseSafeHandle
{
}


public static class VkBorderColorExtensions
{

	public static VkBorderColor Dereference(this VkBorderColorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBorderColor>(x.DangerousGetHandle());
}
internal class VkBorderColorExterns
{
}

public struct VkBorderColor
{
}
