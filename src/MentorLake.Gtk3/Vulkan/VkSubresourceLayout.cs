namespace MentorLake.Vulkan;

public class VkSubresourceLayoutHandle : BaseSafeHandle
{
}


public static class VkSubresourceLayoutExtensions
{

	public static VkSubresourceLayout Dereference(this VkSubresourceLayoutHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubresourceLayout>(x.DangerousGetHandle());
}
internal class VkSubresourceLayoutExterns
{
}

public struct VkSubresourceLayout
{
}
