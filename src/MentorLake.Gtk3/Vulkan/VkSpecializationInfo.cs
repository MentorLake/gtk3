namespace MentorLake.Vulkan;

public class VkSpecializationInfoHandle : BaseSafeHandle
{
}


public static class VkSpecializationInfoExtensions
{

	public static VkSpecializationInfo Dereference(this VkSpecializationInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSpecializationInfo>(x.DangerousGetHandle());
}
internal class VkSpecializationInfoExterns
{
}

public struct VkSpecializationInfo
{
}
