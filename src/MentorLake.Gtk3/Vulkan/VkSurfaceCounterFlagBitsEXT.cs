namespace MentorLake.Vulkan;

public class VkSurfaceCounterFlagBitsEXTHandle : BaseSafeHandle
{
}


public static class VkSurfaceCounterFlagBitsEXTExtensions
{

	public static VkSurfaceCounterFlagBitsEXT Dereference(this VkSurfaceCounterFlagBitsEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSurfaceCounterFlagBitsEXT>(x.DangerousGetHandle());
}
internal class VkSurfaceCounterFlagBitsEXTExterns
{
}

public struct VkSurfaceCounterFlagBitsEXT
{
}
