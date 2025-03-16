namespace MentorLake.Vulkan;

public class VkAccessFlagBitsHandle : BaseSafeHandle
{
}


public static class VkAccessFlagBitsExtensions
{

	public static VkAccessFlagBits Dereference(this VkAccessFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAccessFlagBits>(x.DangerousGetHandle());
}
internal class VkAccessFlagBitsExterns
{
}

public struct VkAccessFlagBits
{
}
