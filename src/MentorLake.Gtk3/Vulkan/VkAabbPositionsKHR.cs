namespace MentorLake.Vulkan;

public class VkAabbPositionsKHRHandle : BaseSafeHandle
{
}


public static class VkAabbPositionsKHRExtensions
{

	public static VkAabbPositionsKHR Dereference(this VkAabbPositionsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAabbPositionsKHR>(x.DangerousGetHandle());
}
internal class VkAabbPositionsKHRExterns
{
}

public struct VkAabbPositionsKHR
{
}
