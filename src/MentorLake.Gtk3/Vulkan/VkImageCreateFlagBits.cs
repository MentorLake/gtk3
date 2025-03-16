namespace MentorLake.Vulkan;

public class VkImageCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkImageCreateFlagBitsExtensions
{

	public static VkImageCreateFlagBits Dereference(this VkImageCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkImageCreateFlagBitsExterns
{
}

public struct VkImageCreateFlagBits
{
}
