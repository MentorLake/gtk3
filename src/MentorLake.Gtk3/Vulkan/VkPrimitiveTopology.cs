namespace MentorLake.Vulkan;

public class VkPrimitiveTopologyHandle : BaseSafeHandle
{
}


public static class VkPrimitiveTopologyExtensions
{

	public static VkPrimitiveTopology Dereference(this VkPrimitiveTopologyHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPrimitiveTopology>(x.DangerousGetHandle());
}
internal class VkPrimitiveTopologyExterns
{
}

public struct VkPrimitiveTopology
{
}
