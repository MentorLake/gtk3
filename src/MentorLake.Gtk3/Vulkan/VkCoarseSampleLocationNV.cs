namespace MentorLake.Vulkan;


public class VkCoarseSampleLocationNVHandle : BaseSafeHandle
{
}


public static class VkCoarseSampleLocationNVExtensions
{

	public static VkCoarseSampleLocationNV Dereference(this VkCoarseSampleLocationNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCoarseSampleLocationNV>(x.DangerousGetHandle());
}
internal class VkCoarseSampleLocationNVExterns
{
}


public struct VkCoarseSampleLocationNV
{
}
