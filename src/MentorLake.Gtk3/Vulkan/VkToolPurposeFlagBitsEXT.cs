namespace MentorLake.Vulkan;


public class VkToolPurposeFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkToolPurposeFlagBitsEXTExtensions
{

	public static VkToolPurposeFlagBitsEXT Dereference(this VkToolPurposeFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkToolPurposeFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkToolPurposeFlagBitsEXTExterns
{
}


public struct VkToolPurposeFlagBitsEXT
{
}
