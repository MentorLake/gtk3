namespace MentorLake.Vulkan;

public class VkRectLayerKHRHandle : BaseSafeHandle
{
}


public static class VkRectLayerKHRExtensions
{

	public static VkRectLayerKHR Dereference(this VkRectLayerKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkRectLayerKHR>(x.DangerousGetHandle());
}
internal class VkRectLayerKHRExterns
{
}

public struct VkRectLayerKHR
{
}
