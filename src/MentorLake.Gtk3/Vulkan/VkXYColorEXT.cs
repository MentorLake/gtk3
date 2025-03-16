namespace MentorLake.Vulkan;

public class VkXYColorEXTHandle : BaseSafeHandle
{
}


public static class VkXYColorEXTExtensions
{

	public static VkXYColorEXT Dereference(this VkXYColorEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkXYColorEXT>(x.DangerousGetHandle());
}
internal class VkXYColorEXTExterns
{
}

public struct VkXYColorEXT
{
}
