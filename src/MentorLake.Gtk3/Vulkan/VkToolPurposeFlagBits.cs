namespace MentorLake.Vulkan;


public class VkToolPurposeFlagBitsHandle : BaseSafeHandle
{
}


public static class VkToolPurposeFlagBitsExtensions
{

	public static VkToolPurposeFlagBits Dereference(this VkToolPurposeFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkToolPurposeFlagBits>(x.DangerousGetHandle());
}
internal class VkToolPurposeFlagBitsExterns
{
}


public struct VkToolPurposeFlagBits
{
}
