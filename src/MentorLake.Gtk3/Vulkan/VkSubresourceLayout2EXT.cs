namespace MentorLake.Vulkan;

public class VkSubresourceLayout2EXTHandle : BaseSafeHandle
{
}


public static class VkSubresourceLayout2EXTExtensions
{

	public static VkSubresourceLayout2EXT Dereference(this VkSubresourceLayout2EXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSubresourceLayout2EXT>(x.DangerousGetHandle());
}
internal class VkSubresourceLayout2EXTExterns
{
}

public struct VkSubresourceLayout2EXT
{
}
