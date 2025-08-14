namespace MentorLake.Vulkan;


public class VkAabbPositionsNVHandle : BaseSafeHandle
{
}


public static class VkAabbPositionsNVExtensions
{

	public static VkAabbPositionsNV Dereference(this VkAabbPositionsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkAabbPositionsNV>(x.DangerousGetHandle());
}
internal class VkAabbPositionsNVExterns
{
}


public struct VkAabbPositionsNV
{
}
