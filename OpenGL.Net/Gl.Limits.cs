
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Limits support listing.
		/// </summary>
		public sealed partial class Limits
		{
			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value, the maximum recursion depth allowed during display-list traversal. The value 
			/// must be at least 64. See Gl.CallList.
			/// </summary>
			[Limit(MAX_LIST_NESTING)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxListNesting;

			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value, the maximum equation order supported by 1D and 2D evaluators. The value must 
			/// be at least 8. See Gl.Map1 and Gl.Map2.
			/// </summary>
			[Limit(MAX_EVAL_ORDER)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxEvalOrder;

			/// <summary>
			/// [GL2.1|GLES1.1] Gl.Get: params returns one value, the maximum number of lights. The value must be at least 8. See 
			/// Gl.Light.
			/// </summary>
			[Limit(MAX_LIGHTS)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxLights;

			/// <summary>
			/// <para>
			/// [GL2.1] Gl.Get: params returns one value, the maximum number of application-defined clipping planes. The value must be 
			/// at least 6. See Gl.ClipPlane.
			/// </para>
			/// <para>
			/// [GLES1.1] Gl.Get: params returns one value, the maximum number of application defined clipping planes. The value must be 
			/// at least Gl.. See Gl.ClipPlane.
			/// </para>
			/// </summary>
			[Limit(MAX_CLIP_PLANES)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxClipPlanes;

			/// <summary>
			/// [GL4] Gl.Get: data returns one value, the maximum number of application-defined clipping distances. The value must be at 
			/// least 8.
			/// </summary>
			[Limit(MAX_CLIP_DISTANCES)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
			public int MaxClipDistances;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value. The value gives a rough estimate of the largest texture that the GL can handle. 
			/// The value must be at least 1024. Use a proxy texture target such as Gl.PROXY_TEXTURE_1D or Gl.PROXY_TEXTURE_2D to 
			/// determine if a texture is too large. See Gl.TexImage1D and Gl.TexImage2D.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value. The value gives a rough estimate of the largest texture that the GL can 
			/// handle. The value must be at least 2048. See Gl.TexImage2D.
			/// </para>
			/// </summary>
			[Limit(MAX_TEXTURE_SIZE)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			public int MaxTextureSize;

			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value, the maximum supported size of a Gl.PixelMap lookup table. The value must be at 
			/// least 32. See Gl.PixelMap.
			/// </summary>
			[Limit(MAX_PIXEL_MAP_TABLE)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxPixelMapTable;

			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value, the maximum supported depth of the attribute stack. The value must be at least 
			/// 16. See Gl.PushAttrib.
			/// </summary>
			[Limit(MAX_ATTRIB_STACK_DEPTH)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxAttribStackDepth;

			/// <summary>
			/// <para>
			/// [GL2.1] Gl.Get: params returns one value, the maximum supported depth of the modelview matrix stack. The value must be 
			/// at least 32. See Gl.PushMatrix.
			/// </para>
			/// <para>
			/// [GLES1.1] Gl.Get: params returns one value, the maximum supported depth of the modelview matrix stack. The value must be 
			/// at least Gl.. See Gl.PushMatrix.
			/// </para>
			/// </summary>
			[Limit(MAX_MODELVIEW_STACK_DEPTH)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxModelviewStackDepth;

			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value, the maximum supported depth of the selection name stack. The value must be at 
			/// least 64. See Gl.PushName.
			/// </summary>
			[Limit(MAX_NAME_STACK_DEPTH)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxNameStackDepth;

			/// <summary>
			/// [GL2.1|GLES1.1] Gl.Get: params returns one value, the maximum supported depth of the projection matrix stack. The value 
			/// must be at least 2. See Gl.PushMatrix.
			/// </summary>
			[Limit(MAX_PROJECTION_STACK_DEPTH)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxProjectionStackDepth;

			/// <summary>
			/// [GL2.1|GLES1.1] Gl.Get: params returns one value, the maximum supported depth of the texture matrix stack. The value 
			/// must be at least 2. See Gl.PushMatrix.
			/// </summary>
			[Limit(MAX_TEXTURE_STACK_DEPTH)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxTextureStackDepth;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns two values: the maximum supported width and height of the viewport. These must be at 
			/// least as large as the visible dimensions of the display being rendered to. See Gl.Viewport.
			/// </summary>
			[Limit(MAX_VIEWPORT_DIMS, ArrayLength = 2)]
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			public int[] MaxViewportDims = new int[] {0, 0 };

			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value indicating the maximum supported depth of the client attribute stack. See 
			/// Gl.PushClientAttrib.
			/// </summary>
			[Limit(MAX_CLIENT_ATTRIB_STACK_DEPTH)]
			[RequiredByFeature("GL_VERSION_1_1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxClientAttribStackDepth;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, a rough estimate of the largest 3D texture that the GL can handle. The value must 
			/// be at least 64. Use Gl.PROXY_TEXTURE_3D to determine if a texture is too large. See Gl.TexImage3D.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, a rough estimate of the largest 3D texture that the GL can handle. The value 
			/// must be at least 256. See Gl.TexImage3D.
			/// </para>
			/// </summary>
			[Limit(MAX_3D_TEXTURE_SIZE)]
			[RequiredByFeature("GL_VERSION_1_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_texture3D")]
			[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
			public int Max3dTextureSize;

			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value, the maximum supported depth of the color matrix stack. The value must be at 
			/// least 2. See Gl.PushMatrix.
			/// </summary>
			[Limit(MAX_COLOR_MATRIX_STACK_DEPTH)]
			[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
			[RequiredByFeature("GL_SGI_color_matrix")]
			public int MaxColorMatrixStackDepth;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the recommended maximum number of vertex array vertices. See 
			/// Gl.DrawRangeElements.
			/// </summary>
			[Limit(MAX_ELEMENTS_VERTICES)]
			[RequiredByFeature("GL_VERSION_1_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_draw_range_elements")]
			public int MaxElementsVertices;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the recommended maximum number of vertex array indices. See 
			/// Gl.DrawRangeElements.
			/// </summary>
			[Limit(MAX_ELEMENTS_INDICES)]
			[RequiredByFeature("GL_VERSION_1_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_draw_range_elements")]
			public int MaxElementsIndices;

			/// <summary>
			/// [GL4] Gl.Get: data returns one value, the maximum number of simultaneous viewports that are supported. The value must be 
			/// at least 16. See Gl.ViewportIndexed.
			/// </summary>
			[Limit(MAX_VIEWPORTS)]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
			[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
			public int MaxViewports;

			/// <summary>
			/// [GL] Value of GL_MAX_COMPUTE_SHARED_MEMORY_SIZE symbol.
			/// </summary>
			[Limit(MAX_COMPUTE_SHARED_MEMORY_SIZE)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxComputeSharedMemorySize;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean 
			/// values that can be held in uniform variable storage for a compute shader. The value must be at least 1024. See 
			/// Gl.Uniform.
			/// </summary>
			[Limit(MAX_COMPUTE_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxComputeUniformComponents;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by 
			/// a compute shader.
			/// </summary>
			[Limit(MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxComputeAtomicCounterBuffers;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to compute shaders.
			/// </summary>
			[Limit(MAX_COMPUTE_ATOMIC_COUNTERS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxComputeAtomicCounters;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the number of words for compute shader uniform variables in all uniform 
			/// blocks (including default). The value must be at least 1. See Gl.Uniform.
			/// </summary>
			[Limit(MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxCombinedComputeUniformComponents;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum depth of the debug message group stack.
			/// </summary>
			[Limit(MAX_DEBUG_GROUP_STACK_DEPTH)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
			public int MaxDebugGroupStackDepth;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of explicitly assignable uniform locations, which must 
			/// be at least 1024.
			/// </summary>
			[Limit(MAX_UNIFORM_LOCATIONS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_explicit_uniform_location", Api = "gl|glcore")]
			public int MaxUniformLocations;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single integer value containing the maximum offset that may be added to a vertex 
			/// binding offset.
			/// </summary>
			[Limit(MAX_VERTEX_ATTRIB_RELATIVE_OFFSET)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
			public int MaxVertexAttribRelativeOffset;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single integer value containing the maximum number of vertex buffers that may be 
			/// bound.
			/// </summary>
			[Limit(MAX_VERTEX_ATTRIB_BINDINGS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
			public int MaxVertexAttribBindings;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_ATTRIB_STRIDE symbol.
			/// </summary>
			[Limit(MAX_VERTEX_ATTRIB_STRIDE)]
			[RequiredByFeature("GL_VERSION_4_4")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			public int MaxVertexAttribStride;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum length of a label that may be assigned to an object. See 
			/// Gl.ObjectLabel and Gl.ObjectPtrLabel.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum length of a label string.
			/// </para>
			/// </summary>
			[Limit(MAX_LABEL_LENGTH)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
			public int MaxLabelLength;

			/// <summary>
			/// [GL] Value of GL_MAX_CULL_DISTANCES symbol.
			/// </summary>
			[Limit(MAX_CULL_DISTANCES)]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_cull_distance", Api = "gl|glcore")]
			public int MaxCullDistances;

			/// <summary>
			/// [GL] Value of GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES symbol.
			/// </summary>
			[Limit(MAX_COMBINED_CLIP_AND_CULL_DISTANCES)]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_cull_distance", Api = "gl|glcore")]
			public int MaxCombinedClipAndCullDistances;

			/// <summary>
			/// [GL] Value of GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT symbol.
			/// </summary>
			[Limit(MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT)]
			[RequiredByFeature("GL_EXT_pixel_transform")]
			public int MaxPixelTransform2dStackDepthExt;

			/// <summary>
			/// <para>
			/// [GL2.1] Gl.Get: params returns a single value indicating the number of conventional texture units supported. Each 
			/// conventional texture unit includes both a texture coordinate set and a texture image unit. Conventional texture units 
			/// may be used for fixed-function (non-shader) rendering. The value must be at least 2. Additional texture coordinate sets 
			/// and texture image units may be accessed from vertex and fragment shaders. See Gl.ActiveTexture and 
			/// Gl.ClientActiveTexture.
			/// </para>
			/// <para>
			/// [GLES1.1] Gl.Get: params returns a single value indicating the number of texture units supported. The value must be at 
			/// least 1. See Gl.ActiveTexture, Gl.ClientActiveTexture and Gl.MultiTexCoord.
			/// </para>
			/// </summary>
			[Limit(MAX_TEXTURE_UNITS)]
			[RequiredByFeature("GL_VERSION_1_3")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ARB_multitexture")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxTextureUnits;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value. The value indicates the maximum supported size for renderbuffers. See 
			/// Gl.FramebufferRenderbuffer.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value. The value indicates the maximum supported size for renderbuffers and must be 
			/// at least 2048. See Gl.FramebufferRenderbuffer.
			/// </para>
			/// </summary>
			[Limit(MAX_RENDERBUFFER_SIZE)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_framebuffer_object")]
			[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
			public int MaxRenderbufferSize;

			/// <summary>
			/// [GL4] Gl.Get: data returns one value. The value gives a rough estimate of the largest rectangular texture that the GL 
			/// can handle. The value must be at least 1024. Use Gl.PROXY_TEXTURE_RECTANGLE to determine if a texture is too large. See 
			/// Gl.TexImage2D.
			/// </summary>
			[Limit(MAX_RECTANGLE_TEXTURE_SIZE)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ARB_texture_rectangle")]
			[RequiredByFeature("GL_NV_texture_rectangle")]
			public int MaxRectangleTextureSize;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum, absolute value of the texture level-of-detail bias. The value 
			/// must be at least 2.0.
			/// </summary>
			[Limit(MAX_TEXTURE_LOD_BIAS)]
			[RequiredByFeature("GL_VERSION_1_4")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_texture_lod_bias", Api = "gl|gles1")]
			public int MaxTextureLodBias;

			/// <summary>
			/// [GL] Value of GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT symbol.
			/// </summary>
			[Limit(MAX_TEXTURE_MAX_ANISOTROPY_EXT)]
			[RequiredByFeature("GL_EXT_texture_filter_anisotropic", Api = "gl|gles1|gles2")]
			public int MaxTextureMaxAnisotropyExt;

			/// <summary>
			/// [GL] Value of GL_MAX_SHININESS_NV symbol.
			/// </summary>
			[Limit(MAX_SHININESS_NV)]
			[RequiredByFeature("GL_NV_light_max_exponent")]
			public int MaxShininessNv;

			/// <summary>
			/// [GL] Value of GL_MAX_SPOT_EXPONENT_NV symbol.
			/// </summary>
			[Limit(MAX_SPOT_EXPONENT_NV)]
			[RequiredByFeature("GL_NV_light_max_exponent")]
			public int MaxSpotExponentNv;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value. The value gives a rough estimate of the largest cube-map texture that the GL can 
			/// handle. The value must be at least 1024. Use Gl.PROXY_TEXTURE_CUBE_MAP to determine if a texture is too large. See 
			/// Gl.TexImage2D.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value. The value gives a rough estimate of the largest cube-map texture that the GL 
			/// can handle. The value must be at least 2048. See Gl.TexImage2D.
			/// </para>
			/// </summary>
			[Limit(MAX_CUBE_MAP_TEXTURE_SIZE)]
			[RequiredByFeature("GL_VERSION_1_3")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_cube_map")]
			[RequiredByFeature("GL_EXT_texture_cube_map")]
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			public int MaxCubeMapTextureSize;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV symbol.
			/// </summary>
			[Limit(MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV)]
			[RequiredByFeature("GL_NV_vertex_array_range")]
			public int MaxVertexArrayRangeElementNv;

			/// <summary>
			/// [GL] Value of GL_MAX_GENERAL_COMBINERS_NV symbol.
			/// </summary>
			[Limit(MAX_GENERAL_COMBINERS_NV)]
			[RequiredByFeature("GL_NV_register_combiners")]
			public int MaxGeneralCombinersNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramMatrixStackDepthArb;

			/// <summary>
			/// [GL] Value of GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV symbol.
			/// </summary>
			[Limit(MAX_TRACK_MATRIX_STACK_DEPTH_NV)]
			[RequiredByFeature("GL_NV_vertex_program")]
			public int MaxTrackMatrixStackDepthNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_MATRICES_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_MATRICES_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramMatricesArb;

			/// <summary>
			/// [GL] Value of GL_MAX_TRACK_MATRICES_NV symbol.
			/// </summary>
			[Limit(MAX_TRACK_MATRICES_NV)]
			[RequiredByFeature("GL_NV_vertex_program")]
			public int MaxTrackMatricesNv;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_UNITS_ARB symbol.
			/// </summary>
			[Limit(MAX_VERTEX_UNITS_ARB)]
			[RequiredByFeature("GL_ARB_vertex_blend")]
			[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
			public int MaxVertexUnitsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_MAP_TESSELLATION_NV symbol.
			/// </summary>
			[Limit(MAX_MAP_TESSELLATION_NV)]
			[RequiredByFeature("GL_NV_evaluators")]
			public int MaxMapTessellationNv;

			/// <summary>
			/// [GL] Value of GL_MAX_RATIONAL_EVAL_ORDER_NV symbol.
			/// </summary>
			[Limit(MAX_RATIONAL_EVAL_ORDER_NV)]
			[RequiredByFeature("GL_NV_evaluators")]
			public int MaxRationalEvalOrderNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_PATCH_ATTRIBS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_PATCH_ATTRIBS_NV)]
			[RequiredByFeature("GL_NV_tessellation_program5")]
			public int MaxProgramPatchAttribsNv;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_STREAMS_ATI symbol.
			/// </summary>
			[Limit(MAX_VERTEX_STREAMS_ATI)]
			[RequiredByFeature("GL_ATI_vertex_streams")]
			public int MaxVertexStreamsAti;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT symbol.
			/// </summary>
			[Limit(MAX_VERTEX_SHADER_INSTRUCTIONS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxVertexShaderInstructionsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_SHADER_VARIANTS_EXT symbol.
			/// </summary>
			[Limit(MAX_VERTEX_SHADER_VARIANTS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxVertexShaderVariantsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_SHADER_INVARIANTS_EXT symbol.
			/// </summary>
			[Limit(MAX_VERTEX_SHADER_INVARIANTS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxVertexShaderInvariantsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT symbol.
			/// </summary>
			[Limit(MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxVertexShaderLocalConstantsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_SHADER_LOCALS_EXT symbol.
			/// </summary>
			[Limit(MAX_VERTEX_SHADER_LOCALS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxVertexShaderLocalsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT symbol.
			/// </summary>
			[Limit(MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxOptimizedVertexShaderInstructionsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT symbol.
			/// </summary>
			[Limit(MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxOptimizedVertexShaderVariantsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT symbol.
			/// </summary>
			[Limit(MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxOptimizedVertexShaderLocalConstantsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT symbol.
			/// </summary>
			[Limit(MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxOptimizedVertexShaderInvariantsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT symbol.
			/// </summary>
			[Limit(MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT)]
			[RequiredByFeature("GL_EXT_vertex_shader")]
			public int MaxOptimizedVertexShaderLocalsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI symbol.
			/// </summary>
			[Limit(MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI)]
			[RequiredByFeature("GL_ATI_pn_triangles")]
			public int MaxPnTrianglesTesselationLevelAti;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_ALU_INSTRUCTIONS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			public int MaxProgramAluInstructionsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_TEX_INSTRUCTIONS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			public int MaxProgramTexInstructionsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_TEX_INDIRECTIONS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			public int MaxProgramTexIndirectionsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			public int MaxProgramNativeAluInstructionsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			public int MaxProgramNativeTexInstructionsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			public int MaxProgramNativeTexIndirectionsArb;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of simultaneous outputs that may be written in a fragment 
			/// shader. The value must be at least 8. See Gl.DrawBuffers.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of simultaneous outputs that may be written in a fragment 
			/// shader. The value must be at least 4. See Gl.DrawBuffers.
			/// </para>
			/// </summary>
			[Limit(MAX_DRAW_BUFFERS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_draw_buffers")]
			[RequiredByFeature("GL_ATI_draw_buffers")]
			[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
			[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
			public int MaxDrawBuffers;

			/// <summary>
			/// [GL] Value of GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB symbol.
			/// </summary>
			[Limit(MAX_MATRIX_PALETTE_STACK_DEPTH_ARB)]
			[RequiredByFeature("GL_ARB_matrix_palette")]
			public int MaxMatrixPaletteStackDepthArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PALETTE_MATRICES_ARB symbol.
			/// </summary>
			[Limit(MAX_PALETTE_MATRICES_ARB)]
			[RequiredByFeature("GL_ARB_matrix_palette")]
			[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
			public int MaxPaletteMatricesArb;

			/// <summary>
			/// [GL] Value of GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV symbol.
			/// </summary>
			[Limit(MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV)]
			[RequiredByFeature("GL_NV_fragment_program")]
			public int MaxFragmentProgramLocalParametersNv;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of 4-component generic vertex attributes accessible to 
			/// a vertex shader. The value must be at least 16. See Gl.VertexAttrib.
			/// </summary>
			[Limit(MAX_VERTEX_ATTRIBS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			public int MaxVertexAttribs;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components of inputs read by a tesselation control 
			/// shader, which must be at least 128.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_INPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlInputComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components of inputs read by a tesselation evaluation 
			/// shader, which must be at least 128.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_INPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationInputComponents;

			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value, the maximum number of texture coordinate sets available to vertex and fragment 
			/// shaders. The value must be at least 2. See Gl.ActiveTexture and Gl.ClientActiveTexture.
			/// </summary>
			[Limit(MAX_TEXTURE_COORDS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_fragment_program")]
			[RemovedByFeature("GL_VERSION_3_2")]
			public int MaxTextureCoords;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access 
			/// texture maps from the fragment shader. The value must be at least 16. See Gl.ActiveTexture.
			/// </summary>
			[Limit(MAX_TEXTURE_IMAGE_UNITS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_fragment_program")]
			public int MaxTextureImageUnits;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_INSTRUCTIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_INSTRUCTIONS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramInstructionsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramNativeInstructionsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_TEMPORARIES_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_TEMPORARIES_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramTemporariesArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_NATIVE_TEMPORARIES_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramNativeTemporariesArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_PARAMETERS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_PARAMETERS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramParametersArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_NATIVE_PARAMETERS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramNativeParametersArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_ATTRIBS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_ATTRIBS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramAttribsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_NATIVE_ATTRIBS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramNativeAttribsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_ADDRESS_REGISTERS_ARB)]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramAddressRegistersArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB)]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramNativeAddressRegistersArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_LOCAL_PARAMETERS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramLocalParametersArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_ENV_PARAMETERS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_ENV_PARAMETERS_ARB)]
			[RequiredByFeature("GL_ARB_fragment_program")]
			[RequiredByFeature("GL_ARB_vertex_program")]
			public int MaxProgramEnvParametersArb;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_EXEC_INSTRUCTIONS_NV)]
			[RequiredByFeature("GL_NV_fragment_program2")]
			[RequiredByFeature("GL_NV_vertex_program2_option")]
			public int MaxProgramExecInstructionsNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_CALL_DEPTH_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_CALL_DEPTH_NV)]
			[RequiredByFeature("GL_NV_fragment_program2")]
			[RequiredByFeature("GL_NV_vertex_program2_option")]
			public int MaxProgramCallDepthNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_IF_DEPTH_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_IF_DEPTH_NV)]
			[RequiredByFeature("GL_NV_fragment_program2")]
			public int MaxProgramIfDepthNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_LOOP_DEPTH_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_LOOP_DEPTH_NV)]
			[RequiredByFeature("GL_NV_fragment_program2")]
			public int MaxProgramLoopDepthNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_LOOP_COUNT_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_LOOP_COUNT_NV)]
			[RequiredByFeature("GL_NV_fragment_program2")]
			public int MaxProgramLoopCountNv;

			/// <summary>
			/// [GL4] Gl.Get: data returns one value, the maximum number of active draw buffers when using dual-source blending. The 
			/// value must be at least 1. See Gl.BlendFunc and Gl.BlendFuncSeparate.
			/// </summary>
			[Limit(MAX_DUAL_SOURCE_DRAW_BUFFERS)]
			[RequiredByFeature("GL_VERSION_3_3")]
			[RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
			public int MaxDualSourceDrawBuffers;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value. The value indicates the maximum number of layers allowed in an array 
			/// texture, and must be at least 256. See Gl.TexImage2D.
			/// </summary>
			[Limit(MAX_ARRAY_TEXTURE_LAYERS)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_texture_array")]
			public int MaxArrayTextureLayers;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the minimum texel offset allowed in a texture lookup, which must be at 
			/// most -8.
			/// </summary>
			[Limit(MIN_PROGRAM_TEXEL_OFFSET)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_gpu_shader4")]
			[RequiredByFeature("GL_NV_gpu_program4")]
			public int MinProgramTexelOffset;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum texel offset allowed in a texture lookup, which must be at 
			/// least 7.
			/// </summary>
			[Limit(MAX_PROGRAM_TEXEL_OFFSET)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_gpu_shader4")]
			[RequiredByFeature("GL_NV_gpu_program4")]
			public int MaxProgramTexelOffset;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_ATTRIB_COMPONENTS_NV)]
			[RequiredByFeature("GL_NV_gpu_program4")]
			public int MaxProgramAttribComponentsNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_RESULT_COMPONENTS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_RESULT_COMPONENTS_NV)]
			[RequiredByFeature("GL_NV_gpu_program4")]
			public int MaxProgramResultComponentsNv;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of uniform blocks per vertex shader. The value must be 
			/// at least 12. See Gl.UniformBlockBinding.
			/// </summary>
			[Limit(MAX_VERTEX_UNIFORM_BLOCKS)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			public int MaxVertexUniformBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of uniform blocks per geometry shader. The value must 
			/// be at least 12. See Gl.UniformBlockBinding.
			/// </summary>
			[Limit(MAX_GEOMETRY_UNIFORM_BLOCKS)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryUniformBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of uniform blocks per fragment shader. The value must 
			/// be at least 12. See Gl.UniformBlockBinding.
			/// </summary>
			[Limit(MAX_FRAGMENT_UNIFORM_BLOCKS)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			public int MaxFragmentUniformBlocks;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of uniform blocks per program. The value must be at least 70. 
			/// See Gl.UniformBlockBinding.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of uniform blocks per program. The value must be at least 
			/// 60. See Gl.UniformBlockBinding.
			/// </para>
			/// </summary>
			[Limit(MAX_COMBINED_UNIFORM_BLOCKS)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			public int MaxCombinedUniformBlocks;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of uniform buffer binding points on the context, which must be 
			/// at least 36.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of uniform buffer binding points on the context, which must 
			/// be at least 72.
			/// </para>
			/// </summary>
			[Limit(MAX_UNIFORM_BUFFER_BINDINGS)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			public int MaxUniformBufferBindings;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum size in basic machine units of a uniform block, which must be at least 
			/// 16384.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum size in basic machine units of a uniform block. The value must be 
			/// at least 16384. See Gl.UniformBlockBinding.
			/// </para>
			/// </summary>
			[Limit(MAX_UNIFORM_BLOCK_SIZE)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			public int MaxUniformBlockSize;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the number of words for vertex shader uniform variables in all uniform blocks 
			/// (including default). The value must be at least 1. See Gl.Uniform.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the number of words for vertex shader uniform variables in all uniform blocks 
			/// (including default). The value must be at least . Gl.MAX_VERTEX_UNIFORM_COMPONENTS + Gl.MAX_UNIFORM_BLOCK_SIZE * 
			/// Gl.MAX_VERTEX_UNIFORM_BLOCKS / 4. See Gl.Uniform.
			/// </para>
			/// </summary>
			[Limit(MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			public int MaxCombinedVertexUniformComponents;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the number of words for geometry shader uniform variables in all uniform blocks 
			/// (including default). The value must be at least 1. See Gl.Uniform.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the number of words for geometry shader uniform variables in all uniform 
			/// blocks (including default). The value must be at least Gl.MAX_GEOMETRY_UNIFORM_COMPONENTS + Gl.MAX_UNIFORM_BLOCK_SIZE * 
			/// Gl.MAX_GEOMETRY_UNIFORM_BLOCKS / 4. See Gl.Uniform.
			/// </para>
			/// </summary>
			[Limit(MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxCombinedGeometryUniformComponents;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the number of words for fragment shader uniform variables in all uniform blocks 
			/// (including default). The value must be at least 1. See Gl.Uniform.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the number of words for fragment shader uniform variables in all uniform 
			/// blocks (including default). The value must be at least Gl.MAX_FRAGMENT_UNIFORM_COMPONENTS + Gl.MAX_UNIFORM_BLOCK_SIZE * 
			/// Gl.MAX_FRAGMENT_UNIFORM_BLOCKS / 4. See Gl.Uniform.
			/// </para>
			/// </summary>
			[Limit(MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			public int MaxCombinedFragmentUniformComponents;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values that 
			/// can be held in uniform variable storage for a fragment shader. The value must be at least 1024. See Gl.Uniform.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values 
			/// that can be held in uniform variable storage for a fragment shader. The value must be at least 896. See Gl.Uniform.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAGMENT_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_fragment_shader")]
			public int MaxFragmentUniformComponents;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean 
			/// values that can be held in uniform variable storage for a vertex shader. The value must be at least 1024. See 
			/// Gl.Uniform.
			/// </summary>
			[Limit(MAX_VERTEX_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			public int MaxVertexUniformComponents;

			/// <summary>
			/// [GL4] Gl.Get: data returns one value, the maximum number of interpolators available for processing varying variables 
			/// used by vertex and fragment shaders. This value represents the number of individual floating-point values that can be 
			/// interpolated; varying variables declared as vectors, matrices, and arrays will all consume multiple interpolators. The 
			/// value must be at least 32.
			/// </summary>
			[Limit(MAX_VARYING_FLOATS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			public int MaxVaryingFloats;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the number components for varying variables, which must be at least 60.
			/// </summary>
			[Limit(MAX_VARYING_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			public int MaxVaryingComponents;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access 
			/// texture maps from the vertex shader. The value may be at least 16. See Gl.ActiveTexture.
			/// </summary>
			[Limit(MAX_VERTEX_TEXTURE_IMAGE_UNITS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			[RequiredByFeature("GL_NV_vertex_program3")]
			public int MaxVertexTextureImageUnits;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture maps 
			/// from the vertex shader and the fragment processor combined. If both the vertex shader and the fragment processing stage 
			/// access the same texture image unit, then that counts as using two texture image units against this limit. The value must 
			/// be at least 48. See Gl.ActiveTexture.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture 
			/// maps from the all the shader stages combined. If both the vertex shader and the fragment processing stage access the 
			/// same texture image unit, then that counts as using two texture image units against this limit. The value must be at 
			/// least 96. See Gl.ActiveTexture.
			/// </para>
			/// </summary>
			[Limit(MAX_COMBINED_TEXTURE_IMAGE_UNITS)]
			[RequiredByFeature("GL_VERSION_2_0")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_vertex_shader")]
			public int MaxCombinedTextureImageUnits;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_OUTPUT_VERTICES_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_OUTPUT_VERTICES_NV)]
			[RequiredByFeature("GL_NV_geometry_program4")]
			public int MaxProgramOutputVerticesNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV)]
			[RequiredByFeature("GL_NV_geometry_program4")]
			public int MaxProgramTotalOutputComponentsNv;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access 
			/// texture maps from the geometry shader. The value must be at least 16. See Gl.ActiveTexture.
			/// </summary>
			[Limit(MAX_GEOMETRY_TEXTURE_IMAGE_UNITS)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			[RequiredByFeature("GL_NV_geometry_program4")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryTextureImageUnits;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value. The value gives the maximum number of texels allowed in the texel array of 
			/// a texture buffer object. Value must be at least 65536.
			/// </summary>
			[Limit(MAX_TEXTURE_BUFFER_SIZE)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_buffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
			[RequiredByFeature("GL_EXT_texture_buffer_object")]
			[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
			public int MaxTextureBufferSize;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single floating-point value indicating the minimum sample shading fraction. See 
			/// Gl.MinSampleShading.
			/// </summary>
			[Limit(MIN_SAMPLE_SHADING_VALUE)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_sample_shading", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_sample_shading", Api = "gles2")]
			public int MinSampleShadingValue;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components which can be written per attribute or output 
			/// in separate transform feedback mode. The value must be at least 4. See Gl.TransformFeedbackVaryings.
			/// </summary>
			[Limit(MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_transform_feedback")]
			[RequiredByFeature("GL_NV_transform_feedback")]
			public int MaxTransformFeedbackSeparateComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components which can be written to a single transform 
			/// feedback buffer in interleaved mode. The value must be at least 64. See Gl.TransformFeedbackVaryings.
			/// </summary>
			[Limit(MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_transform_feedback")]
			[RequiredByFeature("GL_NV_transform_feedback")]
			public int MaxTransformFeedbackInterleavedComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum separate attributes or outputs which can be captured in separate 
			/// transform feedback mode. The value must be at least 4. See Gl.TransformFeedbackVaryings.
			/// </summary>
			[Limit(MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_EXT_transform_feedback")]
			[RequiredByFeature("GL_NV_transform_feedback")]
			public int MaxTransformFeedbackSeparateAttribs;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of color attachment points in a framebuffer object. The 
			/// value must be at least 4. See Gl.FramebufferRenderbuffer and Gl.FramebufferTexture2D.
			/// </summary>
			[Limit(MAX_COLOR_ATTACHMENTS)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
			[RequiredByFeature("GL_EXT_framebuffer_object")]
			[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
			public int MaxColorAttachments;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value. The value indicates the maximum supported number of samples for multisampling. 
			/// The value must be at least 4. See Gl.GetInternalformativ.
			/// </summary>
			[Limit(MAX_SAMPLES)]
			[RequiredByFeature("GL_VERSION_3_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
			[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
			[RequiredByFeature("GL_EXT_framebuffer_multisample")]
			[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
			[RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
			public int MaxSamples;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns a single value, the maximum index that may be specified during the transfer of generic vertex 
			/// attributes to the GL.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum index supported by the implementation. The value must be at least 
			/// 224-1.
			/// </para>
			/// </summary>
			[Limit(MAX_ELEMENT_INDEX)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
			public int MaxElementIndex;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV)]
			[RequiredByFeature("GL_NV_parameter_buffer_object")]
			public int MaxProgramParameterBufferBindingsNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV)]
			[RequiredByFeature("GL_NV_parameter_buffer_object")]
			public int MaxProgramParameterBufferSizeNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_GENERIC_ATTRIBS_NV)]
			[RequiredByFeature("GL_NV_gpu_program4")]
			public int MaxProgramGenericAttribsNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_GENERIC_RESULTS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_GENERIC_RESULTS_NV)]
			[RequiredByFeature("GL_NV_gpu_program4")]
			public int MaxProgramGenericResultsNv;

			/// <summary>
			/// [GL] Value of GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB symbol.
			/// </summary>
			[Limit(MAX_GEOMETRY_VARYING_COMPONENTS_ARB)]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			public int MaxGeometryVaryingComponentsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_VARYING_COMPONENTS_ARB symbol.
			/// </summary>
			[Limit(MAX_VERTEX_VARYING_COMPONENTS_ARB)]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			public int MaxVertexVaryingComponentsArb;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean 
			/// values that can be held in uniform variable storage for a geometry shader. The value must be at least 1024. See 
			/// Gl.Uniform.
			/// </summary>
			[Limit(MAX_GEOMETRY_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryUniformComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of vertices emit by a geometry shader, which must be at 
			/// least 256.
			/// </summary>
			[Limit(MAX_GEOMETRY_OUTPUT_VERTICES)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryOutputVertices;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum total number of components of active outputs for all vertices 
			/// written by a geometry shader, which must be at least 1024.
			/// </summary>
			[Limit(MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_EXT_geometry_shader4")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryTotalOutputComponents;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT symbol.
			/// </summary>
			[Limit(MAX_VERTEX_BINDABLE_UNIFORMS_EXT)]
			[RequiredByFeature("GL_EXT_bindable_uniform")]
			public int MaxVertexBindableUniformsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT symbol.
			/// </summary>
			[Limit(MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT)]
			[RequiredByFeature("GL_EXT_bindable_uniform")]
			public int MaxFragmentBindableUniformsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT symbol.
			/// </summary>
			[Limit(MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT)]
			[RequiredByFeature("GL_EXT_bindable_uniform")]
			public int MaxGeometryBindableUniformsExt;

			/// <summary>
			/// [GL] Value of GL_MAX_SUBROUTINES symbol.
			/// </summary>
			[Limit(MAX_SUBROUTINES)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
			public int MaxSubroutines;

			/// <summary>
			/// [GL] Value of GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS symbol.
			/// </summary>
			[Limit(MAX_SUBROUTINE_UNIFORM_LOCATIONS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
			public int MaxSubroutineUniformLocations;

			/// <summary>
			/// [GL] Value of GL_MAX_BINDABLE_UNIFORM_SIZE_EXT symbol.
			/// </summary>
			[Limit(MAX_BINDABLE_UNIFORM_SIZE_EXT)]
			[RequiredByFeature("GL_EXT_bindable_uniform")]
			public int MaxBindableUniformSizeExt;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of 4-vectors that may be held in uniform variable storage for 
			/// the vertex shader. The value of Gl.MAX_VERTEX_UNIFORM_VECTORS is equal to the value of Gl.MAX_VERTEX_UNIFORM_COMPONENTS 
			/// and must be at least 256.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of vector floating-point, integer, or boolean values that 
			/// can be held in uniform variable storage for a vertex shader. The value must be at least 256. See Gl.Uniform.
			/// </para>
			/// </summary>
			[Limit(MAX_VERTEX_UNIFORM_VECTORS)]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			public int MaxVertexUniformVectors;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the number 4-vectors for varying variables, which is equal to the value of 
			/// Gl.MAX_VARYING_COMPONENTS and must be at least 15.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of interpolators available for processing varying variables 
			/// used by vertex and fragment shaders. This value represents the number of vector values that can be interpolated; varying 
			/// variables declared as matrices and arrays will consume multiple interpolators. The value must be at least 15.
			/// </para>
			/// </summary>
			[Limit(MAX_VARYING_VECTORS)]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			public int MaxVaryingVectors;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of individual 4-vectors of floating-point, integer, or boolean 
			/// values that can be held in uniform variable storage for a fragment shader. The value is equal to the value of 
			/// Gl.MAX_FRAGMENT_UNIFORM_COMPONENTS divided by 4 and must be at least 256. See Gl.Uniform.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of vector floating-point, integer, or boolean values that 
			/// can be held in uniform variable storage for a fragment shader. The value must be at least 224. See Gl.Uniform.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAGMENT_UNIFORM_VECTORS)]
			[RequiredByFeature("GL_VERSION_4_1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
			public int MaxFragmentUniformVectors;

			/// <summary>
			/// [GL] Value of GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV symbol.
			/// </summary>
			[Limit(MAX_MULTISAMPLE_COVERAGE_MODES_NV)]
			[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
			public int MaxMultisampleCoverageModesNv;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the number of words for tesselation control shader uniform variables in all 
			/// uniform blocks (including default). The value must be at least Gl.MAX_TESS_CONTROL_UNIFORM_COMPONENTS + 
			/// Gl.MAX_UNIFORM_BLOCK_SIZE * Gl.MAX_TESS_CONTROL_UNIFORM_BLOCKS / 4. See Gl.Uniform.
			/// </summary>
			[Limit(MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxCombinedTessControlUniformComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the number of words for tesselation evaluation shader uniform variables in all 
			/// uniform blocks (including default). The value must be at least Gl.MAX_TESS_EVALUATION_UNIFORM_COMPONENTS + 
			/// Gl.MAX_UNIFORM_BLOCK_SIZE * Gl.MAX_TESS_EVALUATION_UNIFORM_BLOCKS / 4. See Gl.Uniform.
			/// </summary>
			[Limit(MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxCombinedTessEvaluationUniformComponents;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of sample mask words.
			/// </summary>
			[Limit(MAX_SAMPLE_MASK_WORDS)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_explicit_multisample")]
			public int MaxSampleMaskWords;

			/// <summary>
			/// [GL] Value of GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV symbol.
			/// </summary>
			[Limit(MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV)]
			[RequiredByFeature("GL_NV_gpu_program5")]
			public int MaxGeometryProgramInvocationsNv;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of invocations per primitive of a geometry 
			/// shader.
			/// </summary>
			[Limit(MAX_GEOMETRY_SHADER_INVOCATIONS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_gpu_shader5", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryShaderInvocations;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single floating-point value indicating the minimum valid offset for interpolation. See 
			/// Gl.terpolateAtOffset.
			/// </summary>
			[Limit(MIN_FRAGMENT_INTERPOLATION_OFFSET)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_gpu_shader5", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_shader_multisample_interpolation", Api = "gles2")]
			[RequiredByFeature("GL_NV_gpu_program5")]
			public int MinFragmentInterpolationOffset;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single floating-point value indicating the maximum valid offset for interpolation. See 
			/// Gl.terpolateAtOffset.
			/// </summary>
			[Limit(MAX_FRAGMENT_INTERPOLATION_OFFSET)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_gpu_shader5", Api = "gl|glcore")]
			[RequiredByFeature("GL_OES_shader_multisample_interpolation", Api = "gles2")]
			[RequiredByFeature("GL_NV_gpu_program5")]
			public int MaxFragmentInterpolationOffset;

			/// <summary>
			/// [GL] Value of GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET symbol.
			/// </summary>
			[Limit(MIN_PROGRAM_TEXTURE_GATHER_OFFSET)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_gather", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_gpu_program5")]
			public int MinProgramTextureGatherOffset;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_TEXTURE_GATHER_OFFSET)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_gather", Api = "gl|glcore")]
			[RequiredByFeature("GL_NV_gpu_program5")]
			public int MaxProgramTextureGatherOffset;

			/// <summary>
			/// [GL] Value of GL_MAX_TRANSFORM_FEEDBACK_BUFFERS symbol.
			/// </summary>
			[Limit(MAX_TRANSFORM_FEEDBACK_BUFFERS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ARB_transform_feedback3", Api = "gl|glcore")]
			public int MaxTransformFeedbackBuffers;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_STREAMS symbol.
			/// </summary>
			[Limit(MAX_VERTEX_STREAMS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ARB_gpu_shader5", Api = "gl|glcore")]
			[RequiredByFeature("GL_ARB_transform_feedback3", Api = "gl|glcore")]
			public int MaxVertexStreams;

			/// <summary>
			/// [GL] Value of GL_MAX_PATCH_VERTICES symbol.
			/// </summary>
			[Limit(MAX_PATCH_VERTICES)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxPatchVertices;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum tessellation level supported by the tesselation primitive 
			/// generator.
			/// </summary>
			[Limit(MAX_TESS_GEN_LEVEL)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessGenLevel;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values 
			/// that can be held in uniform variable storage for a tesselation control shader. The value must be at least 1024. See 
			/// Gl.Uniform.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlUniformComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of individual floating-point, integer, or boolean values 
			/// that can be held in uniform variable storage for a tesselation evaluation shader. The value must be at least 1024. See 
			/// Gl.Uniform.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_UNIFORM_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationUniformComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture 
			/// maps from the tesselation control shader. The value may be at least 16. See Gl.ActiveTexture.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlTextureImageUnits;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access texture 
			/// maps from the tesselation evaluation shader. The value may be at least 16. See Gl.ActiveTexture.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationTextureImageUnits;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components of outputs written by a tesselation control 
			/// shader, which must be at least 128.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_OUTPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlOutputComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components of per-patch outputs written by a tesselation 
			/// control shader, which must be at least 128.
			/// </summary>
			[Limit(MAX_TESS_PATCH_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessPatchComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum total number of components of active outputs for all vertices 
			/// written by a tesselation control shader, including per-vertex and per-patch outputs, which must be at least 2048.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlTotalOutputComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components of outputs written by a tesselation 
			/// evaluation shader, which must be at least 128.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_OUTPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationOutputComponents;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of uniform blocks per tesselation control shader. The value 
			/// must be at least 12. See Gl.UniformBlockBinding.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_UNIFORM_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlUniformBlocks;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of uniform blocks per tesselation evaluation shader. The 
			/// value must be at least 12. See Gl.UniformBlockBinding.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_UNIFORM_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_0")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationUniformBlocks;

			/// <summary>
			/// [GL] Value of GL_MAX_WINDOW_RECTANGLES_EXT symbol.
			/// </summary>
			[Limit(MAX_WINDOW_RECTANGLES_EXT)]
			[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
			public int MaxWindowRectanglesExt;

			/// <summary>
			/// [GL] Value of GL_MAX_SHADER_BUFFER_ADDRESS_NV symbol.
			/// </summary>
			[Limit(MAX_SHADER_BUFFER_ADDRESS_NV)]
			[RequiredByFeature("GL_NV_shader_buffer_load", Api = "gl|glcore")]
			public int MaxShaderBufferAddressNv;

			/// <summary>
			/// [GL] Value of GL_MAX_IMAGE_UNITS symbol.
			/// </summary>
			[Limit(MAX_IMAGE_UNITS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_shader_image_load_store")]
			public int MaxImageUnits;

			/// <summary>
			/// [GL] Value of GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS symbol.
			/// </summary>
			[Limit(MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_shader_image_load_store")]
			public int MaxCombinedImageUnitsAndFragmentOutputs;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV)]
			[RequiredByFeature("GL_NV_gpu_program5")]
			public int MaxProgramSubroutineParametersNv;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_SUBROUTINE_NUM_NV symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_SUBROUTINE_NUM_NV)]
			[RequiredByFeature("GL_NV_gpu_program5")]
			public int MaxProgramSubroutineNumNv;

			/// <summary>
			/// [GL] Value of GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT symbol.
			/// </summary>
			[Limit(MAX_SHADER_PIXEL_LOCAL_STORAGE_FAST_SIZE_EXT)]
			[RequiredByFeature("GL_EXT_shader_pixel_local_storage", Api = "gles2")]
			public int MaxShaderPixelLocalStorageFastSizeExt;

			/// <summary>
			/// [GL] Value of GL_MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT symbol.
			/// </summary>
			[Limit(MAX_SHADER_PIXEL_LOCAL_STORAGE_SIZE_EXT)]
			[RequiredByFeature("GL_EXT_shader_pixel_local_storage", Api = "gles2")]
			public int MaxShaderPixelLocalStorageSizeExt;

			/// <summary>
			/// [GL] Value of GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB symbol.
			/// </summary>
			[Limit(MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB)]
			[RequiredByFeature("GL_ARB_texture_gather", Api = "gl|glcore")]
			public int MaxProgramTextureGatherComponentsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_IMAGE_SAMPLES symbol.
			/// </summary>
			[Limit(MAX_IMAGE_SAMPLES)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_shader_image_load_store")]
			public int MaxImageSamples;

			/// <summary>
			/// [GL4] Gl.Get: data returns one value, the minimum alignment in basic machine units of pointers returned fromGl.MapBuffer 
			/// and Gl.MapBufferRange. This value must be a power of two and must be at least 64.
			/// </summary>
			[Limit(MIN_MAP_BUFFER_ALIGNMENT)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_map_buffer_alignment", Api = "gl|glcore")]
			public int MinMapBufferAlignment;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in vertex shaders.
			/// </summary>
			[Limit(MAX_VERTEX_IMAGE_UNIFORMS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			public int MaxVertexImageUniforms;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in tesselation control 
			/// shaders.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_IMAGE_UNIFORMS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlImageUniforms;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in tesselation evaluation 
			/// shaders.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_IMAGE_UNIFORMS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationImageUniforms;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in geometry shaders.
			/// </summary>
			[Limit(MAX_GEOMETRY_IMAGE_UNIFORMS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryImageUniforms;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in fragment shaders. In GL ES 
			/// 3.1, the minimum value is 0. in GL ES 3.2, the minimum value is 4.
			/// </summary>
			[Limit(MAX_FRAGMENT_IMAGE_UNIFORMS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			public int MaxFragmentImageUniforms;

			/// <summary>
			/// [GL] Value of GL_MAX_COMBINED_IMAGE_UNIFORMS symbol.
			/// </summary>
			[Limit(MAX_COMBINED_IMAGE_UNIFORMS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			public int MaxCombinedImageUniforms;

			/// <summary>
			/// [GL] Value of GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV symbol.
			/// </summary>
			[Limit(MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV)]
			[RequiredByFeature("GL_NV_deep_texture3D")]
			public int MaxDeep3dTextureWidthHeightNv;

			/// <summary>
			/// [GL] Value of GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV symbol.
			/// </summary>
			[Limit(MAX_DEEP_3D_TEXTURE_DEPTH_NV)]
			[RequiredByFeature("GL_NV_deep_texture3D")]
			public int MaxDeep3dTextureDepthNv;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by 
			/// a vertex shader.
			/// </summary>
			[Limit(MAX_VERTEX_SHADER_STORAGE_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			public int MaxVertexShaderStorageBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by 
			/// a geometry shader.
			/// </summary>
			[Limit(MAX_GEOMETRY_SHADER_STORAGE_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryShaderStorageBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by 
			/// a tessellation control shader.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlShaderStorageBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by 
			/// a tessellation evaluation shader.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationShaderStorageBlocks;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a 
			/// fragment shader.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by a 
			/// fragment shader. In GL ES 3.1, the minimum value is 0. in GL ES 3.2, the minimum value is 4.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAGMENT_SHADER_STORAGE_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			public int MaxFragmentShaderStorageBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of active shader storage blocks that may be accessed by 
			/// a compute shader.
			/// </summary>
			[Limit(MAX_COMPUTE_SHADER_STORAGE_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			public int MaxComputeShaderStorageBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum total number of active shader storage blocks that may be 
			/// accessed by all active shaders.
			/// </summary>
			[Limit(MAX_COMBINED_SHADER_STORAGE_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			public int MaxCombinedShaderStorageBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of shader storage buffer binding points on the context, 
			/// which must be at least 8.
			/// </summary>
			[Limit(MAX_SHADER_STORAGE_BUFFER_BINDINGS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			public int MaxShaderStorageBufferBindings;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum size in basic machine units of a shader storage block. The value 
			/// must be at least 227.
			/// </summary>
			[Limit(MAX_SHADER_STORAGE_BLOCK_SIZE)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
			public int MaxShaderStorageBlockSize;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the number of invocations in a single local work group (i.e., the product 
			/// of the three dimensions) that may be dispatched to a compute shader.
			/// </summary>
			[Limit(MAX_COMPUTE_WORK_GROUP_INVOCATIONS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxComputeWorkGroupInvocations;

			/// <summary>
			/// [GL] Value of GL_MAX_MULTIVIEW_BUFFERS_EXT symbol.
			/// </summary>
			[Limit(MAX_MULTIVIEW_BUFFERS_EXT)]
			[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
			public int MaxMultiviewBuffersExt;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of samples in a color multisample texture.
			/// </summary>
			[Limit(MAX_COLOR_TEXTURE_SAMPLES)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			public int MaxColorTextureSamples;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of samples supported in integer format multisample 
			/// buffers.
			/// </summary>
			[Limit(MAX_INTEGER_SAMPLES)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
			public int MaxIntegerSamples;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum Gl.WaitSync timeout interval.
			/// </summary>
			[Limit(MAX_SERVER_WAIT_TIMEOUT)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
			[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
			public int MaxServerWaitTimeout;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of output written by a vertex shader, 
			/// which must be at least 64.
			/// </summary>
			[Limit(MAX_VERTEX_OUTPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			public int MaxVertexOutputComponents;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of inputs read by a geometry shader, 
			/// which must be at least 64.
			/// </summary>
			[Limit(MAX_GEOMETRY_INPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryInputComponents;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of components of outputs written by a geometry shader, 
			/// which must be at least 128.
			/// </summary>
			[Limit(MAX_GEOMETRY_OUTPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryOutputComponents;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of components of the inputs read by the fragment shader, which 
			/// must be at least 128.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of components of the inputs read by the fragment shader, 
			/// which must be at least 60.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAGMENT_INPUT_COMPONENTS)]
			[RequiredByFeature("GL_VERSION_3_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			public int MaxFragmentInputComponents;

			/// <summary>
			/// [GL] Value of GL_MAX_SAMPLES_IMG symbol.
			/// </summary>
			[Limit(MAX_SAMPLES_IMG)]
			[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
			public int MaxSamplesImg;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum length of a debug message string, including its null 
			/// terminator.
			/// </summary>
			[Limit(MAX_DEBUG_MESSAGE_LENGTH)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
			[RequiredByFeature("GL_AMD_debug_output")]
			[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
			public int MaxDebugMessageLength;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of messages stored in the debug message log.
			/// </summary>
			[Limit(MAX_DEBUG_LOGGED_MESSAGES)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
			[RequiredByFeature("GL_AMD_debug_output")]
			[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
			public int MaxDebugLoggedMessages;

			/// <summary>
			/// [GL] Value of GL_MAX_SPARSE_TEXTURE_SIZE_ARB symbol.
			/// </summary>
			[Limit(MAX_SPARSE_TEXTURE_SIZE_ARB)]
			[RequiredByFeature("GL_ARB_sparse_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
			[RequiredByFeature("GL_AMD_sparse_texture")]
			public int MaxSparseTextureSizeArb;

			/// <summary>
			/// [GL] Value of GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB symbol.
			/// </summary>
			[Limit(MAX_SPARSE_3D_TEXTURE_SIZE_ARB)]
			[RequiredByFeature("GL_ARB_sparse_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
			[RequiredByFeature("GL_AMD_sparse_texture")]
			public int MaxSparse3dTextureSizeArb;

			/// <summary>
			/// [GL] Value of GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS symbol.
			/// </summary>
			[Limit(MAX_SPARSE_ARRAY_TEXTURE_LAYERS)]
			[RequiredByFeature("GL_AMD_sparse_texture")]
			[RequiredByFeature("GL_ARB_sparse_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
			public int MaxSparseArrayTextureLayers;

			/// <summary>
			/// [GL] Value of GL_MIN_SPARSE_LEVEL_AMD symbol.
			/// </summary>
			[Limit(MIN_SPARSE_LEVEL_AMD)]
			[RequiredByFeature("GL_AMD_sparse_texture")]
			public int MinSparseLevelAmd;

			/// <summary>
			/// [GL] Value of GL_MIN_LOD_WARNING_AMD symbol.
			/// </summary>
			[Limit(MIN_LOD_WARNING_AMD)]
			[RequiredByFeature("GL_AMD_sparse_texture")]
			public int MinLodWarningAmd;

			/// <summary>
			/// [GL] Value of GL_MAX_SHADER_COMPILER_THREADS_ARB symbol.
			/// </summary>
			[Limit(MAX_SHADER_COMPILER_THREADS_ARB)]
			[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
			public int MaxShaderCompilerThreadsArb;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum number of uniform blocks per compute shader. The value must be 
			/// at least 14. See Gl.UniformBlockBinding.
			/// </summary>
			[Limit(MAX_COMPUTE_UNIFORM_BLOCKS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxComputeUniformBlocks;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns one value, the maximum supported texture image units that can be used to access 
			/// texture maps from the compute shader. The value may be at least 16. See Gl.ActiveTexture.
			/// </summary>
			[Limit(MAX_COMPUTE_TEXTURE_IMAGE_UNITS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxComputeTextureImageUnits;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in compute shaders.
			/// </summary>
			[Limit(MAX_COMPUTE_IMAGE_UNIFORMS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
			public int MaxComputeImageUniforms;

			/// <summary>
			/// [GL] Value of GL_MAX_LGPU_GPUS_NVX symbol.
			/// </summary>
			[Limit(MAX_LGPU_GPUS_NVX)]
			[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
			public int MaxLgpuGpusNvx;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS symbol.
			/// </summary>
			[Limit(MAX_VERTEX_ATOMIC_COUNTER_BUFFERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			public int MaxVertexAtomicCounterBuffers;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a 
			/// tesselation control shader.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlAtomicCounterBuffers;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a 
			/// tesselation evaluation shader.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationAtomicCounterBuffers;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a 
			/// geometry shader.
			/// </summary>
			[Limit(MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryAtomicCounterBuffers;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a 
			/// fragment shader. In GL ES 3.1, the minimum value is 0. in GL ES 3.2, the minimum value is 1.
			/// </summary>
			[Limit(MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			public int MaxFragmentAtomicCounterBuffers;

			/// <summary>
			/// [GL] Value of GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS symbol.
			/// </summary>
			[Limit(MAX_COMBINED_ATOMIC_COUNTER_BUFFERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			public int MaxCombinedAtomicCounterBuffers;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to vertex shaders.
			/// </summary>
			[Limit(MAX_VERTEX_ATOMIC_COUNTERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			public int MaxVertexAtomicCounters;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to tessellation 
			/// control shaders.
			/// </summary>
			[Limit(MAX_TESS_CONTROL_ATOMIC_COUNTERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessControlAtomicCounters;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to tessellation 
			/// evaluation shaders.
			/// </summary>
			[Limit(MAX_TESS_EVALUATION_ATOMIC_COUNTERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
			public int MaxTessEvaluationAtomicCounters;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to geometry shaders.
			/// </summary>
			[Limit(MAX_GEOMETRY_ATOMIC_COUNTERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxGeometryAtomicCounters;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns a single value, the maximum number of atomic counters available to fragment shaders.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to fragment shaders. In 
			/// GL ES 3.1, the minimum value is 0. in GL ES 3.2, the minimum value is 8.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAGMENT_ATOMIC_COUNTERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			public int MaxFragmentAtomicCounters;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to all active 
			/// shaders.
			/// </summary>
			[Limit(MAX_COMBINED_ATOMIC_COUNTERS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			public int MaxCombinedAtomicCounters;

			/// <summary>
			/// [GL] Value of GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE symbol.
			/// </summary>
			[Limit(MAX_ATOMIC_COUNTER_BUFFER_SIZE)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			public int MaxAtomicCounterBufferSize;

			/// <summary>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of atomic counter buffer binding points. The value must be 
			/// at least 1. See Gl.BindBuffer, Gl.BindBufferBase, and Gl.BindBufferRange.
			/// </summary>
			[Limit(MAX_ATOMIC_COUNTER_BUFFER_BINDINGS)]
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			public int MaxAtomicCounterBufferBindings;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum width for a framebuffer that has no attachments, which must be at 
			/// least 16384. See glFramebufferParameter.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum width for a framebuffer that has no attachments, which must be at 
			/// least 16384. See Gl.FramebufferParameteri.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAMEBUFFER_WIDTH)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
			public int MaxFramebufferWidth;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum height for a framebuffer that has no attachments, which must be at 
			/// least 16384. See glFramebufferParameter.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum height for a framebuffer that has no attachments, which must be at 
			/// least 16384. See Gl.FramebufferParameteri.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAMEBUFFER_HEIGHT)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
			public int MaxFramebufferHeight;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum number of layers for a framebuffer that has no attachments, which must 
			/// be at least 2048. See glFramebufferParameter.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum number of layers for a framebuffer that has no attachments, which 
			/// must be at least 256. See Gl.FramebufferParameteri.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAMEBUFFER_LAYERS)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
			[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
			public int MaxFramebufferLayers;

			/// <summary>
			/// <para>
			/// [GL4] Gl.Get: data returns one value, the maximum samples in a framebuffer that has no attachments, which must be at 
			/// least 4. See glFramebufferParameter.
			/// </para>
			/// <para>
			/// [GLES3.2] Gl.Get: data returns one value, the maximum samples in a framebuffer that has no attachments, which must be at 
			/// least 4. See Gl.FramebufferParameteri.
			/// </para>
			/// </summary>
			[Limit(MAX_FRAMEBUFFER_SAMPLES)]
			[RequiredByFeature("GL_VERSION_4_3")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
			public int MaxFramebufferSamples;

			/// <summary>
			/// [GL] Value of GL_MAX_RASTER_SAMPLES_EXT symbol.
			/// </summary>
			[Limit(MAX_RASTER_SAMPLES_EXT)]
			[RequiredByFeature("GL_EXT_raster_multisample", Api = "gl|glcore|gles2")]
			[RequiredByFeature("GL_EXT_texture_filter_minmax", Api = "gl|glcore|gles2")]
			[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|glcore|gles2")]
			public int MaxRasterSamplesExt;

			/// <summary>
			/// [GL] Value of GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB symbol.
			/// </summary>
			[Limit(MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB)]
			[RequiredByFeature("GL_ARB_compute_variable_group_size", Api = "gl|glcore")]
			public int MaxComputeVariableGroupInvocationsArb;

			/// <summary>
			/// [GL] Value of GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB symbol.
			/// </summary>
			[Limit(MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB)]
			[RequiredByFeature("GL_ARB_compute_variable_group_size", Api = "gl|glcore")]
			public int MaxComputeVariableGroupSizeArb;

			/// <summary>
			/// [GL] Value of GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV symbol.
			/// </summary>
			[Limit(MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV)]
			[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|glcore|gles2")]
			public int MaxSubpixelPrecisionBiasBitsNv;

			/// <summary>
			/// [GL] Value of GL_MAX_VIEWS_OVR symbol.
			/// </summary>
			[Limit(MAX_VIEWS_OVR)]
			[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
			public int MaxViewsOvr;

			/// <summary>
			/// [GL] Value of GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT symbol.
			/// </summary>
			[Limit(MAX_SHADER_COMBINED_LOCAL_STORAGE_FAST_SIZE_EXT)]
			[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
			public int MaxShaderCombinedLocalStorageFastSizeExt;

			/// <summary>
			/// [GL] Value of GL_MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT symbol.
			/// </summary>
			[Limit(MAX_SHADER_COMBINED_LOCAL_STORAGE_SIZE_EXT)]
			[RequiredByFeature("GL_EXT_shader_pixel_local_storage2", Api = "gles2")]
			public int MaxShaderCombinedLocalStorageSizeExt;

			/// <summary>
			/// [GL] Value of GL_MAX_VERTEX_HINT_PGI symbol.
			/// </summary>
			[Limit(MAX_VERTEX_HINT_PGI)]
			[RequiredByFeature("GL_PGI_vertex_hints")]
			public int MaxVertexHintPgi;

			/// <summary>
			/// [GL2.1] Gl.Get: params returns two values: the smallest and largest supported widths for antialiased lines. See 
			/// Gl.LineWidth.
			/// </summary>
			[Limit(LINE_WIDTH_RANGE, ArrayLength = 2)]
			[RequiredByFeature("GL_VERSION_1_0")]
			public float[] LineWidthRange = new float[] {0.0f, 0.0f };

			/// <summary>
			/// [GL2.1] Gl.Get: params returns one value, the width difference between adjacent supported widths for antialiased lines. 
			/// See Gl.LineWidth.
			/// </summary>
			[Limit(LINE_WIDTH_GRANULARITY)]
			[RequiredByFeature("GL_VERSION_1_0")]
			public float LineWidthGranularity;

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a pair of values indicating the range of widths supported for aliased lines. See 
			/// Gl.LineWidth.
			/// </summary>
			[Limit(ALIASED_LINE_WIDTH_RANGE, ArrayLength = 2)]
			[RequiredByFeature("GL_VERSION_1_2")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
			public float[] AliasedLineWidthRange = new float[] {0.0f, 0.0f };

			/// <summary>
			/// [GL4|GLES3.2] Gl.Get: data returns a single value, the minimum required alignment for uniform buffer sizes and offset. 
			/// The initial value is 1. See Gl.UniformBlockBinding.
			/// </summary>
			[Limit(UNIFORM_BUFFER_OFFSET_ALIGNMENT)]
			[RequiredByFeature("GL_VERSION_3_1")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
			public int UniformBufferOffsetAlignment;

		}
}

}
