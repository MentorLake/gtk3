namespace MentorLake.Vulkan;

public class VkFenceHandle : BaseSafeHandle
{
}


public static class VkFenceExtensions
{

	public static VkFence Dereference(this VkFenceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFence>(x.DangerousGetHandle());
}
internal class VkFenceExterns
{
}

public struct VkFence
{
}
