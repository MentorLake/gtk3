namespace MentorLake.Vulkan;


public class VkBindImagePlaneMemoryInfoHandle : BaseSafeHandle
{
}


public static class VkBindImagePlaneMemoryInfoExtensions
{

	public static VkBindImagePlaneMemoryInfo Dereference(this VkBindImagePlaneMemoryInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBindImagePlaneMemoryInfo>(x.DangerousGetHandle());
}
internal class VkBindImagePlaneMemoryInfoExterns
{
}


public struct VkBindImagePlaneMemoryInfo
{
}
