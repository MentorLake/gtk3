namespace MentorLake.Vulkan;

public class VkImageHandle : BaseSafeHandle
{
}


public static class VkImageExtensions
{

	public static VkImage Dereference(this VkImageHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImage>(x.DangerousGetHandle());
}
internal class VkImageExterns
{
}

public struct VkImage
{
}
