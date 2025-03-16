namespace MentorLake.Vulkan;

public class VkSpecializationMapEntryHandle : BaseSafeHandle
{
}


public static class VkSpecializationMapEntryExtensions
{

	public static VkSpecializationMapEntry Dereference(this VkSpecializationMapEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSpecializationMapEntry>(x.DangerousGetHandle());
}
internal class VkSpecializationMapEntryExterns
{
}

public struct VkSpecializationMapEntry
{
}
