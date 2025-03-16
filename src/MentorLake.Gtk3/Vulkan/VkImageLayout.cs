namespace MentorLake.Vulkan;

public class VkImageLayoutHandle : BaseSafeHandle
{
}


public static class VkImageLayoutExtensions
{

	public static VkImageLayout Dereference(this VkImageLayoutHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageLayout>(x.DangerousGetHandle());
}
internal class VkImageLayoutExterns
{
}

public struct VkImageLayout
{
}
