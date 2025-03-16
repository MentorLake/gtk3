namespace MentorLake.Vulkan;

public class VkQueryLowLatencySupportNVHandle : BaseSafeHandle
{
}


public static class VkQueryLowLatencySupportNVExtensions
{

	public static VkQueryLowLatencySupportNV Dereference(this VkQueryLowLatencySupportNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryLowLatencySupportNV>(x.DangerousGetHandle());
}
internal class VkQueryLowLatencySupportNVExterns
{
}

public struct VkQueryLowLatencySupportNV
{
}
