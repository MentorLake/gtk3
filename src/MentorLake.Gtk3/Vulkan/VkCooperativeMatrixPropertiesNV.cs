namespace MentorLake.Vulkan;

public class VkCooperativeMatrixPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkCooperativeMatrixPropertiesNVExtensions
{

	public static VkCooperativeMatrixPropertiesNV Dereference(this VkCooperativeMatrixPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCooperativeMatrixPropertiesNV>(x.DangerousGetHandle());
}
internal class VkCooperativeMatrixPropertiesNVExterns
{
}

public struct VkCooperativeMatrixPropertiesNV
{
}
