namespace MentorLake.Vulkan;

public class VkSurfaceCounterFlagsEXTHandle : BaseSafeHandle
{
}


public static class VkSurfaceCounterFlagsEXTExtensions
{

	public static VkSurfaceCounterFlagsEXT Dereference(this VkSurfaceCounterFlagsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceCounterFlagsEXT>(x.DangerousGetHandle());
}
internal class VkSurfaceCounterFlagsEXTExterns
{
}

public struct VkSurfaceCounterFlagsEXT
{
}
