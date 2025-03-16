namespace MentorLake.Vulkan;

public class VkToolPurposeFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkToolPurposeFlagsEXTExtensions
{

	public static VkToolPurposeFlagsEXT Dereference(this VkToolPurposeFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkToolPurposeFlagsEXT>(x.DangerousGetHandle());
}
internal class VkToolPurposeFlagsEXTExterns
{
}

public struct VkToolPurposeFlagsEXT
{
}
