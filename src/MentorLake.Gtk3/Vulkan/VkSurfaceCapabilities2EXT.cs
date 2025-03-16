namespace MentorLake.Vulkan;

public class VkSurfaceCapabilities2EXTHandle : BaseSafeHandle
{
}


public static class VkSurfaceCapabilities2EXTExtensions
{

	public static VkSurfaceCapabilities2EXT Dereference(this VkSurfaceCapabilities2EXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceCapabilities2EXT>(x.DangerousGetHandle());
}
internal class VkSurfaceCapabilities2EXTExterns
{
}

public struct VkSurfaceCapabilities2EXT
{
}
