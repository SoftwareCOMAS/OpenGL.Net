
// Copyright (C) 2015-2016 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_POSITIVE_X_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_POSITIVE_X_NV = 0x9350;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_NEGATIVE_X_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_NEGATIVE_X_NV = 0x9351;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_POSITIVE_Y_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_POSITIVE_Y_NV = 0x9352;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_NEGATIVE_Y_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_NEGATIVE_Y_NV = 0x9353;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_POSITIVE_Z_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_POSITIVE_Z_NV = 0x9354;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_NEGATIVE_Z_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_NEGATIVE_Z_NV = 0x9355;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_POSITIVE_W_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_POSITIVE_W_NV = 0x9356;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_NEGATIVE_W_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_NEGATIVE_W_NV = 0x9357;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_X_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_X_NV = 0x9358;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_Y_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_Y_NV = 0x9359;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_Z_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_Z_NV = 0x935A;

		/// <summary>
		/// Value of GL_VIEWPORT_SWIZZLE_W_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public const int VIEWPORT_SWIZZLE_W_NV = 0x935B;

		/// <summary>
		/// Binding for glViewportSwizzleNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="swizzlex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="swizzley">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="swizzlez">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="swizzlew">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
		public static void ViewportSwizzleNV(UInt32 index, Int32 swizzlex, Int32 swizzley, Int32 swizzlez, Int32 swizzlew)
		{
			Debug.Assert(Delegates.pglViewportSwizzleNV != null, "pglViewportSwizzleNV not implemented");
			Delegates.pglViewportSwizzleNV(index, swizzlex, swizzley, swizzlez, swizzlew);
			LogFunction("glViewportSwizzleNV({0}, {1}, {2}, {3}, {4})", index, LogEnumName(swizzlex), LogEnumName(swizzley), LogEnumName(swizzlez), LogEnumName(swizzlew));
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glViewportSwizzleNV", ExactSpelling = true)]
			internal extern static void glViewportSwizzleNV(UInt32 index, Int32 swizzlex, Int32 swizzley, Int32 swizzlez, Int32 swizzlew);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_viewport_swizzle", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glViewportSwizzleNV(UInt32 index, Int32 swizzlex, Int32 swizzley, Int32 swizzlez, Int32 swizzlew);

			[ThreadStatic]
			internal static glViewportSwizzleNV pglViewportSwizzleNV;

		}
	}

}
